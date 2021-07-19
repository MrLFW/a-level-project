<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccount
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
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblPasswordRetype = New System.Windows.Forms.Label()
        Me.txtRetypePassword = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblCreateAccount = New System.Windows.Forms.Label()
        Me.lblPasswordMatch = New System.Windows.Forms.Label()
        Me.lblUsernameTaken = New System.Windows.Forms.Label()
        Me.lblEmailUsed = New System.Windows.Forms.Label()
        Me.lblEmailInvalid = New System.Windows.Forms.Label()
        Me.lblAccesslvl = New System.Windows.Forms.Label()
        Me.lblAccessPW = New System.Windows.Forms.Label()
        Me.txtAccessPW = New System.Windows.Forms.TextBox()
        Me.lblAdminAccError = New System.Windows.Forms.Label()
        Me.lblStaffAccError = New System.Windows.Forms.Label()
        Me.cboxAccesslvl = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(67, 206)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(79, 18)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(152, 204)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(131, 20)
        Me.txtPassword.TabIndex = 4
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(65, 154)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(81, 18)
        Me.lblUsername.TabIndex = 6
        Me.lblUsername.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(152, 152)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(131, 20)
        Me.txtUsername.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(14, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(213, 24)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "LFW Business Solutions"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(70, 128)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(76, 18)
        Me.lblFullName.TabIndex = 10
        Me.lblFullName.Text = "Full name:"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(152, 126)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(131, 20)
        Me.txtFullName.TabIndex = 1
        '
        'lblPasswordRetype
        '
        Me.lblPasswordRetype.AutoSize = True
        Me.lblPasswordRetype.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordRetype.Location = New System.Drawing.Point(17, 232)
        Me.lblPasswordRetype.Name = "lblPasswordRetype"
        Me.lblPasswordRetype.Size = New System.Drawing.Size(129, 18)
        Me.lblPasswordRetype.TabIndex = 12
        Me.lblPasswordRetype.Text = "Retype Password:"
        '
        'txtRetypePassword
        '
        Me.txtRetypePassword.Location = New System.Drawing.Point(152, 230)
        Me.txtRetypePassword.Name = "txtRetypePassword"
        Me.txtRetypePassword.Size = New System.Drawing.Size(131, 20)
        Me.txtRetypePassword.TabIndex = 5
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.Location = New System.Drawing.Point(207, 306)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 7
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(126, 306)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(9, 180)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(137, 18)
        Me.lblEmail.TabIndex = 16
        Me.lblEmail.Text = "Organisation Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(152, 178)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(131, 20)
        Me.txtEmail.TabIndex = 3
        '
        'lblCreateAccount
        '
        Me.lblCreateAccount.AutoSize = True
        Me.lblCreateAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateAccount.Location = New System.Drawing.Point(26, 45)
        Me.lblCreateAccount.Name = "lblCreateAccount"
        Me.lblCreateAccount.Size = New System.Drawing.Size(118, 20)
        Me.lblCreateAccount.TabIndex = 17
        Me.lblCreateAccount.Text = "Create account"
        '
        'lblPasswordMatch
        '
        Me.lblPasswordMatch.AutoSize = True
        Me.lblPasswordMatch.ForeColor = System.Drawing.Color.DarkRed
        Me.lblPasswordMatch.Location = New System.Drawing.Point(307, 60)
        Me.lblPasswordMatch.Name = "lblPasswordMatch"
        Me.lblPasswordMatch.Size = New System.Drawing.Size(123, 13)
        Me.lblPasswordMatch.TabIndex = 18
        Me.lblPasswordMatch.Text = "Passwords do not match"
        Me.lblPasswordMatch.Visible = False
        '
        'lblUsernameTaken
        '
        Me.lblUsernameTaken.AutoSize = True
        Me.lblUsernameTaken.ForeColor = System.Drawing.Color.DarkRed
        Me.lblUsernameTaken.Location = New System.Drawing.Point(307, 80)
        Me.lblUsernameTaken.Name = "lblUsernameTaken"
        Me.lblUsernameTaken.Size = New System.Drawing.Size(153, 13)
        Me.lblUsernameTaken.TabIndex = 19
        Me.lblUsernameTaken.Text = "This username is already taken"
        Me.lblUsernameTaken.Visible = False
        '
        'lblEmailUsed
        '
        Me.lblEmailUsed.AutoSize = True
        Me.lblEmailUsed.ForeColor = System.Drawing.Color.DarkRed
        Me.lblEmailUsed.Location = New System.Drawing.Point(307, 100)
        Me.lblEmailUsed.Name = "lblEmailUsed"
        Me.lblEmailUsed.Size = New System.Drawing.Size(132, 13)
        Me.lblEmailUsed.TabIndex = 20
        Me.lblEmailUsed.Text = "This email is already in use"
        Me.lblEmailUsed.Visible = False
        '
        'lblEmailInvalid
        '
        Me.lblEmailInvalid.AutoSize = True
        Me.lblEmailInvalid.ForeColor = System.Drawing.Color.DarkRed
        Me.lblEmailInvalid.Location = New System.Drawing.Point(307, 120)
        Me.lblEmailInvalid.Name = "lblEmailInvalid"
        Me.lblEmailInvalid.Size = New System.Drawing.Size(97, 13)
        Me.lblEmailInvalid.TabIndex = 21
        Me.lblEmailInvalid.Text = "This email is invalid"
        Me.lblEmailInvalid.Visible = False
        '
        'lblAccesslvl
        '
        Me.lblAccesslvl.AutoSize = True
        Me.lblAccesslvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccesslvl.Location = New System.Drawing.Point(47, 259)
        Me.lblAccesslvl.Name = "lblAccesslvl"
        Me.lblAccesslvl.Size = New System.Drawing.Size(99, 18)
        Me.lblAccesslvl.TabIndex = 23
        Me.lblAccesslvl.Text = "Access Level:"
        '
        'lblAccessPW
        '
        Me.lblAccessPW.AutoSize = True
        Me.lblAccessPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccessPW.Location = New System.Drawing.Point(14, 79)
        Me.lblAccessPW.Name = "lblAccessPW"
        Me.lblAccessPW.Size = New System.Drawing.Size(132, 18)
        Me.lblAccessPW.TabIndex = 26
        Me.lblAccessPW.Text = "Access Password:"
        '
        'txtAccessPW
        '
        Me.txtAccessPW.Location = New System.Drawing.Point(151, 77)
        Me.txtAccessPW.Name = "txtAccessPW"
        Me.txtAccessPW.Size = New System.Drawing.Size(131, 20)
        Me.txtAccessPW.TabIndex = 25
        '
        'lblAdminAccError
        '
        Me.lblAdminAccError.ForeColor = System.Drawing.Color.DarkRed
        Me.lblAdminAccError.Location = New System.Drawing.Point(307, 140)
        Me.lblAdminAccError.Name = "lblAdminAccError"
        Me.lblAdminAccError.Size = New System.Drawing.Size(153, 29)
        Me.lblAdminAccError.TabIndex = 27
        Me.lblAdminAccError.Text = "You do not have permission to create an admin account"
        Me.lblAdminAccError.Visible = False
        '
        'lblStaffAccError
        '
        Me.lblStaffAccError.ForeColor = System.Drawing.Color.DarkRed
        Me.lblStaffAccError.Location = New System.Drawing.Point(307, 173)
        Me.lblStaffAccError.Name = "lblStaffAccError"
        Me.lblStaffAccError.Size = New System.Drawing.Size(153, 29)
        Me.lblStaffAccError.TabIndex = 28
        Me.lblStaffAccError.Text = "You do not have permission to create a staff account"
        Me.lblStaffAccError.Visible = False
        '
        'cboxAccesslvl
        '
        Me.cboxAccesslvl.FormattingEnabled = True
        Me.cboxAccesslvl.Items.AddRange(New Object() {"Admin", "Staff"})
        Me.cboxAccesslvl.Location = New System.Drawing.Point(152, 256)
        Me.cboxAccesslvl.Name = "cboxAccesslvl"
        Me.cboxAccesslvl.Size = New System.Drawing.Size(131, 21)
        Me.cboxAccesslvl.TabIndex = 29
        '
        'CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 341)
        Me.Controls.Add(Me.cboxAccesslvl)
        Me.Controls.Add(Me.lblStaffAccError)
        Me.Controls.Add(Me.lblAdminAccError)
        Me.Controls.Add(Me.lblAccessPW)
        Me.Controls.Add(Me.txtAccessPW)
        Me.Controls.Add(Me.lblAccesslvl)
        Me.Controls.Add(Me.lblEmailInvalid)
        Me.Controls.Add(Me.lblEmailUsed)
        Me.Controls.Add(Me.lblUsernameTaken)
        Me.Controls.Add(Me.lblPasswordMatch)
        Me.Controls.Add(Me.lblCreateAccount)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.lblPasswordRetype)
        Me.Controls.Add(Me.txtRetypePassword)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtUsername)
        Me.Name = "CreateAccount"
        Me.Text = "CreateAccount"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents lblPasswordRetype As System.Windows.Forms.Label
    Friend WithEvents txtRetypePassword As System.Windows.Forms.TextBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblCreateAccount As System.Windows.Forms.Label
    Friend WithEvents lblPasswordMatch As System.Windows.Forms.Label
    Friend WithEvents lblUsernameTaken As System.Windows.Forms.Label
    Friend WithEvents lblEmailUsed As System.Windows.Forms.Label
    Friend WithEvents lblEmailInvalid As Label
    Friend WithEvents lblAccesslvl As Label
    Friend WithEvents lblAccessPW As Label
    Friend WithEvents txtAccessPW As TextBox
    Friend WithEvents lblAdminAccError As System.Windows.Forms.Label
    Friend WithEvents lblStaffAccError As System.Windows.Forms.Label
    Friend WithEvents cboxAccesslvl As System.Windows.Forms.ComboBox
End Class
