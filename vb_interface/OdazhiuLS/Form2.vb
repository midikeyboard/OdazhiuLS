Imports System.ComponentModel

Public Class Form2
    Public finalTimeBet As String
    Public finalTimeIg As String
    Public finalCycle As String
    Public finalLamps As New List(Of String)
    Private lampTranslator As New Dictionary(Of String, String)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnOK.Enabled = False

        lampTranslator.Add("Левый ближний", "AL_L")
        lampTranslator.Add("Правый ближний свет", "AL_R")
        lampTranslator.Add("Левый дальний", "FL_L")
        lampTranslator.Add("Правый дальний", "FL_R")
        lampTranslator.Add("Шторка би-ксенона", "BIXENON")
        lampTranslator.Add("Левый передний габарит", "SL_LV")
        lampTranslator.Add("Правый передний габарит", "SL_RV")
        lampTranslator.Add("Левый передний поворотник", "BLK_LV")
        lampTranslator.Add("Правый передний поворотник", "BLK_RV")
        lampTranslator.Add("Левый боковой поворотник", "BLK_ZU_L")
        lampTranslator.Add("Правый боковой поворотник", "BLK_ZU_R")
        lampTranslator.Add("Противотуманные фары", "REL_NSW")
        lampTranslator.Add("Левый стоп-сигнал", "BL_L")
        lampTranslator.Add("Правый стоп-сигнал", "BL_R")
        lampTranslator.Add("Центральный стоп-сигнал", "BL_M")
        lampTranslator.Add("Левый задний поворотник", "BLK_LH")
        lampTranslator.Add("Правый задний поворотник", "BLK_RH")
        lampTranslator.Add("Левый задний габарит 1", "SL_LH")
        lampTranslator.Add("Правый задний габарит 1", "SL_RH")
        lampTranslator.Add("Правый задний габарит 2", "SL1_RH")
        lampTranslator.Add("Левый задний габарит 3", "SL2_LH")
        lampTranslator.Add("Правый задний габарит 3", "SL2_RH")
        lampTranslator.Add("Задние противотуманные фонари", "NSL")
        lampTranslator.Add("Подсветка заднего номера", "KZL")
    End Sub

    'add
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbLamps.SelectedIndex <> -1 Then
            lstLamps.Items.Add(cmbLamps.SelectedItem.ToString())
            Perevirka()
        Else
            MsgBox("Please select a lamp from the list!" & vbCrLf & "Пожалуйста, выберите лампу из списка!", MsgBoxStyle.Exclamation, "Attention")
        End If
    End Sub

    'clear
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstLamps.Items.Clear()
        Perevirka()
    End Sub

    'start
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        finalLamps.Clear()

        For Each item As Object In lstLamps.Items
            Dim hNameLamp As String = item.ToString()

            If lampTranslator.ContainsKey(hNameLamp) Then
                Dim realNameLamp As String = lampTranslator(hNameLamp)
                finalLamps.Add(realNameLamp)
            End If
        Next

        finalTimeBet = txtTimeBet.Text
        finalTimeIg = txtTimeIg.Text
        finalCycle = txtCycle.Text

        Me.DialogResult = DialogResult.OK

        Me.Close()
    End Sub

    Private Sub txtCycle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCycle.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

        If txtCycle.Text.Length = 0 AndAlso e.KeyChar = "0"c Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCycle.KeyUp, txtTimeBet.KeyUp, txtTimeIg.KeyUp
        Perevirka()
    End Sub

    Private Sub txtTimeBet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTimeBet.KeyPress
        If e.KeyChar = ","c Then
            e.KeyChar = "."c
        End If

        If e.KeyChar = "."c AndAlso txtTimeBet.SelectionStart = 0 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        If e.KeyChar = "."c AndAlso txtTimeBet.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTimeBet_Validating(sender As Object, e As CancelEventArgs) Handles txtTimeBet.Validating
        If txtTimeBet.Text.Trim = "" Then
            MsgBox("Please enter the correct time before starting!" & vbCrLf & "Введите коректное время перед пуском!", MsgBoxStyle.Critical, "Error input")
            e.Cancel = True
        End If
    End Sub

    Private Sub txtTimeIg_Validating(sender As Object, e As CancelEventArgs) Handles txtTimeIg.Validating
        If txtTimeIg.Text.Trim = "" Then
            MsgBox("Please enter the correct time before starting!" & vbCrLf & "Введите коректное время перед пуском!", MsgBoxStyle.Critical, "Error input")
            e.Cancel = True
            Exit Sub
        End If

        If Val(txtTimeIg.Text) < 0.1 Then
            MsgBox("Time must be more than 0.1 seconds!" & vbCrLf & "Время должно быть больше 0.1 секунды!", MsgBoxStyle.Critical, "Error input")
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub txtTimeIg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTimeIg.KeyPress
        If e.KeyChar = ","c Then
            e.KeyChar = "."c
        End If

        If e.KeyChar = "."c AndAlso txtTimeIg.SelectionStart = 0 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        If e.KeyChar = "."c AndAlso txtTimeIg.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub Perevirka()
        Dim isDataValid As Boolean = False

        If txtTimeBet.Text.Trim <> "" AndAlso txtCycle.Text.Trim <> "" AndAlso lstLamps.Items.Count <> 0 AndAlso txtTimeIg.Text.Trim <> "" Then
            isDataValid = True
        End If

        btnOK.Enabled = isDataValid
    End Sub

End Class