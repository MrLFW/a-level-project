Imports System.IO.File
Imports System.IO
Module PeopleTable
    Dim customerName, email, phoneNumber, associatedCompany, dateCreated, customerID, notes As String
    Sub LoadTablePeople()

        Dim lblCustomerName As New Label()
        Dim lblEmailP As New Label()
        Dim lblPhoneNumberP As New Label()
        Dim lblAssociatedCompany As New Label()
        Dim lblDateCreatedP As New Label()
        Dim lblCustomerID As New Label()
        Dim lblNotesP As New Label()

        lblCustomerName.AutoSize = True
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(82, 20)
        lblCustomerName.Text = "Customer Name"
        lblCustomerName.Font = New Font("Microsoft Sans Serif", 10)

        lblEmailP.AutoSize = True
        lblEmailP.Name = "lblEmailP"
        lblEmailP.Size = New Size(32, 20)
        lblEmailP.Text = "Email"
        lblEmailP.Font = New Font("Microsoft Sans Serif", 10)

        lblPhoneNumberP.AutoSize = True
        lblPhoneNumberP.Name = "lblPhoneNumberP"
        lblPhoneNumberP.Size = New Size(78, 20)
        lblPhoneNumberP.Text = "Phone Number"
        lblPhoneNumberP.Font = New Font("Microsoft Sans Serif", 10)

        lblAssociatedCompany.AutoSize = True
        lblAssociatedCompany.Name = "lblAssociatedCompany"
        lblAssociatedCompany.Size = New Size(106, 20)
        lblAssociatedCompany.Text = "Associated Company"
        lblAssociatedCompany.Font = New Font("Microsoft Sans Serif", 10)

        lblDateCreatedP.AutoSize = True
        lblDateCreatedP.Name = "lblDateCreatedP"
        lblDateCreatedP.Size = New Size(70, 20)
        lblDateCreatedP.Text = "Date Created"
        lblDateCreatedP.Font = New Font("Microsoft Sans Serif", 10)

        lblCustomerID.AutoSize = True
        lblCustomerID.Name = "lblCustomerID"
        lblCustomerID.Size = New Size(70, 20)
        lblCustomerID.Text = "Customer ID"
        lblCustomerID.Font = New Font("Microsoft Sans Serif", 10)

        lblNotesP.AutoSize = True
        lblNotesP.Name = "lblNotesP"
        lblNotesP.Size = New Size(35, 20)
        lblNotesP.Text = "Notes"
        lblNotesP.Font = New Font("Microsoft Sans Serif", 10)

        Main.tblPeople.Controls.Add(lblCustomerName, 1, 0)
        Main.tblPeople.Controls.Add(lblEmailP, 2, 0)
        Main.tblPeople.Controls.Add(lblPhoneNumberP, 3, 0)
        Main.tblPeople.Controls.Add(lblAssociatedCompany, 4, 0) 'this adds the headers to the table of contacts
        Main.tblPeople.Controls.Add(lblDateCreatedP, 5, 0)
        Main.tblPeople.Controls.Add(lblCustomerID, 6, 0)
        Main.tblPeople.Controls.Add(lblNotesP, 7, 0)

        FillTablePeople()

    End Sub
    Sub FillTablePeople()

        Main.tblPeople.RowCount = 1

        FileOpen(1, "People.txt", OpenMode.Input)

        customerName = ""
        email = ""
        phoneNumber = ""
        associatedCompany = ""
        dateCreated = ""
        notes = ""

        Main.tblPeople.SuspendLayout()
        For i As Integer = 0 To linecountP - 1

            Dim checkedR As New RadioButton
            Dim customerNameL, emailL, phoneNumberL, associatedCompanyL, dateCreatedL, customerIDL, notesL As New Label

            checkedColumnPeople.Add(checkedR)

            pcustomerNameColumn(i) = customerNameL
            pemailColumn(i) = emailL
            pphoneNumberColumn(i) = phoneNumberL
            passociatedCompanyColumn(i) = associatedCompanyL
            pdateCreatedColumn(i) = dateCreatedL
            pcustomerIDColumn(i) = customerIDL
            pnotesColumn(i) = notesL

            Input(1, customerName)
            Input(1, email)
            Input(1, phoneNumber)
            Input(1, associatedCompany)
            Input(1, dateCreated)
            Input(1, customerID)
            Input(1, notes)

            customerNameL.Text = customerName
            emailL.Text = email
            phoneNumberL.Text = phoneNumber
            associatedCompanyL.Text = associatedCompany
            dateCreatedL.Text = dateCreated
            customerIDL.Text = customerID
            notesL.Text = notes

            checkedR.Name = "checked" & i.ToString
            customerNameL.Name = "customerName" & i.ToString
            emailL.Name = "email" & i.ToString
            phoneNumberL.Name = "phoneNumber" & i.ToString
            associatedCompanyL.Name = "associatedCompany" & i.ToString
            dateCreatedL.Name = "dateCreated" & i.ToString
            customerIDL.Name = "customerID" & i.ToString
            notesL.Name = "notes" & i.ToString

            checkedR.AutoSize = True
            customerNameL.AutoSize = True
            emailL.AutoSize = True
            phoneNumberL.AutoSize = True
            associatedCompanyL.AutoSize = True
            dateCreatedL.AutoSize = True
            notesL.AutoSize = True

            Main.tblPeople.GrowStyle = TableLayoutPanelGrowStyle.AddRows
            Main.tblPeople.RowStyles.Add(New RowStyle(SizeType.Absolute, 20))

            Main.tblPeople.RowCount += 1
            Main.tblPeople.Controls.Add(checkedColumnPeople(i), 0, Main.tblPeople.RowCount - 1)
            Main.tblPeople.Controls.Add(pcustomerNameColumn(i), 1, Main.tblPeople.RowCount - 1)
            Main.tblPeople.Controls.Add(pemailColumn(i), 2, Main.tblPeople.RowCount - 1)
            Main.tblPeople.Controls.Add(pphoneNumberColumn(i), 3, Main.tblPeople.RowCount - 1)
            Main.tblPeople.Controls.Add(passociatedCompanyColumn(i), 4, Main.tblPeople.RowCount - 1) 'this fills the table of contacts when the program starts
            Main.tblPeople.Controls.Add(pdateCreatedColumn(i), 5, Main.tblPeople.RowCount - 1)
            Main.tblPeople.Controls.Add(pcustomerIDColumn(i), 6, Main.tblPeople.RowCount - 1)
            Main.tblPeople.Controls.Add(pnotesColumn(i), 7, Main.tblPeople.RowCount - 1)

        Next
        Main.tblPeople.ResumeLayout()

        FileClose(1)

    End Sub
    Function SelectedRowPeopleFunction() As Integer
        Dim found As Boolean = False

        For i = 0 To Main.tblPeople.RowCount - 2
            If checkedColumnPeople(i).Checked = True Then 'this function finds the selected radiobutton
                SelectedRowPeopleFunction = i
                found = True
                Exit For
            End If
        Next
        If found = False Then
            SelectedRowPeopleFunction = -1
        Else
            SelectedRowPeopleFunction += 1 'account for header row
        End If
    End Function
    Function RowValidPeople() As Boolean
        RowValidPeople = False
        If SelectedRowPeopleFunction() = -1 Then 'this checks whether a radio button is selected when edit or delete buttons are pressed
            MsgBox("Please select a row")
        Else
            'MsgBox(SelectedRowPeopleFunction() & " " & checkedColumnPeople.Count)
            RowValidPeople = True
        End If
    End Function
    Sub AppendTablePeople()

        Dim lineCount As Integer = ReadAllLines("People.txt").Length

        FileOpen(1, "People.txt", OpenMode.Input)

        customerName = ""
        email = ""
        phoneNumber = ""
        associatedCompany = ""
        dateCreated = ""
        notes = ""

        Dim checkedR As New RadioButton
        Dim customerNameL, emailL, phoneNumberL, associatedCompanyL, dateCreatedL, customerIDL, notesL As New Label

        checkedColumnPeople.Add(checkedR)

        While Not EOF(1)
            Input(1, customerName)
            Input(1, email)
            Input(1, phoneNumber)
            Input(1, associatedCompany)
            Input(1, dateCreated)
            Input(1, customerID)
            Input(1, notes)
        End While
        FileClose(1)

        customerNameL.Text = customerName
        emailL.Text = email
        phoneNumberL.Text = phoneNumber
        associatedCompanyL.Text = associatedCompany
        dateCreatedL.Text = dateCreated
        customerIDL.Text = customerID
        notesL.Text = notes

        customerNameL.Name = "pcustomerNameColumn" & lineCount.ToString
        emailL.Name = "pemailColumn" & lineCount.ToString
        phoneNumberL.Name = "pphoneNumberColumn" & lineCount.ToString
        associatedCompanyL.Name = "passociatedCompanyColumn" & lineCount.ToString
        dateCreatedL.Name = "pdateCreatedColumn" & lineCount.ToString
        customerIDL.Name = "pcustomerIDColumn" & lineCount.ToString
        notesL.Name = "pnotesColumn" & lineCount.ToString

        checkedR.AutoSize = True
        customerNameL.AutoSize = True
        emailL.AutoSize = True
        phoneNumberL.AutoSize = True
        associatedCompanyL.AutoSize = True
        dateCreatedL.AutoSize = True
        notesL.AutoSize = True

        Main.tblPeople.GrowStyle = TableLayoutPanelGrowStyle.AddRows
        Main.tblPeople.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        Main.tblPeople.RowCount += 1

        Main.tblPeople.SuspendLayout()

        Main.tblPeople.Controls.Add(checkedR, 0, Main.tblPeople.RowCount - 1)
        Main.tblPeople.Controls.Add(customerNameL, 1, Main.tblPeople.RowCount - 1)
        Main.tblPeople.Controls.Add(emailL, 2, Main.tblPeople.RowCount - 1)
        Main.tblPeople.Controls.Add(phoneNumberL, 3, Main.tblPeople.RowCount - 1)
        Main.tblPeople.Controls.Add(associatedCompanyL, 4, Main.tblPeople.RowCount - 1) 'this adds a new contact to the table
        Main.tblPeople.Controls.Add(dateCreatedL, 5, Main.tblPeople.RowCount - 1)
        Main.tblPeople.Controls.Add(customerIDL, 6, Main.tblPeople.RowCount - 1)
        Main.tblPeople.Controls.Add(notesL, 7, Main.tblPeople.RowCount - 1)

        Main.tblPeople.ResumeLayout()


    End Sub
    Sub DeleteRowTablePeople()
        Dim row As Integer
        row = SelectedRowPeopleFunction() - 1
        Main.tblPeople.SuspendLayout()

        Dim delLine As Integer = SelectedRowPeopleFunction()
        Dim lines As List(Of String) = ReadAllLines("People.txt").ToList
        lines.RemoveAt(delLine - 1) ' index starts at 0 
        WriteAllLines("People.txt", lines)

        For i As Integer = 0 To Main.tblPeople.ColumnCount - 1
            Main.tblPeople.Controls.Remove(Main.tblPeople.GetControlFromPosition(i, SelectedRowPeopleFunction))
        Next

        For i As Integer = row + 1 To Main.tblPeople.RowCount - 1

            For j As Integer = 0 To Main.tblPeople.ColumnCount - 1
                Dim control = Main.tblPeople.GetControlFromPosition(j, i)

                If control IsNot Nothing Then
                    Main.tblPeople.SetRow(control, i - 1)
                End If
            Next
        Next

        Dim removeStyle = Main.tblPeople.RowCount - 1
        If Main.tblPeople.RowStyles.Count > removeStyle Then Main.tblPeople.RowStyles.RemoveAt(removeStyle) 'this sub deletes the selected row from the table and resaves the remaining data to a text file
        Main.tblPeople.RowCount -= 1

        checkedColumnPeople.RemoveAt(row)
        For j As Integer = 0 To checkedColumnPeople.Count - 1
            checkedColumnPeople(j).Checked = False
        Next j
        Main.tblPeople.ResumeLayout()

    End Sub

End Module