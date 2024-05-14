Public Class frmSort
    ' Declare an array to store 7 random numbers
    Dim randomNumbers(6) As Integer



    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        ' Generate 7 random numbers between 1 and 100 (modify min and max as needed)
        For i = 0 To 6
            randomNumbers(i) = CInt(Rnd() * 100) + 1 ' Scale and offset for range 1 to 100 (inclusive)
        Next

        ' Clear ListBox before displaying new data
        ListBox1.Items.Clear()

        ' Display unsorted numbers
        ListBox1.Items.Add("Unsorted:")
        For i = 0 To 6
            ListBox1.Items.Add(randomNumbers(i).ToString())
        Next

        ' Bubble Sort logic
        Dim swapped As Boolean = True ' Flag to track if any swaps occurred

        ' Loop through the array for multiple passes
        Do While swapped
            swapped = False  ' Reset flag for each pass

            ' Compare adjacent elements and swap if needed
            For i = 0 To UBound(randomNumbers) - 1
                If randomNumbers(i) > randomNumbers(i + 1) Then
                    ' Swap elements directly (no function needed)
                    Dim temp As Integer = randomNumbers(i)
                    randomNumbers(i) = randomNumbers(i + 1)
                    randomNumbers(i + 1) = temp
                    swapped = True ' Set flag if a swap happened
                End If
            Next
        Loop

        ' Display sorted numbers
        ListBox1.Items.Add("")
        ListBox1.Items.Add("Sorted:")
        For i = 0 To 6
            ListBox1.Items.Add(randomNumbers(i).ToString())
        Next
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Generate random numbers
        For i = 0 To 6
            randomNumbers(i) = CInt(Rnd() * 100) + 1 ' Scale and offset for range 1 to 100 (inclusive)
        Next

        ' Clear ListBox before displaying new data
        ListBox1.Items.Clear()

        ' Display unsorted numbers
        ListBox1.Items.Add("Unsorted:")
        For i = 0 To 6
            ListBox1.Items.Add(randomNumbers(i).ToString())
        Next

        ' Insertion Sort logic
        For i = 1 To 6 ' Start from the second element (index 1)
            Dim key As Integer = randomNumbers(i)
            Dim j As Integer = i - 1
            While j >= 0 AndAlso randomNumbers(j) > key
                randomNumbers(j + 1) = randomNumbers(j)
                j -= 1
                If j < 0 Then Exit While ' Ensure j doesn't go below 0
            End While
            randomNumbers(j + 1) = key
        Next

        ' Display sorted numbers
        ListBox1.Items.Add("")
        ListBox1.Items.Add("Sorted:")
        For i = 0 To 6
            ListBox1.Items.Add(randomNumbers(i).ToString())
        Next
    End Sub




    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class
