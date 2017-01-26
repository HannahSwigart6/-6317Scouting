
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

        'Converting strings to integers(Teleop)
        dblUpperTeleopPts = CDbl(UpperTeleopPts.Text)
        dblLowerTeleopPts = CDbl(LowerTeleopPts.Text)

        lblTotal.Text = CStr(lblTotal.Text)

        dblTotal = (dblUpperTeleopPts / 3) + (dblLowerTeleopPts / 9)

        If BreakB.Checked = True Then
            dblTotal = (dblUpperTeleopPts / 3) + (dblLowerTeleopPts / 9) + intRope
            lblTotal.Text = CStr(dblTotal)
        End If
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
