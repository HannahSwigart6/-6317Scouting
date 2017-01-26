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
        Dim txtSpecialNotes As System.Windows.Forms.TextBox
        Me.UpperAutoPts = New System.Windows.Forms.NumericUpDown()
        Me.LowerAutoPts = New System.Windows.Forms.NumericUpDown()
        Me.LowerTeleopPts = New System.Windows.Forms.NumericUpDown()
        Me.UpperTeleopPts = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BreakB = New System.Windows.Forms.CheckBox()
        Me.Rotor40 = New System.Windows.Forms.CheckBox()
        Me.Rotor = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.btnClear2 = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTeamName = New System.Windows.Forms.TextBox()
        Me.txtTeamNum = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Rotor160 = New System.Windows.Forms.CheckBox()
        Me.Rotor120 = New System.Windows.Forms.CheckBox()
        Me.Rotor80 = New System.Windows.Forms.CheckBox()
        Me.Rope = New System.Windows.Forms.CheckBox()
        txtSpecialNotes = New System.Windows.Forms.TextBox()
        CType(Me.UpperAutoPts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LowerAutoPts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LowerTeleopPts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpperTeleopPts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSpecialNotes
        '
        txtSpecialNotes.Location = New System.Drawing.Point(12, 493)
        txtSpecialNotes.Multiline = True
        txtSpecialNotes.Name = "txtSpecialNotes"
        txtSpecialNotes.Size = New System.Drawing.Size(426, 115)
        txtSpecialNotes.TabIndex = 32
        '
        'UpperAutoPts
        '
        Me.UpperAutoPts.Location = New System.Drawing.Point(202, 102)
        Me.UpperAutoPts.Name = "UpperAutoPts"
        Me.UpperAutoPts.Size = New System.Drawing.Size(120, 20)
        Me.UpperAutoPts.TabIndex = 0
        '
        'LowerAutoPts
        '
        Me.LowerAutoPts.Location = New System.Drawing.Point(202, 150)
        Me.LowerAutoPts.Name = "LowerAutoPts"
        Me.LowerAutoPts.Size = New System.Drawing.Size(120, 20)
        Me.LowerAutoPts.TabIndex = 1
        '
        'LowerTeleopPts
        '
        Me.LowerTeleopPts.Location = New System.Drawing.Point(709, 145)
        Me.LowerTeleopPts.Name = "LowerTeleopPts"
        Me.LowerTeleopPts.Size = New System.Drawing.Size(120, 20)
        Me.LowerTeleopPts.TabIndex = 3
        '
        'UpperTeleopPts
        '
        Me.UpperTeleopPts.Location = New System.Drawing.Point(709, 102)
        Me.UpperTeleopPts.Name = "UpperTeleopPts"
        Me.UpperTeleopPts.Size = New System.Drawing.Size(120, 20)
        Me.UpperTeleopPts.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Scouting Program:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(457, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Lower Goal (9 Fuel = 1 pt)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(457, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Upper Goal (3 Fuel = 1 pt)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "1st Rotor Turning (60 pts)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Break Baseline"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Lower Goal (3 Fuel = 1 pt)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Upper Goal (1 Fuel = 1 pt)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(457, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(215, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Each Rotor Turning (4 Rotors) (40 pts Each)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(460, 255)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Climb the Rope"
        '
        'BreakB
        '
        Me.BreakB.AutoSize = True
        Me.BreakB.Location = New System.Drawing.Point(202, 198)
        Me.BreakB.Name = "BreakB"
        Me.BreakB.Size = New System.Drawing.Size(76, 17)
        Me.BreakB.TabIndex = 14
        Me.BreakB.Text = "Completed"
        Me.BreakB.UseVisualStyleBackColor = True
        '
        'Rotor40
        '
        Me.Rotor40.AutoSize = True
        Me.Rotor40.Location = New System.Drawing.Point(694, 183)
        Me.Rotor40.Name = "Rotor40"
        Me.Rotor40.Size = New System.Drawing.Size(32, 17)
        Me.Rotor40.TabIndex = 15
        Me.Rotor40.Text = "1"
        Me.Rotor40.UseVisualStyleBackColor = True
        '
        'Rotor
        '
        Me.Rotor.AutoSize = True
        Me.Rotor.Location = New System.Drawing.Point(202, 247)
        Me.Rotor.Name = "Rotor"
        Me.Rotor.Size = New System.Drawing.Size(76, 17)
        Me.Rotor.TabIndex = 16
        Me.Rotor.Text = "Completed"
        Me.Rotor.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Firebrick
        Me.Label10.Location = New System.Drawing.Point(13, 443)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(806, 1)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label11.Location = New System.Drawing.Point(466, 306)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 24)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Teleop Total:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label12.Location = New System.Drawing.Point(9, 306)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(169, 24)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Autonomous Total:"
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblResult.Location = New System.Drawing.Point(221, 306)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(142, 34)
        Me.lblResult.TabIndex = 21
        '
        'btnResult
        '
        Me.btnResult.Location = New System.Drawing.Point(49, 378)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(139, 45)
        Me.btnResult.TabIndex = 22
        Me.btnResult.Text = "Total Out!"
        Me.btnResult.UseVisualStyleBackColor = True
        '
        'btnClear2
        '
        Me.btnClear2.Location = New System.Drawing.Point(625, 378)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(139, 45)
        Me.btnClear2.TabIndex = 23
        Me.btnClear2.Text = "Clear!"
        Me.btnClear2.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(470, 378)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(139, 45)
        Me.btnTotal.TabIndex = 24
        Me.btnTotal.Text = "Total Out!"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(205, 378)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(139, 45)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "Clear!"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label16.Location = New System.Drawing.Point(632, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 18)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Team #:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label17.Location = New System.Drawing.Point(235, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 18)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Team Name:"
        '
        'txtTeamName
        '
        Me.txtTeamName.Location = New System.Drawing.Point(335, 14)
        Me.txtTeamName.Name = "txtTeamName"
        Me.txtTeamName.Size = New System.Drawing.Size(274, 20)
        Me.txtTeamName.TabIndex = 29
        '
        'txtTeamNum
        '
        Me.txtTeamNum.Location = New System.Drawing.Point(700, 15)
        Me.txtTeamNum.Name = "txtTeamNum"
        Me.txtTeamNum.Size = New System.Drawing.Size(100, 20)
        Me.txtTeamNum.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label15.Location = New System.Drawing.Point(23, 453)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 24)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Special Notes:"
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(460, 506)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(149, 81)
        Me.btnExcel.TabIndex = 33
        Me.btnExcel.Text = "Export to Excel:"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(650, 506)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(149, 81)
        Me.btnExit.TabIndex = 34
        Me.btnExit.Text = "Exit!!!"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblTotal.Location = New System.Drawing.Point(613, 306)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(142, 34)
        Me.lblTotal.TabIndex = 35
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label18.Location = New System.Drawing.Point(466, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(145, 24)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Teleop Scoring:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label19.Location = New System.Drawing.Point(12, 60)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(193, 24)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "Autonomous Scoring:"
        '
        'Rotor160
        '
        Me.Rotor160.AutoSize = True
        Me.Rotor160.Location = New System.Drawing.Point(787, 215)
        Me.Rotor160.Name = "Rotor160"
        Me.Rotor160.Size = New System.Drawing.Size(32, 17)
        Me.Rotor160.TabIndex = 38
        Me.Rotor160.Text = "4"
        Me.Rotor160.UseVisualStyleBackColor = True
        '
        'Rotor120
        '
        Me.Rotor120.AutoSize = True
        Me.Rotor120.Location = New System.Drawing.Point(787, 185)
        Me.Rotor120.Name = "Rotor120"
        Me.Rotor120.Size = New System.Drawing.Size(32, 17)
        Me.Rotor120.TabIndex = 39
        Me.Rotor120.Text = "3"
        Me.Rotor120.UseVisualStyleBackColor = True
        '
        'Rotor80
        '
        Me.Rotor80.AutoSize = True
        Me.Rotor80.Location = New System.Drawing.Point(694, 215)
        Me.Rotor80.Name = "Rotor80"
        Me.Rotor80.Size = New System.Drawing.Size(32, 17)
        Me.Rotor80.TabIndex = 40
        Me.Rotor80.Text = "2"
        Me.Rotor80.UseVisualStyleBackColor = True
        '
        'Rope
        '
        Me.Rope.AutoSize = True
        Me.Rope.Location = New System.Drawing.Point(709, 255)
        Me.Rope.Name = "Rope"
        Me.Rope.Size = New System.Drawing.Size(76, 17)
        Me.Rope.TabIndex = 41
        Me.Rope.Text = "Completed"
        Me.Rope.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(867, 620)
        Me.Controls.Add(Me.Rope)
        Me.Controls.Add(Me.Rotor80)
        Me.Controls.Add(Me.Rotor120)
        Me.Controls.Add(Me.Rotor160)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(txtSpecialNotes)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTeamNum)
        Me.Controls.Add(Me.txtTeamName)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnClear2)
        Me.Controls.Add(Me.btnResult)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Rotor)
        Me.Controls.Add(Me.Rotor40)
        Me.Controls.Add(Me.BreakB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UpperTeleopPts)
        Me.Controls.Add(Me.LowerTeleopPts)
        Me.Controls.Add(Me.LowerAutoPts)
        Me.Controls.Add(Me.UpperAutoPts)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.UpperAutoPts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LowerAutoPts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LowerTeleopPts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpperTeleopPts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UpperAutoPts As System.Windows.Forms.NumericUpDown
    Friend WithEvents LowerAutoPts As System.Windows.Forms.NumericUpDown
    Friend WithEvents LowerTeleopPts As System.Windows.Forms.NumericUpDown
    Friend WithEvents UpperTeleopPts As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BreakB As System.Windows.Forms.CheckBox
    Friend WithEvents Rotor40 As System.Windows.Forms.CheckBox
    Friend WithEvents Rotor As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnResult As System.Windows.Forms.Button
    Friend WithEvents btnClear2 As System.Windows.Forms.Button
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTeamName As System.Windows.Forms.TextBox
    Friend WithEvents txtTeamNum As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Rotor160 As System.Windows.Forms.CheckBox
    Friend WithEvents Rotor120 As System.Windows.Forms.CheckBox
    Friend WithEvents Rotor80 As System.Windows.Forms.CheckBox
    Friend WithEvents Rope As System.Windows.Forms.CheckBox

End Class
