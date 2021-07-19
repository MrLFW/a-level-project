Imports System.IO
Imports System.IO.File
Imports System.Linq
Module CompaniesPanel
    Dim companyName, owner, phoneNumber, location, dateCreated, companyID, notes As String
    Sub LoadTableCompanies()

        Dim lblCompanyName As New Label()
        Dim lblOwnerP As New Label()
        Dim lblPhoneNumberP As New Label()
        Dim lblLocation As New Label()
        Dim lblDateCreatedP As New Label()
        Dim lblCompanyID As New Label()
        Dim lblNotesP As New Label()

        lblCompanyName.AutoSize = True
        lblCompanyName.Name = "lblCompanyName"
        lblCompanyName.Size = New Size(82, 20)
        lblCompanyName.Text = "Company Name"
        lblCompanyName.Font = New Font("Microsoft Sans Serif", 10)

        lblOwnerP.AutoSize = True
        lblOwnerP.Name = "lblOwnerP"
        lblOwnerP.Size = New Size(32, 20)
        lblOwnerP.Text = "Owner"
        lblOwnerP.Font = New Font("Microsoft Sans Serif", 10)

        lblPhoneNumberP.AutoSize = True
        lblPhoneNumberP.Name = "lblPhoneNumberP"
        lblPhoneNumberP.Size = New Size(78, 20)
        lblPhoneNumberP.Text = "Phone Number"
        lblPhoneNumberP.Font = New Font("Microsoft Sans Serif", 10)

        lblLocation.AutoSize = True
        lblLocation.Name = "lblLocation"
        lblLocation.Size = New Size(106, 20)
        lblLocation.Text = "Location"
        lblLocation.Font = New Font("Microsoft Sans Serif", 10)

        lblDateCreatedP.AutoSize = True
        lblDateCreatedP.Name = "lblDateCreatedP"
        lblDateCreatedP.Size = New Size(70, 20)
        lblDateCreatedP.Text = "Date Created"
        lblDateCreatedP.Font = New Font("Microsoft Sans Serif", 10)

        lblCompanyID.AutoSize = True
        lblCompanyID.Name = "lblCompanyID"
        lblCompanyID.Size = New Size(70, 20)
        lblCompanyID.Text = "Company ID"
        lblCompanyID.Font = New Font("Microsoft Sans Serif", 10)

        lblNotesP.AutoSize = True
        lblNotesP.Name = "lblNotesP"
        lblNotesP.Size = New Size(35, 20)
        lblNotesP.Text = "Notes"
        lblNotesP.Font = New Font("Microsoft Sans Serif", 10)

        Main.tblCompanies.Controls.Add(lblCompanyName, 1, 0)
        Main.tblCompanies.Controls.Add(lblOwnerP, 2, 0)
        Main.tblCompanies.Controls.Add(lblPhoneNumberP, 3, 0)
        Main.tblCompanies.Controls.Add(lblLocation, 4, 0)
        Main.tblCompanies.Controls.Add(lblDateCreatedP, 5, 0)
        Main.tblCompanies.Controls.Add(lblCompanyID, 6, 0)
        Main.tblCompanies.Controls.Add(lblNotesP, 7, 0)

        FillTableCompanies()

    End Sub
    Sub FillTableCompanies()

        Main.tblCompanies.RowCount = 1

        FileOpen(1, "Companies.txt", OpenMode.Input)

        companyName = ""
        owner = ""
        phoneNumber = ""
        location = ""
        dateCreated = ""
        notes = ""


        For i As Integer = 0 To linecount - 1

            Dim checkedT As New RadioButton
            Dim companyNameT, ownerT, phoneNumberT, locationT, dateCreatedT, companyIDT, notesT As New Label

            checkedColumnCompanies(i) = checkedT
            companyNameColumn(i) = companyNameT
            ownerColumn(i) = ownerT
            phoneNumberColumn(i) = phoneNumberT
            locationColumn(i) = locationT
            dateCreatedColumn(i) = dateCreatedT
            companyIDColumn(i) = companyIDT
            notesColumn(i) = notesT

            Input(1, companyName)
            Input(1, owner)
            Input(1, phoneNumber)
            Input(1, location)
            Input(1, dateCreated)
            Input(1, companyID)
            Input(1, notes)

            companyNameT.Text = companyName
            ownerT.Text = owner
            phoneNumberT.Text = phoneNumber
            locationT.Text = location
            dateCreatedT.Text = dateCreated
            companyIDT.Text = companyID
            notesT.Text = notes

            checkedT.Name = "checked" & i.ToString
            companyNameT.Name = "companyName" & i.ToString
            ownerT.Name = "owner" & i.ToString
            phoneNumberT.Name = "phoneNumber" & i.ToString
            locationT.Name = "location" & i.ToString
            dateCreatedT.Name = "dateCreated" & i.ToString
            companyIDT.Name = "companyID" & i.ToString
            notesT.Name = "notes" & i.ToString

            checkedT.AutoSize = True
            companyNameT.AutoSize = True
            ownerT.AutoSize = True
            phoneNumberT.AutoSize = True
            locationT.AutoSize = True
            dateCreatedT.AutoSize = True
            notesT.AutoSize = True

            Main.tblCompanies.GrowStyle = TableLayoutPanelGrowStyle.AddRows
            Main.tblCompanies.RowStyles.Add(New RowStyle(SizeType.Absolute, 20))

            Main.tblCompanies.SuspendLayout()

            Main.tblCompanies.RowCount += 1
            Main.tblCompanies.Controls.Add(checkedColumnCompanies(i), 0, Main.tblCompanies.RowCount - 1)
            Main.tblCompanies.Controls.Add(companyNameColumn(i), 1, Main.tblCompanies.RowCount - 1)
            Main.tblCompanies.Controls.Add(ownerColumn(i), 2, Main.tblCompanies.RowCount - 1)
            Main.tblCompanies.Controls.Add(phoneNumberColumn(i), 3, Main.tblCompanies.RowCount - 1)
            Main.tblCompanies.Controls.Add(locationColumn(i), 4, Main.tblCompanies.RowCount - 1)
            Main.tblCompanies.Controls.Add(dateCreatedColumn(i), 5, Main.tblCompanies.RowCount - 1)
            Main.tblCompanies.Controls.Add(companyIDColumn(i), 6, Main.tblCompanies.RowCount - 1)
            Main.tblCompanies.Controls.Add(notesColumn(i), 7, Main.tblCompanies.RowCount - 1)

            Main.tblCompanies.ResumeLayout()

        Next

        FileClose(1)

    End Sub
    Function SelectedRowCompanies() As Integer
        Dim found As Boolean = False
        For i As Integer = 0 To linecount - 1
            If checkedColumnCompanies(i).Checked = True Then
                SelectedRowCompanies = i
                found = True
            End If
        Next
        If found = False Then
            SelectedRowCompanies = -1
        Else
            SelectedRowCompanies += 1 'account for header row
        End If
        Return SelectedRowCompanies
    End Function
    Sub RowValidCompanies()
        If SelectedRowCompanies() = -1 Then
            MsgBox("Please select a row")
        Else
            Main.LoadEditContactForm()
        End If
    End Sub
    Sub EditTableCompanies()

    End Sub
    Sub AppendTableCompanies()

        Dim lineCount As Integer = ReadAllLines("Companies.txt").Length

        FileOpen(1, "Companies.txt", OpenMode.Input)

        companyName = ""
        owner = ""
        phoneNumber = ""
        location = ""
        dateCreated = ""
        notes = ""

        Dim checkedR As New RadioButton
        Dim companyNameT, ownerT, phoneNumberT, locationT, dateCreatedT, companyIDT, notesT As New Label

        While Not EOF(1)
            Input(1, companyName)
            Input(1, owner)
            Input(1, phoneNumber)
            Input(1, location)
            Input(1, dateCreated)
            Input(1, companyID)
            Input(1, notes)
        End While
        companyNameT.Text = companyName
        ownerT.Text = owner
        phoneNumberT.Text = phoneNumber
        locationT.Text = location
        dateCreatedT.Text = dateCreated
        companyIDT.Text = companyID
        notesT.Text = notes

        companyNameT.Name = "companyNameColumn" & lineCount.ToString
        ownerT.Name = "ownerColumn" & lineCount.ToString
        phoneNumberT.Name = "phoneNumberColumn" & lineCount.ToString
        locationT.Name = "locationColumn" & lineCount.ToString
        dateCreatedT.Name = "dateCreatedColumn" & lineCount.ToString
        companyIDT.Name = "companyIDColumn" & lineCount.ToString
        notesT.Name = "notesColumn" & lineCount.ToString

        checkedR.AutoSize = True
        companyNameT.AutoSize = True
        ownerT.AutoSize = True
        phoneNumberT.AutoSize = True
        locationT.AutoSize = True
        dateCreatedT.AutoSize = True
        notesT.AutoSize = True

        Main.tblCompanies.GrowStyle = TableLayoutPanelGrowStyle.AddRows
        Main.tblCompanies.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        Main.tblCompanies.RowCount += 1

        Main.tblCompanies.SuspendLayout()

        Main.tblCompanies.Controls.Add(checkedR, 0, Main.tblCompanies.RowCount - 1)
        Main.tblCompanies.Controls.Add(companyNameT, 1, Main.tblCompanies.RowCount - 1)
        Main.tblCompanies.Controls.Add(ownerT, 2, Main.tblCompanies.RowCount - 1)
        Main.tblCompanies.Controls.Add(phoneNumberT, 3, Main.tblCompanies.RowCount - 1)
        Main.tblCompanies.Controls.Add(locationT, 4, Main.tblCompanies.RowCount - 1)
        Main.tblCompanies.Controls.Add(dateCreatedT, 5, Main.tblCompanies.RowCount - 1)
        Main.tblCompanies.Controls.Add(companyIDT, 6, Main.tblCompanies.RowCount - 1)
        Main.tblCompanies.Controls.Add(notesT, 7, Main.tblCompanies.RowCount - 1)

        Main.tblCompanies.ResumeLayout()

        FileClose(1)

    End Sub
End Module