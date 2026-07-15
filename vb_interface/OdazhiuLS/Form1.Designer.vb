<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnDefault = New Button()
        PictureBox1 = New PictureBox()
        btnStop = New Button()
        btnMusic = New Button()
        btnCustom = New Button()
        lblTime = New Label()
        txtTime = New TextBox()
        tmrStartTime = New Timer(components)
        lblSecond = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnDefault
        ' 
        btnDefault.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        btnDefault.Location = New Point(12, 13)
        btnDefault.Name = "btnDefault"
        btnDefault.Size = New Size(150, 150)
        btnDefault.TabIndex = 0
        btnDefault.Text = "Default Show"
        btnDefault.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(324, 204)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 115)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' btnStop
        ' 
        btnStop.Font = New Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        btnStop.Location = New Point(12, 168)
        btnStop.Name = "btnStop"
        btnStop.Size = New Size(306, 150)
        btnStop.TabIndex = 7
        btnStop.Text = "STOP"
        btnStop.UseVisualStyleBackColor = True
        ' 
        ' btnMusic
        ' 
        btnMusic.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        btnMusic.Location = New Point(168, 12)
        btnMusic.Name = "btnMusic"
        btnMusic.Size = New Size(150, 150)
        btnMusic.TabIndex = 8
        btnMusic.Text = "Music Show"
        btnMusic.UseVisualStyleBackColor = True
        ' 
        ' btnCustom
        ' 
        btnCustom.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        btnCustom.Location = New Point(325, 13)
        btnCustom.Name = "btnCustom"
        btnCustom.Size = New Size(150, 150)
        btnCustom.TabIndex = 9
        btnCustom.Text = "Custom Show"
        btnCustom.UseVisualStyleBackColor = True
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        lblTime.Location = New Point(325, 171)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(96, 20)
        lblTime.TabIndex = 10
        lblTime.Text = "Time to start:"
        ' 
        ' txtTime
        ' 
        txtTime.Location = New Point(418, 168)
        txtTime.Name = "txtTime"
        txtTime.Size = New Size(33, 27)
        txtTime.TabIndex = 11
        ' 
        ' tmrStartTime
        ' 
        tmrStartTime.Interval = 1000
        ' 
        ' lblSecond
        ' 
        lblSecond.AutoSize = True
        lblSecond.Location = New Point(457, 171)
        lblSecond.Name = "lblSecond"
        lblSecond.Size = New Size(18, 20)
        lblSecond.TabIndex = 12
        lblSecond.Text = "s."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(487, 331)
        Controls.Add(lblSecond)
        Controls.Add(txtTime)
        Controls.Add(lblTime)
        Controls.Add(btnCustom)
        Controls.Add(btnMusic)
        Controls.Add(btnStop)
        Controls.Add(PictureBox1)
        Controls.Add(btnDefault)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "OdazhiuLS"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnDefault As Button
    Friend WithEvents lblSecond As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnMusic As Button
    Friend WithEvents btnCustom As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents tmrStartTime As Timer

End Class
