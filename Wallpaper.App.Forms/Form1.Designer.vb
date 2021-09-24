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
        Me.cboxLength = New System.Windows.Forms.ComboBox()
        Me.cboxWidth = New System.Windows.Forms.ComboBox()
        Me.cboxHeight = New System.Windows.Forms.ComboBox()
        Me.cboxRollCoverage = New System.Windows.Forms.ComboBox()
        Me.LblLength = New System.Windows.Forms.Label()
        Me.LblWidth = New System.Windows.Forms.Label()
        Me.LblHeight = New System.Windows.Forms.Label()
        Me.LblRollCoverage = New System.Windows.Forms.Label()
        Me.tboxSingleRoll = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboxLength
        '
        Me.cboxLength.FormattingEnabled = True
        Me.cboxLength.Location = New System.Drawing.Point(297, 93)
        Me.cboxLength.Name = "cboxLength"
        Me.cboxLength.Size = New System.Drawing.Size(207, 40)
        Me.cboxLength.TabIndex = 0
        '
        'cboxWidth
        '
        Me.cboxWidth.FormattingEnabled = True
        Me.cboxWidth.Location = New System.Drawing.Point(297, 168)
        Me.cboxWidth.Name = "cboxWidth"
        Me.cboxWidth.Size = New System.Drawing.Size(207, 40)
        Me.cboxWidth.TabIndex = 1
        '
        'cboxHeight
        '
        Me.cboxHeight.FormattingEnabled = True
        Me.cboxHeight.Location = New System.Drawing.Point(297, 246)
        Me.cboxHeight.Name = "cboxHeight"
        Me.cboxHeight.Size = New System.Drawing.Size(207, 40)
        Me.cboxHeight.TabIndex = 2
        '
        'cboxRollCoverage
        '
        Me.cboxRollCoverage.FormattingEnabled = True
        Me.cboxRollCoverage.Location = New System.Drawing.Point(297, 327)
        Me.cboxRollCoverage.Name = "cboxRollCoverage"
        Me.cboxRollCoverage.Size = New System.Drawing.Size(207, 40)
        Me.cboxRollCoverage.TabIndex = 3
        '
        'LblLength
        '
        Me.LblLength.AutoSize = True
        Me.LblLength.Location = New System.Drawing.Point(41, 93)
        Me.LblLength.Name = "LblLength"
        Me.LblLength.Size = New System.Drawing.Size(151, 32)
        Me.LblLength.TabIndex = 4
        Me.LblLength.Text = "Length (feet)"
        '
        'LblWidth
        '
        Me.LblWidth.AutoSize = True
        Me.LblWidth.Location = New System.Drawing.Point(41, 168)
        Me.LblWidth.Name = "LblWidth"
        Me.LblWidth.Size = New System.Drawing.Size(141, 32)
        Me.LblWidth.TabIndex = 5
        Me.LblWidth.Text = "Width (feet)"
        '
        'LblHeight
        '
        Me.LblHeight.AutoSize = True
        Me.LblHeight.Location = New System.Drawing.Point(41, 246)
        Me.LblHeight.Name = "LblHeight"
        Me.LblHeight.Size = New System.Drawing.Size(149, 32)
        Me.LblHeight.TabIndex = 6
        Me.LblHeight.Text = "Height (feet)"
        '
        'LblRollCoverage
        '
        Me.LblRollCoverage.AutoSize = True
        Me.LblRollCoverage.Location = New System.Drawing.Point(41, 330)
        Me.LblRollCoverage.Name = "LblRollCoverage"
        Me.LblRollCoverage.Size = New System.Drawing.Size(237, 32)
        Me.LblRollCoverage.TabIndex = 7
        Me.LblRollCoverage.Text = "Roll Coverage (SqrFt)"
        '
        'tboxSingleRoll
        '
        Me.tboxSingleRoll.Location = New System.Drawing.Point(604, 191)
        Me.tboxSingleRoll.Name = "tboxSingleRoll"
        Me.tboxSingleRoll.Size = New System.Drawing.Size(318, 39)
        Me.tboxSingleRoll.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(604, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 32)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Single roll:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(604, 245)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(150, 46)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(772, 245)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 46)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 403)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tboxSingleRoll)
        Me.Controls.Add(Me.LblRollCoverage)
        Me.Controls.Add(Me.LblHeight)
        Me.Controls.Add(Me.LblWidth)
        Me.Controls.Add(Me.LblLength)
        Me.Controls.Add(Me.cboxRollCoverage)
        Me.Controls.Add(Me.cboxHeight)
        Me.Controls.Add(Me.cboxWidth)
        Me.Controls.Add(Me.cboxLength)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboxLength As ComboBox
    Friend WithEvents cboxWidth As ComboBox
    Friend WithEvents cboxHeight As ComboBox
    Friend WithEvents cboxRollCoverage As ComboBox
    Friend WithEvents LblLength As Label
    Friend WithEvents LblWidth As Label
    Friend WithEvents LblHeight As Label
    Friend WithEvents LblRollCoverage As Label
    Friend WithEvents tboxSingleRoll As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
End Class
