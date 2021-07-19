Public Class LogIn
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        CreateAccount.Show()
    End Sub
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        Dim password, fileUsername, filePassword As String
        Dim valid As Boolean = False
        fileUsername = ""
        filePassword = ""
        username = txtUsername.Text
        password = txtPassword.Text

        FileOpen(1, "Accounts.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, "") 'Full name
            Input(1, fileUsername)
            Input(1, "") 'Email
            Input(1, filePassword)
            Input(1, accessLevel)
            If username = fileUsername And password = filePassword Then 'this checks if the username and password are correct
                valid = True
                Exit While
            Else
                lblPasswordMatch.Visible = True
                valid = False
            End If
        End While
        FileClose(1)
        If valid = True Then
            Main.Show()
            Me.Close()
        End If

    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Form1.Show()
    End Sub
End Class
