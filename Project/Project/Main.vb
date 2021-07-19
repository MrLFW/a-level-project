Imports System.Text.RegularExpressions
Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = username
        If accessLevel = "Staff" Then
            tctrlMain.TabPages.Remove(tabSales)
        End If
        LoadTablePeople()
        LoadTableOrders()
        LoadTableItems()
        FillTableStock()
        LoadSalesPanel()
        LoadChart()
        LoadTableOrders2() 'this is where all the tables are called
    End Sub
    Private Sub btnNewContact_Click(sender As Object, e As EventArgs) Handles btnNewContact.Click

        LoadNewContactForm()

    End Sub
    Sub LoadNewContactForm()
        Dim NewContact As New Form

        Dim lblCustomerName = New Label()
        Dim txtCustomerName = New TextBox()
        Dim lblEmail = New Label()
        Dim txtEmail = New TextBox()
        Dim lblPhoneNumber = New Label()
        Dim txtPhoneNumber = New TextBox()
        Dim lblNotes = New Label()
        Dim txtNotes = New TextBox()
        Dim lblDateCreated = New Label()
        Dim txtDateCreated = New TextBox()
        Dim lblAssociatedCompany = New Label()
        Dim txtAssociatedCompany = New TextBox()
        Dim btnSubmit = New Button()
        Dim btnClose = New Button()
        Dim lblNewContactTitle = New Label()

        NewContact.SuspendLayout()

        lblCustomerName.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        lblCustomerName.AutoSize = True
        lblCustomerName.Location = New Point(59, 77)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(82, 13)
        lblCustomerName.TabIndex = 30
        lblCustomerName.Text = "Customer Name"

        txtCustomerName.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        txtCustomerName.Location = New Point(147, 74)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(225, 20)
        txtCustomerName.TabIndex = 1

        lblEmail.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(109, 103)
        lblEmail.Name = "labelEmail"
        lblEmail.Size = New Size(32, 13)
        lblEmail.Text = "Email"

        txtEmail.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        txtEmail.Location = New Point(147, 100)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(225, 20)
        txtEmail.TabIndex = 2

        lblPhoneNumber.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Location = New Point(63, 129)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(78, 13)
        lblPhoneNumber.TabIndex = 31
        lblPhoneNumber.Text = "Phone Number"

        txtPhoneNumber.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        txtPhoneNumber.Location = New Point(147, 126)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(225, 20)
        txtPhoneNumber.TabIndex = 3

        lblAssociatedCompany.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        lblAssociatedCompany.AutoSize = True
        lblAssociatedCompany.Location = New Point(35, 155)
        lblAssociatedCompany.Name = "lblAssociatedCompany"
        lblAssociatedCompany.Size = New Size(106, 13)
        lblAssociatedCompany.TabIndex = 36
        lblAssociatedCompany.Text = "Associated Company"

        txtAssociatedCompany.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        txtAssociatedCompany.Location = New Point(147, 152)
        txtAssociatedCompany.Name = "txtAssociatedCompany"
        txtAssociatedCompany.Size = New Size(225, 20)
        txtAssociatedCompany.TabIndex = 4

        txtDateCreated.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        txtDateCreated.Location = New Point(147, 178)
        txtDateCreated.Name = "txtDateCreated"
        txtDateCreated.Size = New Size(225, 20)
        txtDateCreated.TabIndex = 5
        txtDateCreated.Text = CStr(Date.Today)

        lblDateCreated.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        lblDateCreated.AutoSize = True
        lblDateCreated.Location = New Point(71, 181)
        lblDateCreated.Name = "lblDateCreated"
        lblDateCreated.Size = New Size(70, 13)
        lblDateCreated.TabIndex = 37
        lblDateCreated.Text = "Date Created"

        lblNotes.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        lblNotes.AutoSize = True
        lblNotes.Location = New Point(106, 207)
        lblNotes.Name = "lblNotes"
        lblNotes.Size = New Size(35, 13)
        lblNotes.TabIndex = 29
        lblNotes.Text = "Notes"

        txtNotes.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        txtNotes.Location = New Point(147, 204)
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(225, 20)
        txtNotes.TabIndex = 6

        btnSubmit.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        btnSubmit.Location = New Point(297, 241)
        btnSubmit.Name = "buttonSubmit"
        btnSubmit.Size = New Size(75, 23)
        btnSubmit.TabIndex = 8
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True

        btnClose.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        btnClose.Location = New Point(216, 241)
        btnClose.Name = "buttonClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 7
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True

        lblNewContactTitle.AutoSize = True
        lblNewContactTitle.Font = New Font("Microsoft Sans Serif", 24.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        lblNewContactTitle.Location = New Point(12, 9)
        lblNewContactTitle.Name = "lblNewCompanyTitle"
        lblNewContactTitle.Size = New Size(201, 37)
        lblNewContactTitle.Text = "New Contact"

        NewContact.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        NewContact.AutoScaleMode = AutoScaleMode.Font
        NewContact.ClientSize = New Size(387, 276)

        NewContact.Controls.Add(lblCustomerName)
        NewContact.Controls.Add(txtCustomerName)
        NewContact.Controls.Add(lblEmail)
        NewContact.Controls.Add(txtEmail)
        NewContact.Controls.Add(lblPhoneNumber)
        NewContact.Controls.Add(txtPhoneNumber)
        NewContact.Controls.Add(lblAssociatedCompany)
        NewContact.Controls.Add(txtAssociatedCompany)
        NewContact.Controls.Add(lblDateCreated)
        NewContact.Controls.Add(txtDateCreated)
        NewContact.Controls.Add(txtNotes)
        NewContact.Controls.Add(lblNotes)
        NewContact.Controls.Add(btnSubmit)
        NewContact.Controls.Add(btnClose)
        NewContact.Controls.Add(lblNewContactTitle)
        NewContact.Name = "NewContact"
        NewContact.Text = "New Contact"
        NewContact.ResumeLayout(False)
        NewContact.PerformLayout() 'this sub creates a form for adding a new contact when the customer presses the new contact button

        NewContact.Show()

        AddHandler btnSubmit.Click, Sub(sender, e) btnSubmitNewContact_Click(txtCustomerName, txtEmail, txtPhoneNumber, txtAssociatedCompany, txtDateCreated, txtNotes, NewContact)
        AddHandler btnClose.Click, Sub(sender, e) btnCloseNewContact_Click(NewContact)

    End Sub
    Public Sub btnCloseNewContact_Click(ByVal NewContact As Form)
        NewContact.Close()
    End Sub
    Public Sub btnSubmitNewContact_Click(ByVal txtCustomerName As TextBox, ByVal txtEmail As TextBox, ByVal txtPhoneNumber As TextBox, ByVal txtAssociatedCompany As TextBox, ByVal txtDateCreated As TextBox, ByVal txtNotes As TextBox, ByVal NewContact As Form)

        Dim validEmail As Boolean = False
        validEmail = Regex.IsMatch(txtEmail.Text, "\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase)
        Dim validPhone As Boolean = False
        If txtPhoneNumber.Text.Length > 8 Then
            validPhone = True
        End If

        If validEmail = True And validPhone = True Then 'this checks if the email and phone number are valid and if they are the contact is added
            Dim customerIDint, tempInt, tempBig As Integer
            Dim customerIDstr, tempStr As String
            tempStr = ""
            tempInt = 0
            tempBig = 0
            FileOpen(2, "People.txt", OpenMode.Input)
            While Not EOF(2)
                Input(2, "")
                Input(2, "")
                Input(2, "")
                Input(2, "")
                Input(2, "")
                Input(2, tempStr)
                Input(2, "")

                tempInt = tempStr.Substring(1)

                If tempInt >= tempBig Then
                    tempBig = tempInt
                End If
            End While
            customerIDint = tempBig + 1
            FileClose(2)

            customerIDstr = "P" & customerIDint.ToString
            FileOpen(2, "People.txt", OpenMode.Append)
            Write(2, txtCustomerName.Text)
            Write(2, txtEmail.Text)
            Write(2, txtPhoneNumber.Text)
            Write(2, txtAssociatedCompany.Text)
            Write(2, txtDateCreated.Text)
            Write(2, customerIDstr)
            WriteLine(2, txtNotes.Text)
            FileClose(2)

            AppendTablePeople()

            NewContact.Close()
        ElseIf validEmail = False And validPhone = True Then
            MsgBox("Email is invalid")
        ElseIf validPhone = False And validEmail = True Then
            MsgBox("Phone number is invalid")
        Else
            MsgBox("Email and phone number are invalid")
        End If

    End Sub
    Private Sub btnEditContact_Click(sender As Object, e As EventArgs) Handles btnEditContact.Click

        If RowValidPeople() = True Then
            LoadEditContactForm()
        End If

    End Sub
    Sub LoadEditContactForm()
        Dim EditContact As New Form

        Dim lblCustomerName = New Label
        Dim txtCustomerName = New TextBox
        Dim lblEmail = New Label
        Dim txtEmail = New TextBox
        Dim lblPhoneNumber = New Label
        Dim txtPhoneNumber = New TextBox
        Dim lblAssociatedCompany = New Label
        Dim txtAssociatedCompany = New TextBox
        Dim lblDateCreated = New Label
        Dim txtDateCreated = New TextBox
        Dim lblCustomerID = New Label
        Dim txtCustomerID = New TextBox
        Dim lblNotes = New Label
        Dim txtNotes = New TextBox
        Dim btnSubmit = New Button
        Dim btnClose = New Button
        Dim lblEditContactTitle = New Label

        EditContact.SuspendLayout()

        lblCustomerName.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        lblCustomerName.AutoSize = True
        lblCustomerName.Location = New Point(59, 77)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(82, 13)
        lblCustomerName.TabIndex = 30
        lblCustomerName.Text = "Customer Name"

        txtCustomerName.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        txtCustomerName.Location = New Point(147, 74)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(225, 20)
        txtCustomerName.TabIndex = 1
        txtCustomerName.Text = tblPeople.GetControlFromPosition(1, SelectedRowPeopleFunction).Text

        lblEmail.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(109, 103)
        lblEmail.Name = "labelEmail"
        lblEmail.Size = New Size(32, 13)
        lblEmail.Text = "Email"

        txtEmail.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        txtEmail.Location = New Point(147, 100)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(225, 20)
        txtEmail.TabIndex = 2
        txtEmail.Text = tblPeople.GetControlFromPosition(2, SelectedRowPeopleFunction).Text

        lblPhoneNumber.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Location = New Point(63, 129)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(78, 13)
        lblPhoneNumber.TabIndex = 31
        lblPhoneNumber.Text = "Phone Number"

        txtPhoneNumber.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        txtPhoneNumber.Location = New Point(147, 126)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(225, 20)
        txtPhoneNumber.TabIndex = 3
        txtPhoneNumber.Text = tblPeople.GetControlFromPosition(3, SelectedRowPeopleFunction).Text

        lblAssociatedCompany.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        lblAssociatedCompany.AutoSize = True
        lblAssociatedCompany.Location = New Point(35, 155)
        lblAssociatedCompany.Name = "lblAssociatedCompany"
        lblAssociatedCompany.Size = New Size(106, 13)
        lblAssociatedCompany.TabIndex = 36
        lblAssociatedCompany.Text = "Associated Company"

        txtAssociatedCompany.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        txtAssociatedCompany.Location = New Point(147, 152)
        txtAssociatedCompany.Name = "txtAssociatedCompany"
        txtAssociatedCompany.Size = New Size(225, 20)
        txtAssociatedCompany.TabIndex = 4
        txtAssociatedCompany.Text = tblPeople.GetControlFromPosition(4, SelectedRowPeopleFunction).Text

        lblDateCreated.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        lblDateCreated.AutoSize = True
        lblDateCreated.Location = New Point(71, 181)
        lblDateCreated.Name = "lblDateCreated"
        lblDateCreated.Size = New Size(70, 13)
        lblDateCreated.TabIndex = 37
        lblDateCreated.Text = "Date Created"

        txtDateCreated.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        txtDateCreated.Location = New Point(147, 178)
        txtDateCreated.Name = "txtDateCreated"
        txtDateCreated.Size = New Size(225, 20)
        txtDateCreated.TabIndex = 5
        txtDateCreated.Text = tblPeople.GetControlFromPosition(5, SelectedRowPeopleFunction).Text

        lblCustomerID.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        lblCustomerID.AutoSize = True
        lblCustomerID.Location = New Point(76, 207)
        lblCustomerID.Name = "lblCustomerID"
        lblCustomerID.Size = New Size(65, 13)
        lblCustomerID.TabIndex = 29
        lblCustomerID.Text = "Customer ID"

        txtCustomerID.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        txtCustomerID.Location = New Point(147, 204)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.Size = New Size(225, 20)
        txtCustomerID.TabIndex = 53
        txtCustomerID.Text = tblPeople.GetControlFromPosition(6, SelectedRowPeopleFunction).Text

        lblNotes.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        lblNotes.AutoSize = True
        lblNotes.Location = New Point(106, 233)
        lblNotes.Name = "lblNotes"
        lblNotes.Size = New Size(35, 13)
        lblNotes.TabIndex = 29
        lblNotes.Text = "Notes"

        txtNotes.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        txtNotes.Location = New Point(147, 230)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(225, 78)
        txtNotes.TabIndex = 6
        txtNotes.Text = tblPeople.GetControlFromPosition(7, SelectedRowPeopleFunction).Text

        btnSubmit.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        btnSubmit.Location = New Point(297, 314)
        btnSubmit.Name = "buttonSubmit"
        btnSubmit.Size = New Size(75, 23)
        btnSubmit.TabIndex = 8
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True

        btnClose.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
        btnClose.Location = New Point(216, 314)
        btnClose.Name = "buttonClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 7
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True

        lblEditContactTitle.AutoSize = True
        lblEditContactTitle.Font = New Font("Microsoft Sans Serif", 24.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        lblEditContactTitle.Location = New Point(12, 9)
        lblEditContactTitle.Name = "lblEditContactTitle"
        lblEditContactTitle.Size = New Size(201, 37)
        lblEditContactTitle.Text = "Edit Contact"

        EditContact.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        EditContact.AutoScaleMode = AutoScaleMode.Font
        EditContact.ClientSize = New Size(384, 349)

        EditContact.Controls.Add(lblCustomerName)
        EditContact.Controls.Add(txtCustomerName)
        EditContact.Controls.Add(lblEmail)
        EditContact.Controls.Add(txtEmail)
        EditContact.Controls.Add(lblPhoneNumber)
        EditContact.Controls.Add(txtPhoneNumber)
        EditContact.Controls.Add(lblAssociatedCompany)
        EditContact.Controls.Add(txtAssociatedCompany)
        EditContact.Controls.Add(lblDateCreated)
        EditContact.Controls.Add(txtDateCreated)
        EditContact.Controls.Add(lblCustomerID)
        EditContact.Controls.Add(txtCustomerID)
        EditContact.Controls.Add(txtNotes)
        EditContact.Controls.Add(lblNotes)
        EditContact.Controls.Add(btnSubmit)
        EditContact.Controls.Add(btnClose)
        EditContact.Controls.Add(lblEditContactTitle) 'this creates the form when the user wants to edit a contact
        EditContact.Name = "EditContact"
        EditContact.Text = "Edit Contact"
        EditContact.ResumeLayout(False)
        EditContact.PerformLayout()

        EditContact.Show()

        AddHandler btnSubmit.Click, Sub(sender, e) btnSubmitEditC_Click(txtCustomerName, txtEmail, txtPhoneNumber, txtAssociatedCompany, txtDateCreated, txtCustomerID, txtNotes, EditContact)
        AddHandler btnClose.Click, Sub(sender, e) btnCloseEditC_Click(EditContact)

    End Sub
    Public Sub btnCloseEditC_Click(ByVal EditContact As Form)
        EditContact.Close()
    End Sub
    Public Sub btnSubmitEditC_Click(ByVal txtCustomerName As TextBox, ByVal txtEmail As TextBox, ByVal txtPhoneNumber As TextBox, ByVal txtAssociatedCompany As TextBox, ByVal txtDateCreated As TextBox, ByVal txtCustomerID As TextBox, ByVal txtNotes As TextBox, ByVal EditContact As Form)
        tblPeople.GetControlFromPosition(1, SelectedRowPeopleFunction).Text = txtCustomerName.Text
        tblPeople.GetControlFromPosition(2, SelectedRowPeopleFunction).Text = txtEmail.Text
        tblPeople.GetControlFromPosition(3, SelectedRowPeopleFunction).Text = txtPhoneNumber.Text
        tblPeople.GetControlFromPosition(4, SelectedRowPeopleFunction).Text = txtAssociatedCompany.Text
        tblPeople.GetControlFromPosition(5, SelectedRowPeopleFunction).Text = txtDateCreated.Text
        tblPeople.GetControlFromPosition(6, SelectedRowPeopleFunction).Text = txtCustomerID.Text
        tblPeople.GetControlFromPosition(7, SelectedRowPeopleFunction).Text = txtNotes.Text
        IO.File.WriteAllText("People.txt", "")
        FileOpen(1, "People.txt", OpenMode.Append)
        For i = 1 To tblPeople.RowCount - 1
            Write(1, tblPeople.GetControlFromPosition(1, i).Text)
            Write(1, tblPeople.GetControlFromPosition(2, i).Text)
            Write(1, tblPeople.GetControlFromPosition(3, i).Text)
            Write(1, tblPeople.GetControlFromPosition(4, i).Text)
            Write(1, tblPeople.GetControlFromPosition(5, i).Text)
            Write(1, tblPeople.GetControlFromPosition(6, i).Text)
            WriteLine(1, tblPeople.GetControlFromPosition(7, i).Text)
        Next
        FileClose(1)
        EditContact.Close() 'this saves the new edited data to the text file
    End Sub
    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrderContacts.Click
        LoadNewOrderForm()
    End Sub
    Private Sub btnDeleteContact_Click(sender As Object, e As EventArgs) Handles btnDeleteContact.Click
        If RowValidPeople() = True Then
            DeleteRowTablePeople()
        End If
    End Sub
    Private Sub btnShowCustomerOrders_Click(sender As Object, e As EventArgs) Handles btnShowCustomerOrders.Click
        If RowValidPeople() = True Then
            selectedCustomerID = tblPeople.GetControlFromPosition(6, SelectedRowPeopleFunction).Text
            If selectedCustomerID <> lblCustomerID.Text Then
                FillOrdersTable()
            End If
        End If
    End Sub
    Private Sub btnShowItems_Click(sender As Object, e As EventArgs) Handles btnShowItems.Click
        If System.IO.File.Exists(txtSearchOrderID.Text & ".txt") = True Then
            FillTableItems()
        Else
            MsgBox("Order doesn't exist")
        End If
    End Sub
    Private Sub btnAddStock_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click
        AppendTableStock()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        fillPanelStock()
    End Sub
    Private Sub btnSubmitEdit_Click(sender As Object, e As EventArgs) Handles btnSubmitEdit.Click
        EditStock()
    End Sub
    Private Sub btnDeleteStock_Click(sender As Object, e As EventArgs) Handles btnDeleteStock.Click
        DeleteStock()
    End Sub
    Private Sub btnCreateInvoice_Click(sender As Object, e As EventArgs) Handles btnCreateInvoice.Click
        If System.IO.File.Exists(txtSearchOrderID2.Text & ".txt") = True Then
            'CreateInvoice()
        Else
            MsgBox("Order doesn't exist")
        End If
    End Sub

    Private Sub btnPickingList_Click(sender As Object, e As EventArgs) Handles btnPickingList.Click
        If System.IO.File.Exists(txtSearchOrderID2.Text & ".txt") = True Then
            CreatePickingList()
        Else
            MsgBox("Order doesn't exist")
        End If
    End Sub
    Private Sub SalesTabSelected(sender As Object, e As EventArgs) Handles tabSales.Click
        LoadSalesPanel()
        LoadChart()
    End Sub
End Class