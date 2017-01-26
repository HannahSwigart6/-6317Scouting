
Public Class Form1

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        Dim dblUpperAutoPts As Double
        Dim dblLowerAutoPts As Double
        Dim blnInputOk = True
        Dim dblResult As Double

        Const intBreakB As Integer = 5
        Const intRotor As Integer = 60



        'Converting strings to integers(Autonomous)
        dblUpperAutoPts = CDbl(UpperAutoPts.Text)
        dblLowerAutoPts = CDbl(LowerAutoPts.Text)

        dblResult = dblUpperAutoPts + (dblLowerAutoPts / 3)

        lblResult.Text = CStr(lblResult.Text)


        If BreakB.Checked = True Then
            dblResult = dblUpperAutoPts + (dblLowerAutoPts / 3)
            lblResult.Text = CStr(dblResult)
        End If

        If Rotor.Checked = True Then
            dblResult = dblUpperAutoPts + (dblLowerAutoPts / 3)
            lblResult.Text = CStr(dblResult)
        End If

        If Rotor.Checked And BreakB.Checked = True Then
            dblResult = dblUpperAutoPts + (dblLowerAutoPts / 3) + intBreakB + intRotor
            lblResult.Text = CStr(dblResult)
        End If
    End Sub
    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim dblUpperTeleopPts As Double
        Dim dblLowerTeleopPts As Double
        Dim dblTotal As Double
        Dim blnInputOk = True

        Const intRope As Integer = 50
        Const intRotor40 As Integer = 40
        Const intRotor80 As Integer = 80
        Const intRotor120 As Integer = 120
        Const intRotor160 As Integer = 160

        'Converting strings to integers(Teleop)
        dblUpperTeleopPts = CDbl(UpperTeleopPts.Text)
        dblLowerTeleopPts = CDbl(LowerTeleopPts.Text)

        lblTotal.Text = CStr(lblTotal.Text)

        dblTotal = (dblUpperTeleopPts / 3) + (dblLowerTeleopPts / 9)

        'If check boxes are checked.
        If Rope.Checked = True Then
            dblTotal = (dblUpperTeleopPts / 3) + (dblLowerTeleopPts / 9) + intRope
            lblTotal.Text = CStr(dblTotal)
        End If
        If Rotor40.Checked = True Then
            dblTotal = (dblUpperTeleopPts / 3) + (dblLowerTeleopPts / 9) + intRotor40
            lblTotal.Text = CStr(dblTotal)
        End If

        If Rotor80.Checked = True Then
            dblTotal = dblUpperTeleopPts + (dblLowerTeleopPts / 3) + intRotor80
            lblTotal.Text = CStr(dblTotal)
        End If

        If Rotor120.Checked = True Then
            dblTotal = dblUpperTeleopPts + (dblLowerTeleopPts / 3) + intRotor120
            lblTotal.Text = CStr(dblTotal)
        End If

        If Rotor160.Checked = True Then
            dblTotal = dblUpperTeleopPts + (dblLowerTeleopPts / 3) + intRotor160
            lblTotal.Text = CStr(dblTotal)
        End If

        'If one of the 4 rotor check boxes is checked plus the rope if completed.
        If Rope.Checked And Rotor40.Checked = True Then
            dblTotal = (dblUpperTeleopPts / 3) + (dblLowerTeleopPts / 9) + intRope + intRotor40
            lblTotal.Text = CStr(dblTotal)
        End If
        If Rope.Checked And Rotor80.Checked = True Then
            dblTotal = (dblUpperTeleopPts / 3) + (dblLowerTeleopPts / 9) + intRope + intRotor80
            lblTotal.Text = CStr(dblTotal)
        End If
        If Rope.Checked And Rotor120.Checked = True Then
            dblTotal = (dblUpperTeleopPts / 3) + (dblLowerTeleopPts / 9) + intRope + intRotor120
            lblTotal.Text = CStr(dblTotal)
        End If
        If Rope.Checked And Rotor160.Checked = True Then
            dblTotal = (dblUpperTeleopPts / 3) + (dblLowerTeleopPts / 9) + intRope + intRotor160
            lblTotal.Text = CStr(dblTotal)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Unchecking the CheckBoxes!
        BreakB.Checked = False
        Rotor.Checked = False
        Rope.Checked = False
        Rotor40.Checked = False
        Rotor80.Checked = False
        Rotor120.Checked = False
        Rotor160.Checked = False
        'Clearing the Team Name and Number Text Boxes
        txtTeamName.Text = String.Empty
        txtTeamNum.Text = String.Empty
        txtSpecial.text = String.Empty
        'Clearing the Numeric Up and Down Boxes
        UpperAutoPts.Text = 0
        LowerAutoPts.Text = 0
        UpperTeleopPts.Text = 0
        LowerTeleopPts.Text = 0
        'Clearing The Total Labels
        lblResult.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

' Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
' Const intNum_Friends As Integer = 1
'Dim strFilename, strAutonomous, strTeleOp, strNotes As String
'Dim intCount As Integer
'Dim friendFile As StreamWriter

'strFilename = InputBox("Enter the Filename")
'Try
'   friendFile = File.CreateText(strFilename)

'For intCount = 1 To intNum_Friends
'strAutonomous = InputBox("Enter the total of for Autonomous Points" & intCount.ToString())
'strTeleOp = InputBox("Enter the total for teleOperated.")

'    friendFile.WriteLine(strAutonomous)
'   friendFile.WriteLine(strTeleOp)

'        Next

'            friendFile.Close()

'Catch
'MessageBox.Show("That File can't be created.")
' End Try
'End Sub
'End Class
