<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        btnAdd = New Button()
        lstLamps = New ListBox()
        btnOK = New Button()
        btnCancel = New Button()
        btnClear = New Button()
        lblTimeBet = New Label()
        txtTimeBet = New TextBox()
        cmbLamps = New ComboBox()
        txtCycle = New TextBox()
        lblCycle = New Label()
        txtTimeIg = New TextBox()
        lblTimeIg = New Label()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(361, 7)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(102, 29)
        btnAdd.TabIndex = 1
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' lstLamps
        ' 
        lstLamps.FormattingEnabled = True
        lstLamps.Location = New Point(167, 42)
        lstLamps.Name = "lstLamps"
        lstLamps.Size = New Size(296, 244)
        lstLamps.TabIndex = 3
        ' 
        ' btnOK
        ' 
        btnOK.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        btnOK.Location = New Point(10, 237)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(151, 49)
        btnOK.TabIndex = 5
        btnOK.Text = "Start"
        btnOK.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        btnCancel.Location = New Point(12, 184)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(151, 47)
        btnCancel.TabIndex = 6
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(12, 42)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(151, 29)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lblTimeBet
        ' 
        lblTimeBet.AutoSize = True
        lblTimeBet.Location = New Point(12, 82)
        lblTimeBet.Name = "lblTimeBet"
        lblTimeBet.Size = New Size(106, 20)
        lblTimeBet.TabIndex = 9
        lblTimeBet.Text = "Time between:"
        ' 
        ' txtTimeBet
        ' 
        txtTimeBet.Location = New Point(124, 79)
        txtTimeBet.Name = "txtTimeBet"
        txtTimeBet.Size = New Size(37, 27)
        txtTimeBet.TabIndex = 10
        ' 
        ' cmbLamps
        ' 
        cmbLamps.FormattingEnabled = True
        cmbLamps.Items.AddRange(New Object() {"Левый ближний", "Правый ближний", "Левый дальний", "Правый дальний", "Шторка би-ксенона", "Левый передний габарит", "Правый передний габарит", "Левый передний поворотник", "Правый передний поворотник", "Левый боковой поворотник", "Правый боковой поворотник", "Противотуманные фары", "Левый стоп-сигнал", "Правый стоп-сигнал", "Центральный стоп-сигнал", "Левый задний поворотник", "Правый задний поворотник", "Левый задний габарит 1", "Правый задний габарит 1", "Правый задний габарит 2", "Левый задний габарит 3", "Правый задний габарит 3", "Задние противотуманные фонари", "Подсветка заднего номера"})
        cmbLamps.Location = New Point(12, 7)
        cmbLamps.Name = "cmbLamps"
        cmbLamps.Size = New Size(343, 28)
        cmbLamps.TabIndex = 11
        ' 
        ' txtCycle
        ' 
        txtCycle.Location = New Point(124, 146)
        txtCycle.Name = "txtCycle"
        txtCycle.Size = New Size(37, 27)
        txtCycle.TabIndex = 13
        ' 
        ' lblCycle
        ' 
        lblCycle.AutoSize = True
        lblCycle.Location = New Point(12, 149)
        lblCycle.Name = "lblCycle"
        lblCycle.Size = New Size(47, 20)
        lblCycle.TabIndex = 14
        lblCycle.Text = "Cycle:"
        ' 
        ' txtTimeIg
        ' 
        txtTimeIg.Location = New Point(124, 112)
        txtTimeIg.Name = "txtTimeIg"
        txtTimeIg.Size = New Size(37, 27)
        txtTimeIg.TabIndex = 15
        ' 
        ' lblTimeIg
        ' 
        lblTimeIg.AutoSize = True
        lblTimeIg.Location = New Point(12, 115)
        lblTimeIg.Name = "lblTimeIg"
        lblTimeIg.Size = New Size(97, 20)
        lblTimeIg.TabIndex = 16
        lblTimeIg.Text = "Ignition time:"
        ' 
        ' Form2
        ' 
        AcceptButton = btnOK
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnCancel
        ClientSize = New Size(475, 293)
        Controls.Add(lblTimeIg)
        Controls.Add(txtTimeIg)
        Controls.Add(lblCycle)
        Controls.Add(txtCycle)
        Controls.Add(cmbLamps)
        Controls.Add(txtTimeBet)
        Controls.Add(lblTimeBet)
        Controls.Add(btnClear)
        Controls.Add(btnCancel)
        Controls.Add(btnOK)
        Controls.Add(lstLamps)
        Controls.Add(btnAdd)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        Text = "Custom "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lstLamps As ListBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblTimeBet As Label
    Friend WithEvents txtTimeBet As TextBox
    Friend WithEvents cmbLamps As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCycle As TextBox
    Friend WithEvents lblCycle As Label
    Friend WithEvents txtTimeIg As TextBox
    Friend WithEvents lblTimeIg As Label
End Class
