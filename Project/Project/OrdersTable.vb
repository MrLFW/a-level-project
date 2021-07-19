Module OrdersTable
    Sub LoadTableOrders()

        Dim lblOrderID As New Label()
        Dim lblCustomerName As New Label()
        Dim lblOrderDate As New Label()
        Dim lblPostCode As New Label()
        Dim lblCountry As New Label()
        Dim lblNotes As New Label()
        Dim lblTotal As New Label()

        lblOrderID.AutoSize = True
        lblOrderID.Name = "lblOrderID"
        lblOrderID.Text = "Order ID"
        lblOrderID.Font = New Font("Microsoft Sans Serif", 10)

        lblCustomerName.AutoSize = True
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Text = "Customer Name"
        lblCustomerName.Font = New Font("Microsoft Sans Serif", 10)

        lblOrderDate.AutoSize = True
        lblOrderDate.Name = "lblOrderDate"
        lblOrderDate.Text = "Order Date"
        lblOrderDate.Font = New Font("Microsoft Sans Serif", 10)

        lblPostCode.AutoSize = True
        lblPostCode.Name = "lblPostCode"
        lblPostCode.Text = "Post Code"
        lblPostCode.Font = New Font("Microsoft Sans Serif", 10)

        lblCountry.AutoSize = True
        lblCountry.Name = "lblCountry"
        lblCountry.Text = "Country"
        lblCountry.Font = New Font("Microsoft Sans Serif", 10)

        lblTotal.AutoSize = True
        lblTotal.Name = "lblTotal"
        lblTotal.Text = "Total (£)"
        lblTotal.Font = New Font("Microsoft Sans Serif", 10)

        lblNotes.AutoSize = True
        lblNotes.Name = "lblNotes"
        lblNotes.Text = "Notes"
        lblNotes.Font = New Font("Microsoft Sans Serif", 10)

        Main.tblOrders.SuspendLayout()
        Main.tblOrders.Controls.Add(lblCustomerName, 0, 0)
        Main.tblOrders.Controls.Add(lblOrderID, 1, 0)
        Main.tblOrders.Controls.Add(lblOrderDate, 2, 0)
        Main.tblOrders.Controls.Add(lblPostCode, 3, 0)
        Main.tblOrders.Controls.Add(lblCountry, 4, 0)
        Main.tblOrders.Controls.Add(lblTotal, 5, 0)
        Main.tblOrders.Controls.Add(lblNotes, 6, 0) 'this adds the headers to the orders table
        Main.tblOrders.ResumeLayout()

    End Sub
    Sub FillOrdersTable()
        Dim linecountO As Integer = IO.File.ReadAllLines("Orders.txt").Length

        ResetTableOrders()
        selectedCustomerID = Main.tblPeople.GetControlFromPosition(6, SelectedRowPeopleFunction).Text
        Main.lblCustomerID.Text = selectedCustomerID
        FileOpen(1, "Orders.txt", OpenMode.Input)
        Main.tblOrders.SuspendLayout()

        For i As Integer = 0 To linecountO - 1
            Dim fullName As New Label
            Dim customerID As New Label
            Dim companyName As New Label
            Dim orderID As New Label
            Dim orderDate As New Label
            Dim notes As New Label
            Dim ShipAddressLine1 As New Label
            Dim ShipAddressLine2 As New Label
            Dim ShipTownCity As New Label
            Dim ShipPostCode As New Label
            Dim ShipCountry As New Label
            Dim BillAddressLine1 As New Label
            Dim BillAddressLine2 As New Label
            Dim BillTownCity As New Label
            Dim BillPostCode As New Label
            Dim BillCountry As New Label
            Dim totalPrice As New Label

            fullNameL(i) = fullName
            customerIDL(i) = customerID
            companyNameL(i) = companyName
            orderIDL(i) = orderID
            orderDateL(i) = orderDate
            notesL(i) = notes
            ShipAddressLine1L(i) = ShipAddressLine1
            ShipAddressLine2L(i) = ShipAddressLine2
            ShipTownCityL(i) = ShipTownCity
            ShipPostCodeL(i) = ShipPostCode
            ShipCountryL(i) = ShipCountry
            BillAddressLine1L(i) = BillAddressLine1
            BillAddressLine2L(i) = BillAddressLine2
            BillTownCityL(i) = BillTownCity
            BillPostCodeL(i) = BillPostCode
            BillCountryL(i) = BillCountry
            totalPriceL(i) = totalPrice

            Input(1, fullName.Text)
            Input(1, customerID.Text)
            Input(1, companyName.Text)
            Input(1, orderID.Text)
            Input(1, orderDate.Text)
            Input(1, notes.Text)
            Input(1, ShipAddressLine1.Text)
            Input(1, ShipAddressLine2.Text)
            Input(1, ShipTownCity.Text)
            Input(1, ShipPostCode.Text)
            Input(1, ShipCountry.Text)
            Input(1, BillAddressLine1.Text)
            Input(1, BillAddressLine2.Text)
            Input(1, BillTownCity.Text)
            Input(1, BillPostCode.Text)
            Input(1, BillCountry.Text)
            Input(1, totalPrice.Text)

            fullName.Name = "fullName" & i.ToString
            orderID.Name = "orderID" & i.ToString
            orderDate.Name = "orderDate" & i.ToString
            ShipPostCode.Name = "ShipPostCode" & i.ToString
            ShipCountry.Name = "ShipCountry" & i.ToString
            totalPrice.Name = "totalPrice" & i.ToString
            notes.Name = "notes" & i.ToString

            fullName.AutoSize = True
            orderID.AutoSize = True
            orderDate.AutoSize = True
            ShipPostCode.AutoSize = True
            ShipCountry.AutoSize = True
            totalPrice.AutoSize = True
            notes.AutoSize = True

            If selectedCustomerID = customerID.Text Then
                Main.tblOrders.GrowStyle = TableLayoutPanelGrowStyle.AddRows
                Main.tblOrders.RowStyles.Add(New RowStyle(SizeType.Absolute, 30))
                Main.tblOrders.RowCount += 1
                Main.tblOrders.Controls.Add(fullNameL(i), 0, Main.tblOrders.RowCount - 1)
                Main.tblOrders.Controls.Add(orderIDL(i), 1, Main.tblOrders.RowCount - 1)
                Main.tblOrders.Controls.Add(orderDateL(i), 2, Main.tblOrders.RowCount - 1)
                Main.tblOrders.Controls.Add(ShipPostCodeL(i), 3, Main.tblOrders.RowCount - 1) 'this fills the orders table with all the orders when the program starts
                Main.tblOrders.Controls.Add(ShipCountryL(i), 4, Main.tblOrders.RowCount - 1)
                Main.tblOrders.Controls.Add(totalPriceL(i), 5, Main.tblOrders.RowCount - 1)
                Main.tblOrders.Controls.Add(notesL(i), 6, Main.tblOrders.RowCount - 1)
            End If
        Next i
        Main.tblOrders.ResumeLayout()

        FileClose()

    End Sub
    Sub ResetTableOrders()
        Main.tblOrders.Controls.Clear()
        Main.tblOrders.RowCount = 1 'this clears the orders table
        LoadTableOrders()
    End Sub
End Module
