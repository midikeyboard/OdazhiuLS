import sys
import os
import time
import random
import numpy as np
import sounddevice as sd

os.environ['PATH'] = r"C:\EDIABAS\bin;" + os.environ.get('PATH', '')
if hasattr(os, 'add_dll_directory'):
    try:
        os.add_dll_directory(r"C:\EDIABAS\bin")
    except Exception:
        pass

from pydiabas import PyDIABAS

CHUNK = 1024
RATE = 44100
BASS_MAX_FREQ = 140

COOLDOWN = 0.06

LIGHT_COMBOS = [
    ["FL_L", "FL_R"],
    ["BLK_LV", "BLK_RV"],
    ["FL_L", "FL_R", "REL_NSW"],
    ["BLK_LV", "BLK_RV", "REL_NSW"]
]

freqs = np.fft.rfftfreq(CHUNK, 1.0 / RATE)
bass_mask = freqs < BASS_MAX_FREQ


def get_bass_volume(indata):
    mono = np.mean(indata, axis=1)
    fft_data = np.fft.rfft(mono)
    bass_fft = np.abs(fft_data[bass_mask])
    return np.mean(bass_fft)


def run_music_show():
    current_threshold = 25.0
    last_file_read = 0.0

    print("[*] Connecting to EDIABAS...")

    try:
        with PyDIABAS() as bmw:
            with sd.InputStream(samplerate=RATE, channels=1, blocksize=CHUNK) as stream:

                while True:
                    now = time.time()
                    if now - last_file_read > 0.5:
                        try:
                            with open("threshold.txt", "r") as f:
                                content = f.read().strip()
                                if content:
                                    current_threshold = float(content)
                        except:
                            pass
                        last_file_read = now

                    data, overflowed = stream.read(CHUNK)
                    bass_vol = get_bass_volume(data)

                    bar_length = int(min(bass_vol * 0.8, 50))
                    bar = "#" * bar_length

                    if bass_vol > current_threshold:
                        print(f"\r[ Бас ] {bar:<50} (Vol: {bass_vol:.1f})", end="", flush=True)

                        random_lights = random.choice(LIGHT_COMBOS)

                        bmw.job("LSZ", "STEUERN_IO", random_lights)
                        time.sleep(0.03)
                        bmw.job("LSZ", "DIAGNOSE_ENDE")

                        time.sleep(COOLDOWN)

                        stream.read(stream.read_available)
                    else:
                        print(f"\r[     ] {bar:<50} (Vol: {bass_vol:.1f})", end="", flush=True)

    except KeyboardInterrupt:
        print("\n\n The music show has been stopped.")
        try:
            with PyDIABAS() as bmw:
                bmw.job("LSZ", "DIAGNOSE_ENDE")
        except:
            pass
    except Exception as e:
        print(f"\n Critical error: {e}")


if __name__ == "__main__":
    if len(sys.argv) == 2 and sys.argv[1].lower() == "stop":
        try:
            with PyDIABAS() as bmw:
                bmw.job("LSZ", "DIAGNOSE_ENDE")
        except:
            pass
        sys.exit(0)

    run_music_show()
