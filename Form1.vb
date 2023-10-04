Public Class Form1

    Dim int_input_count As Integer
    Dim str_input_count As String
    Dim bool_inputCountCheck As Boolean

    Dim intArr_Numbers() As Integer
    Dim strArr_Numbers As String
    Dim bool_arrNumbersCheck As Boolean

    Private Sub btn_input_count_Click(sender As Object, e As EventArgs) Handles btn_input_count.Click

        Do Until bool_inputCountCheck = True
            str_input_count = InputBox("Please Enter how many inputs you want to enter in the array")

            If IsNumeric(str_input_count) Then
                int_input_count = str_input_count

                If int_input_count > 0 Then
                    bool_inputCountCheck = True
                    MessageBox.Show("You entered " & int_input_count)
                    btn_input_count.Enabled = False    'automaticall disabled the textbox after you entered a number
                Else
                    MessageBox.Show("Please Enter a Valid input!")
                    bool_inputCountCheck = False
                End If

            ElseIf Not IsNumeric(str_input_count) Then
                MessageBox.Show("Please Enter a Valid input!")
                bool_inputCountCheck = False
            End If

        Loop

    End Sub

    Private Sub btn_inputs_arr_Click(sender As Object, e As EventArgs) Handles btn_inputs_arr.Click

        If bool_inputCountCheck = False Then
            MessageBox.Show("Please Enter how many inputs you want to make.")
        Else
            ReDim intArr_Numbers(int_input_count)

            For i = 0 To int_input_count - 1
                bool_arrNumbersCheck = False

                Do Until bool_arrNumbersCheck = True
                    strArr_Numbers = InputBox("Please Enter Number " & i + 1 & " :")

                    If IsNumeric(strArr_Numbers) Then
                        intArr_Numbers(i) = strArr_Numbers
                        bool_arrNumbersCheck = True
                    Else
                        MessageBox.Show("Please Enter a NUMBER.")
                    End If

                Loop

            Next i

            For j = 0 To int_input_count - 1
                MessageBox.Show("array [ " & j & " ]: " & intArr_Numbers(j))
            Next j

        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim int_sum As Integer

        If bool_inputCountCheck = True And bool_arrNumbersCheck = True Then

            For i = 0 To int_input_count - 1
                int_sum += intArr_Numbers(i)
            Next i
            MessageBox.Show("Sum: " & int_sum)
        Else
            MessageBox.Show("Please Add a number to the Array.")
        End If

    End Sub

    Private Sub btn_getLowest_Click(sender As Object, e As EventArgs) Handles btn_getLowest.Click

        Dim int_lowest As Integer

        If bool_inputCountCheck = True And bool_arrNumbersCheck = True Then

            int_lowest = intArr_Numbers(0)
            For i = 1 To int_input_count - 1 Step 1
                If int_lowest > intArr_Numbers(i) Then
                    int_lowest = intArr_Numbers(i)
                End If
            Next

            MessageBox.Show("Lowest Number: " & int_lowest)

        Else
            MessageBox.Show("Please Add a number to the Array.")
        End If
    End Sub

    Private Sub btn_hightest_Click(sender As Object, e As EventArgs) Handles btn_hightest.Click

        Dim int_highest As Integer

        If bool_inputCountCheck = True And bool_arrNumbersCheck = True Then

            int_highest = intArr_Numbers(0)

            For a = 1 To int_input_count - 1 Step 1
                If int_highest < intArr_Numbers(a) Then
                    int_highest = intArr_Numbers(a)
                End If
            Next
            MessageBox.Show("Highest Number: " & int_highest)
        Else
            MessageBox.Show("Please Add a number to the Array.")
        End If

    End Sub

End Class
