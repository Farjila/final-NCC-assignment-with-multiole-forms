Imports System.IO
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement



Public Class frmSearch


    ' Initialize the txtSearch variable with a reference to the actual TextBox control in your form
    Dim r As StreamReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Declare variables
        Dim numberList(6) As Integer  ' Array to store 7 numbers (0-based indexing)
        Dim numberToSearch As Integer
        Dim found As Boolean = False

        ' Get user input for each number
        For i As Integer = 0 To 6
            Dim input As String = InputBox("Enter number " & (i + 1).ToString & ":")
            If Not IsNumeric(input) Then
                MsgBox("Invalid input. Please enter a number.", MsgBoxStyle.Exclamation)
                Exit Sub ' Exit if invalid input
            End If
            numberList(i) = Integer.Parse(input)
        Next

        ' Get number to search
        numberToSearch = Integer.Parse(InputBox("Enter number to search:"))

        ' Linear search
        For i As Integer = 0 To 6
            If numberList(i) = numberToSearch Then
                found = True
                Exit For ' Exit if found
            End If
        Next

        ' Display result
        If found Then
            Label1.Text = "Number found!"
        Else
            Label1.Text = "Number not found."
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim found As Boolean = False
        Dim numberList(6) As Integer  ' Array to store 7 numbers (0-based indexing)
        Dim numberToSearch As Integer
        Dim swapped As Boolean = True ' Flag for bubble sort

        ' Get user input for each number
        For i As Integer = 0 To 6
            Dim input As String = InputBox("Enter number " & (i + 1).ToString & ":")
            If Not IsNumeric(input) Then
                MsgBox("Invalid input. Please enter a number.", MsgBoxStyle.Exclamation)
                Exit Sub ' Exit if invalid input
            End If
            numberList(i) = Integer.Parse(input)
        Next

        ' Get number to search
        numberToSearch = Integer.Parse(InputBox("Enter number to search:"))

        ' Bubble sort (avoiding functions)
        Do While swapped
            swapped = False
            For i As Integer = 0 To 5  ' Loop for all elements except the last
                If numberList(i) > numberList(i + 1) Then
                    ' Swap elements
                    Dim temp As Integer = numberList(i)
                    numberList(i) = numberList(i + 1)
                    numberList(i + 1) = temp
                    swapped = True
                End If
            Next
        Loop

        ' Binary search (avoiding functions)
        Dim low As Integer = 0
        Dim high As Integer = 6
        Dim mid As Integer

        Do While low <= high
            mid = (low + high) \ 2 ' Integer division
            If numberList(mid) = numberToSearch Then
                found = True
                Exit Do
            ElseIf numberList(mid) < numberToSearch Then
                low = mid + 1
            Else
                high = mid - 1
            End If
        Loop

        ' Display result
        If found Then
            Label1.Text = "Number found!"
        Else
            Label1.Text = "Number not found."
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        r = New IO.StreamReader("C:\Users\farji\OneDrive\Desktop\ncc\class_lectures\final NCC assignment with multiple forms - external file\Data.txt")
        While (r.Peek > -1)
            ListBox1.Items.Add(r.ReadLine)
        End While
        r.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim searchNumber As Integer = CInt(TextBox1.Text) ' Get the search number from the user
        Dim index As Integer = -1 ' Initialize the index variable to -1

        ' Search for the number in the list box
        For i As Integer = 0 To ListBox1.Items.Count - 1
            If CType(ListBox1.Items(i), Integer) = searchNumber Then
                index = i ' Set the index to the current position
                Exit For
            End If
        Next

        ' Display the result in the label
        If index = -1 Then
            Label1.Text = "Number not found in the list."
        Else
            Label1.Text = $"Number found at index {index}."
        End If
    End Sub
End Class