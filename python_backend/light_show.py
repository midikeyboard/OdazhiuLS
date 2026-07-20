import sys
import os


os.environ['PATH'] = r"C:\EDIABAS\bin;" + os.environ.get('PATH', '')

if hasattr(os, 'add_dll_directory'):
    try:
        os.add_dll_directory(r"C:\EDIABAS\bin")
    except Exception:
        pass

import time
from pydiabas import PyDIABAS

def run_dynamic_show(bmw, on_time, off_time, cycles, lamps_list):
    for i in range(cycles):
        for light in lamps_list:
            print(f"[*] {light}")
            bmw.job("LSZ", "STEUERN_IO", light)
            time.sleep(on_time)

            print(f"[-] {light}")
            bmw.job("LSZ", "DIAGNOSE_ENDE")

            if off_time > 0:
                time.sleep(off_time)

    time.sleep(0.3)

    all_front_lights = ["SL_LV", "SL_RV", "BLK_LV", "REL_NSW", "FL_L", "FL_R", "BLK_RV"]
    bmw.job("LSZ", "STEUERN_IO", all_front_lights)

    time.sleep(1.0)


if __name__ == "__main__":
    if len(sys.argv) == 2 and sys.argv[1].lower() == 'stop':
        try:
            with PyDIABAS() as bmw:
                bmw.job("LSZ", "DIAGNOSE_ENDE")
        except:
            pass
        sys.exit(0)

    if len(sys.argv) < 5:
        print("Error:")
        input("Press Enter to exit.")
        sys.exit(1)

    try:
        on_time = float(sys.argv[1].replace(',', '.'))
        off_time = float(sys.argv[2].replace(',', '.'))
        cycles = int(sys.argv[3])

        lamps_raw = sys.argv[4]
        lamps_list = lamps_raw.split(',')

    except ValueError as e:
        print("Error")
        sys.exit(1)

    try:
        with PyDIABAS() as bmw:
            try:
                run_dynamic_show(bmw, on_time, off_time, cycles, lamps_list)

            except KeyboardInterrupt:
                print("\n Stopped via interface (Stop)")
            except Exception as inner_e:
                print(f"\n Error during the show: {inner_e}")
            finally:
                try:
                    bmw.job("LSZ", "DIAGNOSE_ENDE")
                except:
                    pass
    except Exception as e:
        print(f"\n Critical error connecting to EDIABAS: {e}")
