' The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub Grid_Loaded(sender As Object, e As RoutedEventArgs)
        Dim rlhValueRange = Enumerable.Range(10, 36 - 10).Select(Function(s) s.ToString()).ToArray()
        cboxLength.Items.Add(rlhValueRange)
        cboxHeight.Items.Add(rlhValueRange)
        cboxWidth.Items.Add(rlhValueRange)

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
        txtSingleRoll.Text = CalculateSingleRoll()
    End Sub

    Private Sub ClearSingleRoll()
        txtSingleRoll.Text = ""
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As RoutedEventArgs) Handles btnCalculate.Click
        UpdateSingleRoll()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As RoutedEventArgs) Handles btnExit.Click

    End Sub


End Class
