Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rlhValueRange = Enumerable.Range(10, 36 - 10).Select(Function(s) s.ToString()).ToArray()
        cboxLength.Items.AddRange(rlhValueRange)
        cboxHeight.Items.AddRange(rlhValueRange)
        cboxWidth.Items.AddRange(rlhValueRange)

        For num As Double = 40 To 50 Step 0.5
            cboxRollCoverage.Items.Add(num.ToString())
        Next
    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrEmpty(cboxLength.SelectedItem) Then
            Return False
        ElseIf String.IsNullOrEmpty(cboxWidth.SelectedItem) Then
            Return False
        ElseIf String.IsNullOrEmpty(cboxHeight.SelectedItem) Then
            Return False
        ElseIf String.IsNullOrEmpty(cboxRollCoverage.SelectedItem) Then
            Return False
        End If
        Return True
    End Function

    Private Function CalculateSingleRoll() As Integer
        If (ValidateInput()) Then
            Dim length = Integer.Parse(cboxLength.SelectedItem)
            Dim height = Integer.Parse(cboxHeight.SelectedItem)
            Dim width = Integer.Parse(cboxWidth.SelectedItem)
            Dim rollCoverage = Double.Parse(cboxRollCoverage.SelectedItem)

            Return Math.Ceiling((((length * height) * 2) + ((width * height) * 2)) / rollCoverage)
        End If
        Return 0
    End Function

    Private Sub UpdateSingleRoll()
        tboxSingleRoll.Text = CalculateSingleRoll()
    End Sub

    Private Sub ClearSingleRoll()
        tboxSingleRoll.Text = ""
    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        UpdateSingleRoll()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub CboxLength_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxLength.SelectedIndexChanged
        ClearSingleRoll()
    End Sub

    Private Sub CboxWidth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxWidth.SelectedIndexChanged
        ClearSingleRoll()
    End Sub

    Private Sub CboxHeight_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxHeight.SelectedIndexChanged
        ClearSingleRoll()
    End Sub

    Private Sub CboxRollCoverage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxRollCoverage.SelectedIndexChanged
        ClearSingleRoll()
    End Sub
End Class
