﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.AGauge1 = New AGauge.AGauge()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AGauge2 = New AGauge.AGauge()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AGauge1
        '
        Me.AGauge1.BaseArcColor = System.Drawing.Color.Gray
        Me.AGauge1.BaseArcRadius = 80
        Me.AGauge1.BaseArcStart = 135
        Me.AGauge1.BaseArcSweep = 270
        Me.AGauge1.BaseArcWidth = 2
        Me.AGauge1.Cap_Idx = CType(1, Byte)
        Me.AGauge1.CapColors = New System.Drawing.Color() {System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black}
        Me.AGauge1.CapPosition = New System.Drawing.Point(10, 10)
        Me.AGauge1.CapsPosition = New System.Drawing.Point() {New System.Drawing.Point(10, 10), New System.Drawing.Point(10, 10), New System.Drawing.Point(10, 10), New System.Drawing.Point(10, 10), New System.Drawing.Point(10, 10)}
        Me.AGauge1.CapsText = New String() {"", "", "", "", ""}
        Me.AGauge1.CapText = ""
        Me.AGauge1.Center = New System.Drawing.Point(100, 100)
        Me.AGauge1.Location = New System.Drawing.Point(50, 248)
        Me.AGauge1.MaxValue = 400.0!
        Me.AGauge1.MinValue = -100.0!
        Me.AGauge1.Name = "AGauge1"
        Me.AGauge1.NeedleColor1 = AGauge.AGauge.NeedleColorEnum.Gray
        Me.AGauge1.NeedleColor2 = System.Drawing.Color.DimGray
        Me.AGauge1.NeedleRadius = 80
        Me.AGauge1.NeedleType = 0
        Me.AGauge1.NeedleWidth = 2
        Me.AGauge1.Range_Idx = CType(0, Byte)
        Me.AGauge1.RangeColor = System.Drawing.Color.LightGreen
        Me.AGauge1.RangeEnabled = True
        Me.AGauge1.RangeEndValue = 300.0!
        Me.AGauge1.RangeInnerRadius = 70
        Me.AGauge1.RangeOuterRadius = 80
        Me.AGauge1.RangesColor = New System.Drawing.Color() {System.Drawing.Color.LightGreen, System.Drawing.Color.Red, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Control}
        Me.AGauge1.RangesEnabled = New Boolean() {True, True, False, False, False}
        Me.AGauge1.RangesEndValue = New Single() {300.0!, 400.0!, 0!, 0!, 0!}
        Me.AGauge1.RangesInnerRadius = New Integer() {70, 70, 70, 70, 70}
        Me.AGauge1.RangesOuterRadius = New Integer() {80, 80, 80, 80, 80}
        Me.AGauge1.RangesStartValue = New Single() {-100.0!, 300.0!, 0!, 0!, 0!}
        Me.AGauge1.RangeStartValue = -100.0!
        Me.AGauge1.ScaleLinesInterColor = System.Drawing.Color.Black
        Me.AGauge1.ScaleLinesInterInnerRadius = 73
        Me.AGauge1.ScaleLinesInterOuterRadius = 80
        Me.AGauge1.ScaleLinesInterWidth = 1
        Me.AGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black
        Me.AGauge1.ScaleLinesMajorInnerRadius = 70
        Me.AGauge1.ScaleLinesMajorOuterRadius = 80
        Me.AGauge1.ScaleLinesMajorStepValue = 50.0!
        Me.AGauge1.ScaleLinesMajorWidth = 2
        Me.AGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray
        Me.AGauge1.ScaleLinesMinorInnerRadius = 75
        Me.AGauge1.ScaleLinesMinorNumOf = 9
        Me.AGauge1.ScaleLinesMinorOuterRadius = 80
        Me.AGauge1.ScaleLinesMinorWidth = 1
        Me.AGauge1.ScaleNumbersColor = System.Drawing.Color.Black
        Me.AGauge1.ScaleNumbersFormat = Nothing
        Me.AGauge1.ScaleNumbersRadius = 95
        Me.AGauge1.ScaleNumbersRotation = 0
        Me.AGauge1.ScaleNumbersStartScaleLine = 0
        Me.AGauge1.ScaleNumbersStepScaleLines = 1
        Me.AGauge1.Size = New System.Drawing.Size(243, 225)
        Me.AGauge1.TabIndex = 0
        Me.AGauge1.Text = "AGauge1"
        Me.AGauge1.Value = 0!
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(380, 438)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 49)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "CONNECT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(0, 438)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(91, 107)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(114, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(91, 81)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(114, 20)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(91, 55)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(114, 20)
        Me.TextBox4.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Location = New System.Drawing.Point(0, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(208, 130)
        Me.Panel1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "RAW DATA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Raw Data 3:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Raw Data 2:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Raw Data 1:"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(125, 379)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(40, 15)
        Me.TextBox5.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(155, 378)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "*C"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Location = New System.Drawing.Point(413, 380)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(42, 13)
        Me.TextBox6.TabIndex = 12
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Location = New System.Drawing.Point(599, 321)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(29, 13)
        Me.TextBox7.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(260, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(445, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Supervisory Control and Data Acquisition"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(112, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Sensor 1"
        '
        'AGauge2
        '
        Me.AGauge2.BaseArcColor = System.Drawing.Color.Gray
        Me.AGauge2.BaseArcRadius = 80
        Me.AGauge2.BaseArcStart = 135
        Me.AGauge2.BaseArcSweep = 270
        Me.AGauge2.BaseArcWidth = 2
        Me.AGauge2.Cap_Idx = CType(1, Byte)
        Me.AGauge2.CapColors = New System.Drawing.Color() {System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black}
        Me.AGauge2.CapPosition = New System.Drawing.Point(10, 10)
        Me.AGauge2.CapsPosition = New System.Drawing.Point() {New System.Drawing.Point(10, 10), New System.Drawing.Point(10, 10), New System.Drawing.Point(10, 10), New System.Drawing.Point(10, 10), New System.Drawing.Point(10, 10)}
        Me.AGauge2.CapsText = New String() {"", "", "", "", ""}
        Me.AGauge2.CapText = ""
        Me.AGauge2.Center = New System.Drawing.Point(100, 100)
        Me.AGauge2.Location = New System.Drawing.Point(350, 248)
        Me.AGauge2.MaxValue = 400.0!
        Me.AGauge2.MinValue = -100.0!
        Me.AGauge2.Name = "AGauge2"
        Me.AGauge2.NeedleColor1 = AGauge.AGauge.NeedleColorEnum.Gray
        Me.AGauge2.NeedleColor2 = System.Drawing.Color.DimGray
        Me.AGauge2.NeedleRadius = 80
        Me.AGauge2.NeedleType = 0
        Me.AGauge2.NeedleWidth = 2
        Me.AGauge2.Range_Idx = CType(0, Byte)
        Me.AGauge2.RangeColor = System.Drawing.Color.LightGreen
        Me.AGauge2.RangeEnabled = True
        Me.AGauge2.RangeEndValue = 300.0!
        Me.AGauge2.RangeInnerRadius = 70
        Me.AGauge2.RangeOuterRadius = 80
        Me.AGauge2.RangesColor = New System.Drawing.Color() {System.Drawing.Color.LightGreen, System.Drawing.Color.Red, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Control}
        Me.AGauge2.RangesEnabled = New Boolean() {True, True, False, False, False}
        Me.AGauge2.RangesEndValue = New Single() {300.0!, 400.0!, 0!, 0!, 0!}
        Me.AGauge2.RangesInnerRadius = New Integer() {70, 70, 70, 70, 70}
        Me.AGauge2.RangesOuterRadius = New Integer() {80, 80, 80, 80, 80}
        Me.AGauge2.RangesStartValue = New Single() {-100.0!, 300.0!, 0!, 0!, 0!}
        Me.AGauge2.RangeStartValue = -100.0!
        Me.AGauge2.ScaleLinesInterColor = System.Drawing.Color.Black
        Me.AGauge2.ScaleLinesInterInnerRadius = 73
        Me.AGauge2.ScaleLinesInterOuterRadius = 80
        Me.AGauge2.ScaleLinesInterWidth = 1
        Me.AGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black
        Me.AGauge2.ScaleLinesMajorInnerRadius = 70
        Me.AGauge2.ScaleLinesMajorOuterRadius = 80
        Me.AGauge2.ScaleLinesMajorStepValue = 50.0!
        Me.AGauge2.ScaleLinesMajorWidth = 2
        Me.AGauge2.ScaleLinesMinorColor = System.Drawing.Color.Gray
        Me.AGauge2.ScaleLinesMinorInnerRadius = 75
        Me.AGauge2.ScaleLinesMinorNumOf = 9
        Me.AGauge2.ScaleLinesMinorOuterRadius = 80
        Me.AGauge2.ScaleLinesMinorWidth = 1
        Me.AGauge2.ScaleNumbersColor = System.Drawing.Color.Black
        Me.AGauge2.ScaleNumbersFormat = Nothing
        Me.AGauge2.ScaleNumbersRadius = 95
        Me.AGauge2.ScaleNumbersRotation = 0
        Me.AGauge2.ScaleNumbersStartScaleLine = 0
        Me.AGauge2.ScaleNumbersStepScaleLines = 1
        Me.AGauge2.Size = New System.Drawing.Size(243, 225)
        Me.AGauge2.TabIndex = 15
        Me.AGauge2.Text = "AGauge2"
        Me.AGauge2.Value = 0!
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(461, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Psi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 505)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AGauge1)
        Me.Controls.Add(Me.AGauge2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AGauge1 As AGauge.AGauge
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents AGauge2 As AGauge.AGauge
    Friend WithEvents Label8 As Label
End Class
