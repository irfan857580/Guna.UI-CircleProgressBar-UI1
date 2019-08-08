<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GunaCircleProgressBar1 = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.GunaCircleProgressBar2 = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.GunaCircleProgressBar3 = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.GunaSwitch1 = New Guna.UI.WinForms.GunaSwitch()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaCircleProgressBar1.SuspendLayout()
        Me.GunaCircleProgressBar2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaCircleProgressBar1
        '
        Me.GunaCircleProgressBar1.AnimationSpeed = 0.6!
        Me.GunaCircleProgressBar1.BaseColor = System.Drawing.Color.Black
        Me.GunaCircleProgressBar1.Controls.Add(Me.GunaCircleProgressBar2)
        Me.GunaCircleProgressBar1.IdleColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.GunaCircleProgressBar1.IdleOffset = 20
        Me.GunaCircleProgressBar1.Image = Nothing
        Me.GunaCircleProgressBar1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleProgressBar1.LineEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.GunaCircleProgressBar1.LineStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.GunaCircleProgressBar1.Location = New System.Drawing.Point(94, 57)
        Me.GunaCircleProgressBar1.Name = "GunaCircleProgressBar1"
        Me.GunaCircleProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaCircleProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaCircleProgressBar1.ProgressOffset = 20
        Me.GunaCircleProgressBar1.Size = New System.Drawing.Size(300, 300)
        Me.GunaCircleProgressBar1.TabIndex = 0
        Me.GunaCircleProgressBar1.Value = 30
        '
        'GunaCircleProgressBar2
        '
        Me.GunaCircleProgressBar2.AnimationSpeed = 0.6!
        Me.GunaCircleProgressBar2.BackColor = System.Drawing.Color.Transparent
        Me.GunaCircleProgressBar2.BaseColor = System.Drawing.Color.Black
        Me.GunaCircleProgressBar2.Controls.Add(Me.GunaCircleProgressBar3)
        Me.GunaCircleProgressBar2.IdleColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleProgressBar2.IdleOffset = 20
        Me.GunaCircleProgressBar2.Image = Nothing
        Me.GunaCircleProgressBar2.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleProgressBar2.LineEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.GunaCircleProgressBar2.LineStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.GunaCircleProgressBar2.Location = New System.Drawing.Point(30, 30)
        Me.GunaCircleProgressBar2.Name = "GunaCircleProgressBar2"
        Me.GunaCircleProgressBar2.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleProgressBar2.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleProgressBar2.ProgressOffset = 20
        Me.GunaCircleProgressBar2.Size = New System.Drawing.Size(240, 240)
        Me.GunaCircleProgressBar2.TabIndex = 1
        Me.GunaCircleProgressBar2.Value = 50
        '
        'GunaCircleProgressBar3
        '
        Me.GunaCircleProgressBar3.AnimationSpeed = 0.6!
        Me.GunaCircleProgressBar3.BackColor = System.Drawing.Color.Transparent
        Me.GunaCircleProgressBar3.BaseColor = System.Drawing.Color.Black
        Me.GunaCircleProgressBar3.IdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.GunaCircleProgressBar3.IdleOffset = 20
        Me.GunaCircleProgressBar3.Image = Nothing
        Me.GunaCircleProgressBar3.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleProgressBar3.LineEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.GunaCircleProgressBar3.LineStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.GunaCircleProgressBar3.Location = New System.Drawing.Point(30, 30)
        Me.GunaCircleProgressBar3.Name = "GunaCircleProgressBar3"
        Me.GunaCircleProgressBar3.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GunaCircleProgressBar3.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GunaCircleProgressBar3.ProgressOffset = 20
        Me.GunaCircleProgressBar3.Size = New System.Drawing.Size(180, 180)
        Me.GunaCircleProgressBar3.TabIndex = 2
        Me.GunaCircleProgressBar3.Value = 20
        '
        'GunaSwitch1
        '
        Me.GunaSwitch1.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaSwitch1.CheckedOffColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaSwitch1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaSwitch1.FillColor = System.Drawing.Color.White
        Me.GunaSwitch1.Location = New System.Drawing.Point(543, 166)
        Me.GunaSwitch1.Name = "GunaSwitch1"
        Me.GunaSwitch1.Size = New System.Drawing.Size(28, 20)
        Me.GunaSwitch1.TabIndex = 1
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(543, 265)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 4
        Me.GunaButton1.Size = New System.Drawing.Size(98, 42)
        Me.GunaButton1.TabIndex = 2
        Me.GunaButton1.Text = "RESET"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(540, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Animated:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'Timer2
        '
        Me.Timer2.Interval = 40
        '
        'Timer3
        '
        Me.Timer3.Interval = 17
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(543, 217)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Radius = 4
        Me.GunaButton2.Size = New System.Drawing.Size(98, 42)
        Me.GunaButton2.TabIndex = 4
        Me.GunaButton2.Text = "START"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(746, 450)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.GunaSwitch1)
        Me.Controls.Add(Me.GunaCircleProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GunaCircleProgressBar1.ResumeLayout(False)
        Me.GunaCircleProgressBar2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaCircleProgressBar1 As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents GunaCircleProgressBar2 As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents GunaCircleProgressBar3 As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents GunaSwitch1 As Guna.UI.WinForms.GunaSwitch
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
End Class
