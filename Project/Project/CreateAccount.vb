Imports System.Text.RegularExpressions

Public Class CreateAccount

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Const AdminPassword As String = "AccessA"
        Const StaffPassword As String = "AccessS"
        Dim username As String = ""
        Dim email As String = ""
        Dim validU As Boolean = False
        Dim validEU As Boolean = False
        Dim validEF As Boolean = False
        Dim validPM As Boolean = False
        Dim validPW As Boolean = False

        FileOpen(1, "Accounts.txt", OpenMode.Input)
        While Not EOF(1) 'presence check
            Input(1, "")
            Input(1, username) 'Username
            Input(1, email) 'Email
            Input(1, "")
            Input(1, "")
            If username = txtUsername.Text Then
                lblUsernameTaken.Visible = True
                validU = False
            Else
                lblUsernameTaken.Visible = False
                validU = True
            End If
            If email = txtEmail.Text Then
                lblEmailUsed.Visible = True
                validEU = False
            Else
                lblEmailUsed.Visible = False
                validEU = True
            End If

        End While
        FileClose(1)

        Dim FoundMatch As Boolean
        Try
            FoundMatch = Regex.IsMatch(txtEmail.Text, "\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase)
        Catch ex As ArgumentException
        End Try

        If Not FoundMatch Then
            lblEmailInvalid.Visible = True
            validEF = False
        Else
            lblEmailInvalid.Visible = False
            validEF = True
        End If
        If txtPassword.Text = txtRetypePassword.Text Then
            lblPasswordMatch.Visible = False
            validPM = True
        Else
            lblPasswordMatch.Visible = True
            validPM = False
        End If

        If cboxAccesslvl.SelectedItem = "Staff" Then
            lblAdminAccError.Visible = False
            If txtAccessPW.Text = StaffPassword Then
                lblStaffAccError.Visible = False
                validPW = True
            Else
                lblStaffAccError.Visible = True
                validPW = False
            End If
        ElseIf cboxAccesslvl.SelectedItem = "Admin" Then
            lblStaffAccError.Visible = False
            If txtAccessPW.Text = AdminPassword Then
                lblAdminAccError.Visible = False
                validPW = True
            Else
                lblAdminAccError.Visible = True
                validPW = False
            End If
        End If

        If validU = True And validEU = True And validEF = True And validPM = True And validPW = True Then 'once all parameters are valid the account is created
            FileOpen(1, "Accounts.txt", OpenMode.Append)
            Write(1, txtFullName.Text)
            Write(1, txtUsername.Text)
            Write(1, txtEmail.Text)
            Write(1, txtPassword.Text)
            WriteLine(1, cboxAccesslvl.Text)
            FileClose(1)
            Me.Close()
        Else
            Me.Size = New Size(495, 355)
        End If
    End Sub

End Class