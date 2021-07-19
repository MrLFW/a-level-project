Module Orders
    Public ExVAT As Single
    Public VAT As Single
    Public total As Single
    Sub LoadNewOrderForm()

        Dim NewOrder As New Form
        Dim lblNewOrderTitle As New Label()
        Dim lblFullName As New Label()
        Dim lblCustomerID As New Label()
        Dim txtFullName As New TextBox()
        Dim txtCustomerID As New TextBox()
        Dim txtOrderID As New TextBox()
        Dim lblOrderID As New Label()
        Dim txtCompanyName As New TextBox()
        Dim lblCompanyName As New Label()
        Dim txtDate As New TextBox()
        Dim lblDate As New Label()
        Dim txtNotes As New TextBox()
        Dim lblNotes As New Label()
        Dim txtShipAddressLine1 As New TextBox()
        Dim lblShipAddressLine1 As New Label()
        Dim cbxSame As New CheckBox()
        Dim lblSame As New Label()
        Dim txtShipAddressLine2 As New TextBox()
        Dim lblShipAddressLine2 As New Label()
        Dim txtShipTownCity As New TextBox()
        Dim lblShipTownCity As New Label()
        Dim txtShipPostCode As New TextBox()
        Dim lblShipPostCode As New Label()
        Dim txtShipCountry As New TextBox()
        Dim lblShipCountry As New Label()
        Dim txtBillCountry As New TextBox()
        Dim lblBillCountry As New Label()
        Dim txtBillPostCode As New TextBox()
        Dim lblBillPostCode As New Label()
        Dim txtBillTownCity As New TextBox()
        Dim lblBillTownCity As New Label()
        Dim txtBillAddressLine2 As New TextBox()
        Dim lblBillAddressLine2 As New Label()
        Dim txtBillAddressLine1 As New TextBox()
        Dim lblBillAddressLine1 As New Label()
        Dim lblShipping As New Label()
        Dim lblBilling As New Label()
        Dim lblExVAT As New Label()
        Dim lblVAT As New Label()
        Dim lblTotal As New Label()
        Dim lblExVATValue As New Label()
        Dim lblVATValue As New Label()
        Dim lblTotalValue As New Label()
        Dim btnDelete As New Button()
        Dim tblItems As New TableLayoutPanel()
        Dim btnAdd As New Button()
        Dim txtPartNumber As New TextBox()
        Dim txtQuantity As New TextBox()
        Dim txtPrice As New TextBox()
        Dim lblPartNumber As New Label()
        Dim lblQuantity As New Label()
        Dim lblPrice As New Label()
        Dim lblItems As New Label()
        Dim lblPartNumberTbl As New Label()
        Dim lblQuantityTbl As New Label()
        Dim lblPriceTbl As New Label()
        Dim btnSubmit = New Button()
        Dim btnCancel = New Button()

        NewOrder.SuspendLayout()

        lblNewOrderTitle.AutoSize = True
        lblNewOrderTitle.Font = New Font("Microsoft Sans Serif", 14.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        lblNewOrderTitle.Location = New Point(12, 9)
        lblNewOrderTitle.Name = "lblNewOrderTitle"
        lblNewOrderTitle.Size = New Size(103, 24)
        lblNewOrderTitle.TabIndex = 0
        lblNewOrderTitle.Text = "New Order"

        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Microsoft Sans Serif", 11.25!)
        lblFullName.Location = New Point(54, 61)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(75, 18)
        lblFullName.Text = "Full Name"

        lblCustomerID.AutoSize = True
        lblCustomerID.Font = New Font("Microsoft Sans Serif", 11.25!)
        lblCustomerID.Location = New Point(37, 87)
        lblCustomerID.Name = "lblCustomerID"
        lblCustomerID.Size = New Size(92, 18)
        lblCustomerID.TabIndex = 2
        lblCustomerID.Text = "Customer ID"

        txtFullName.Location = New Point(135, 59)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(128, 20)
        txtFullName.TabIndex = 3

        txtCustomerID.Location = New Point(135, 85)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.Size = New Size(128, 20)
        txtCustomerID.TabIndex = 4

        txtOrderID.Location = New Point(404, 59)
        txtOrderID.Name = "txtOrderID"
        txtOrderID.Size = New Size(82, 20)
        txtOrderID.TabIndex = 6

        lblOrderID.AutoSize = True
        lblOrderID.Font = New Font("Microsoft Sans Serif", 11.25!)
        lblOrderID.Location = New Point(334, 61)
        lblOrderID.Name = "lblOrderID"
        lblOrderID.Size = New Size(64, 18)
        lblOrderID.TabIndex = 5
        lblOrderID.Text = "Order ID"

        txtCompanyName.Location = New Point(135, 111)
        txtCompanyName.Name = "txtCompanyName"
        txtCompanyName.Size = New Size(128, 20)
        txtCompanyName.TabIndex = 9

        lblCompanyName.AutoSize = True
        lblCompanyName.Font = New Font("Microsoft Sans Serif", 11.25!)
        lblCompanyName.Location = New Point(13, 113)
        lblCompanyName.Name = "lblCompanyName"
        lblCompanyName.Size = New Size(116, 18)
        lblCompanyName.TabIndex = 7
        lblCompanyName.Text = "Company Name"

        txtDate.Location = New Point(404, 85)
        txtDate.Name = "txtDate"
        txtDate.Size = New Size(128, 20)
        txtDate.TabIndex = 12

        lblDate.AutoSize = True
        lblDate.Font = New Font("Microsoft Sans Serif", 11.25!)
        lblDate.Location = New Point(359, 87)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(39, 18)
        lblDate.TabIndex = 11
        lblDate.Text = "Date"

        txtNotes.Location = New Point(404, 111)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(128, 46)
        txtNotes.TabIndex = 14

        lblNotes.AutoSize = True
        lblNotes.Font = New Font("Microsoft Sans Serif", 11.25!)
        lblNotes.Location = New Point(350, 113)
        lblNotes.Name = "lblNotes"
        lblNotes.Size = New Size(48, 18)
        lblNotes.TabIndex = 13
        lblNotes.Text = "Notes"

        txtShipAddressLine1.Location = New Point(135, 217)
        txtShipAddressLine1.Name = "txtShipAddressLine1"
        txtShipAddressLine1.Size = New Size(128, 20)
        txtShipAddressLine1.TabIndex = 16

        lblShipAddressLine1.AutoSize = True
        lblShipAddressLine1.Font = New Font("Microsoft Sans Serif", 11.25!)
        lblShipAddressLine1.Location = New Point(24, 219)
        lblShipAddressLine1.Name = "lblShipAddressLine1"
        lblShipAddressLine1.Size = New Size(105, 18)
        lblShipAddressLine1.TabIndex = 15
        lblShipAddressLine1.Text = "Address Line 1"

        cbxSame.AutoSize = True
        cbxSame.Location = New Point(517, 356)
        cbxSame.Name = "cbxSame"
        cbxSame.Size = New Size(15, 14)
        cbxSame.TabIndex = 17
        cbxSame.UseVisualStyleBackColor = True

        lblSame.AutoSize = True
        lblSame.Font = New Font("Microsoft Sans Serif", 11.25!)
        lblSame.Location = New Point(346, 352)
        lblSame.Name = "lblSame"
        lblSame.Size = New Size(165, 18)
        lblSame.TabIndex = 18
        lblSame.Text = "Billing same as shipping"

        txtShipAddressLine2.Location = New Point(135, 243)
        txtShipAddressLine2.Name = "txtShipAddressLine2"
        txtShipAddressLine2.Size = New Size(128, 20)
        txtShipAddressLine2.TabIndex = 20

        lblShipAddressLine2.AutoSize = True
        lblShipAddressLine2.Font = New Font("Microsoft Sans Serif", 11.25!)
        lblShipAddressLine2.Location = New Point(24, 245)
        lblShipAddressLine2.Name = "lblShipAddressLine2"
        lblShipAddressLine2.Size = New Size(105, 18)
        lblShipAddressLine2.TabIndex = 19
        lblShipAddressLine2.Text = "Address Line 2"

        txtShipTownCity.Location = New Point(135, 269)
        txtShipTownCity.Name = "txtShipTownCity"
        txtShipTownCity.Size = New Size(128, 20)
        txtShipTownCity.TabIndex = 22

        lblShipTownCity.AutoSize = True
        lblShipTownCity.Font = New Font("Microsoft Sans Serif", 11.25!)
        lblShipTownCity.Location = New Point(55, 271)
        lblShipTownCity.Name = "lblShipTownCity"
        lblShipTownCity.Size = New Size(74, 18)
        lblShipTownCity.TabIndex = 21
        lblShipTownCity.Text = "Town/City"

        txtShipPostCode.Location = New Point(135, 295)
        txtShipPostCode.Name = "txtShipPostCode"
        txtShipPostCode.Size = New Size(128, 20)
        txtShipPostCode.TabIndex = 24

        lblShipPostCode.AutoSize = True
        lblShipPostCode.Font = New Font("Microsoft Sans Serif", 11.25!)
        lblShipPostCode.Location = New Point(50, 297)
        lblShipPostCode.Name = "lblShipPostCode"
        lblShipPostCode.Size = New Size(79, 18)
        lblShipPostCode.TabIndex = 23
        lblShipPostCode.Text = "Post Code"

        txtShipCountry.Location = New Point(135, 321)
        txtShipCountry.Name = "txtShipCountry"
        txtShipCountry.Size = New Size(128, 20)
        txtShipCountry.TabIndex = 26

        lblShipCountry.AutoSize = True
        lblShipCountry.Font = New Font("Microsoft Sans Serif", 11.25!)
        lblShipCountry.Location = New Point(69, 323)
        lblShipCountry.Name = "lblShipCountry"
        lblShipCountry.Size = New Size(60, 18)
        lblShipCountry.TabIndex = 25
        lblShipCountry.Text = "Country"

        txtBillCountry.Location = New Point(404, 321)
        txtBillCountry.Name = "txtBillCountry"
        txtBillCountry.Size = New Size(128, 20)
        txtBillCountry.TabIndex = 36

        lblBillCountry.AutoSize = True
        lblBillCountry.Font = New Font("Microsoft Sans Serif", 11.25!)
        lblBillCountry.Location = New Point(338, 323)
        lblBillCountry.Name = "lblBillCountry"
        lblBillCountry.Size = New Size(60, 18)
        lblBillCountry.TabIndex = 35
        lblBillCountry.Text = "Country"

        txtBillPostCode.Location = New Point(404, 295)
        txtBillPostCode.Name = "txtBillPostCode"
        txtBillPostCode.Size = New Size(128, 20)
        txtBillPostCode.TabIndex = 34

        lblBillPostCode.AutoSize = True
        lblBillPostCode.Font = New Font("Microsoft Sans Serif", 11.25!)
        lblBillPostCode.Location = New Point(319, 297)
        lblBillPostCode.Name = "lblBillPostCode"
        lblBillPostCode.Size = New Size(79, 18)
        lblBillPostCode.TabIndex = 33
        lblBillPostCode.Text = "Post Code"

        txtBillTownCity.Location = New Point(404, 269)
        txtBillTownCity.Name = "txtBillTownCity"
        txtBillTownCity.Size = New Size(128, 20)
        txtBillTownCity.TabIndex = 32

        lblBillTownCity.AutoSize = True
        lblBillTownCity.Font = New Font("Microsoft Sans Serif", 11.25!)
        lblBillTownCity.Location = New Point(324, 271)
        lblBillTownCity.Name = "lblBillTownCity"
        lblBillTownCity.Size = New Size(74, 18)
        lblBillTownCity.TabIndex = 31
        lblBillTownCity.Text = "Town/City"

        txtBillAddressLine2.Location = New Point(404, 243)
        txtBillAddressLine2.Name = "txtBillAddressLine2"
        txtBillAddressLine2.Size = New Size(128, 20)
        txtBillAddressLine2.TabIndex = 30

        lblBillAddressLine2.AutoSize = True
        lblBillAddressLine2.Font = New Font("Microsoft Sans Serif", 11.25!)
        lblBillAddressLine2.Location = New Point(293, 245)
        lblBillAddressLine2.Name = "lblBillAddressLine2"
        lblBillAddressLine2.Size = New Size(105, 18)
        lblBillAddressLine2.TabIndex = 29
        lblBillAddressLine2.Text = "Address Line 2"

        txtBillAddressLine1.Location = New Point(404, 217)
        txtBillAddressLine1.Name = "txtBillAddressLine1"
        txtBillAddressLine1.Size = New Size(128, 20)
        txtBillAddressLine1.TabIndex = 28

        lblBillAddressLine1.AutoSize = True
        lblBillAddressLine1.Font = New Font("Microsoft Sans Serif", 11.25!)
        lblBillAddressLine1.Location = New Point(293, 219)
        lblBillAddressLine1.Name = "lblBillAddressLine1"
        lblBillAddressLine1.Size = New Size(105, 18)
        lblBillAddressLine1.TabIndex = 27
        lblBillAddressLine1.Text = "Address Line 1"

        lblShipping.AutoSize = True
        lblShipping.Font = New Font("Microsoft Sans Serif", 14.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        lblShipping.Location = New Point(131, 184)
        lblShipping.Name = "lblShipping"
        lblShipping.Size = New Size(85, 24)
        lblShipping.TabIndex = 37
        lblShipping.Text = "Shipping"

        lblBilling.AutoSize = True
        lblBilling.Font = New Font("Microsoft Sans Serif", 14.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        lblBilling.Location = New Point(400, 184)
        lblBilling.Name = "lblBilling"
        lblBilling.Size = New Size(60, 24)
        lblBilling.TabIndex = 38
        lblBilling.Text = "Billing"

        lblExVAT.AutoSize = True
        lblExVAT.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        lblExVAT.Location = New Point(59, 436)
        lblExVAT.Name = "lblExVAT"
        lblExVAT.Size = New Size(101, 20)
        lblExVAT.TabIndex = 39
        lblExVAT.Text = "Price ExVAT:"

        lblVAT.AutoSize = True
        lblVAT.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        lblVAT.Location = New Point(116, 466)
        lblVAT.Name = "lblVAT"
        lblVAT.Size = New Size(44, 20)
        lblVAT.TabIndex = 40
        lblVAT.Text = "VAT:"

        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Microsoft Sans Serif", 14.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        lblTotal.Location = New Point(104, 496)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(56, 24)
        lblTotal.TabIndex = 41
        lblTotal.Text = "Total:"

        lblExVATValue.AutoSize = True
        lblExVATValue.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        lblExVATValue.Location = New Point(166, 436)
        lblExVATValue.Name = "lblExVATValue"
        lblExVATValue.Size = New Size(18, 20)
        lblExVATValue.TabIndex = 42
        lblExVATValue.Text = "£"

        lblVATValue.AutoSize = True
        lblVATValue.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        lblVATValue.Location = New Point(166, 466)
        lblVATValue.Name = "lblVATValue"
        lblVATValue.Size = New Size(18, 20)
        lblVATValue.TabIndex = 43
        lblVATValue.Text = "£"

        lblTotalValue.AutoSize = True
        lblTotalValue.Font = New Font("Microsoft Sans Serif", 14.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        lblTotalValue.Location = New Point(166, 496)
        lblTotalValue.Name = "lblTotalValue"
        lblTotalValue.Size = New Size(20, 24)
        lblTotalValue.TabIndex = 44
        lblTotalValue.Text = "£"

        btnDelete.Location = New Point(754, 167)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(71, 23)
        btnDelete.TabIndex = 46
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True

        tblItems.BackColor = Color.Gainsboro
        tblItems.CellBorderStyle = TableLayoutPanelCellBorderStyle.[Single]
        tblItems.ColumnCount = 3
        tblItems.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 90.0!))
        tblItems.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 90.0!))
        tblItems.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 90.0!))
        tblItems.Controls.Add(lblPartNumberTbl, 0, 0)
        tblItems.Controls.Add(lblQuantityTbl, 1, 0)
        tblItems.Controls.Add(lblPriceTbl, 2, 0)
        tblItems.Location = New Point(602, 217)
        tblItems.Name = "tblItems"
        tblItems.RowCount = 1
        tblItems.RowStyles.Add(New RowStyle())
        tblItems.Size = New Size(270, 204)
        tblItems.AutoSize = True
        tblItems.AutoScroll = True

        btnAdd.Location = New Point(677, 167)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(71, 23)
        btnAdd.TabIndex = 45
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True

        txtPartNumber.Location = New Point(697, 85)
        txtPartNumber.Name = "txtPartNumber"
        txtPartNumber.Size = New Size(128, 20)
        txtPartNumber.TabIndex = 48

        txtQuantity.Location = New Point(697, 111)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(128, 20)
        txtQuantity.TabIndex = 49

        txtPrice.Location = New Point(697, 137)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(128, 20)
        txtPrice.TabIndex = 50

        lblItems.AutoSize = True
        lblItems.Font = New Font("Microsoft Sans Serif", 14.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        lblItems.Location = New Point(598, 54)
        lblItems.Name = "lblItems"
        lblItems.Size = New Size(54, 24)
        lblItems.TabIndex = 54
        lblItems.Text = "Items"

        lblPartNumber.AutoSize = True
        lblPartNumber.Font = New Font("Microsoft Sans Serif", 11.25!)
        lblPartNumber.Location = New Point(599, 87)
        lblPartNumber.Name = "lblPartNumber"
        lblPartNumber.Size = New Size(92, 18)
        lblPartNumber.TabIndex = 51
        lblPartNumber.Text = "Part Number"

        lblQuantity.AutoSize = True
        lblQuantity.Font = New Font("Microsoft Sans Serif", 11.25!)
        lblQuantity.Location = New Point(629, 113)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(62, 18)
        lblQuantity.TabIndex = 52
        lblQuantity.Text = "Quantity"

        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Microsoft Sans Serif", 11.25!)
        lblPrice.Location = New Point(568, 139)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(113, 18)
        lblPrice.TabIndex = 53
        lblPrice.Text = "ExVAT Per Item £"

        lblPartNumberTbl.AutoSize = True
        lblPartNumberTbl.Font = New Font("Microsoft Sans Serif", 10)
        lblPartNumberTbl.Location = New Point(4, 1)
        lblPartNumberTbl.Name = "lblPartNumberTbl"
        lblPartNumberTbl.Size = New Size(83, 16)
        lblPartNumberTbl.TabIndex = 0
        lblPartNumberTbl.Text = "Part Number"

        lblQuantityTbl.AutoSize = True
        lblQuantityTbl.Font = New Font("Microsoft Sans Serif", 10)
        lblQuantityTbl.Location = New Point(95, 1)
        lblQuantityTbl.Name = "lblQuantityTbl"
        lblQuantityTbl.Size = New Size(56, 16)
        lblQuantityTbl.TabIndex = 1
        lblQuantityTbl.Text = "Quantity"

        lblPriceTbl.AutoSize = True
        lblPriceTbl.Font = New Font("Microsoft Sans Serif", 10)
        lblPriceTbl.Location = New Point(186, 1)
        lblPriceTbl.Name = "lblPriceTbl"
        lblPriceTbl.Size = New Size(39, 16)
        lblPriceTbl.TabIndex = 2
        lblPriceTbl.Text = "Price (£)"

        btnSubmit.Location = New Point(816, 489)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(89, 43)
        btnSubmit.TabIndex = 55
        btnSubmit.Text = "Submit Order"
        btnSubmit.UseVisualStyleBackColor = True

        btnCancel.Location = New Point(721, 489)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(89, 43)
        btnCancel.TabIndex = 56
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True 'this is creating the new order form


        Dim orderIDint, tempInt, tempBig As Integer
        Dim tempStr As String
        tempStr = ""
        tempInt = 0
        tempBig = 0
        FileOpen(2, "Orders.txt", OpenMode.Input)
        While Not EOF(2)

            Input(2, "")
            Input(2, "")
            Input(2, "")
            Input(2, tempStr)
            Input(2, "")
            Input(2, "")
            Input(2, "")
            Input(2, "")
            Input(2, "")
            Input(2, "")
            Input(2, "")
            Input(2, "")
            Input(2, "")
            Input(2, "")
            Input(2, "")
            Input(2, "")
            Input(2, "")

            tempInt = tempStr.Substring(1)

            If tempInt >= tempBig Then
                tempBig = tempInt
            End If
        End While
        orderIDint = tempBig + 1
        FileClose(2)
        txtOrderID.Text = "O" & orderIDint.ToString 'this automatically enters a new order ID

        txtDate.Text = CStr(Date.Today) 'this automatically enters the current date

        NewOrder.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        NewOrder.AutoScaleMode = AutoScaleMode.Font
        NewOrder.ClientSize = New Size(964, 563)
        NewOrder.Controls.Add(btnCancel)
        NewOrder.Controls.Add(btnSubmit)
        NewOrder.Controls.Add(lblItems)
        NewOrder.Controls.Add(lblPrice)
        NewOrder.Controls.Add(lblQuantity)
        NewOrder.Controls.Add(lblPartNumber)
        NewOrder.Controls.Add(txtPrice)
        NewOrder.Controls.Add(txtQuantity)
        NewOrder.Controls.Add(txtPartNumber)
        NewOrder.Controls.Add(tblItems)
        NewOrder.Controls.Add(btnDelete)
        NewOrder.Controls.Add(btnAdd)
        NewOrder.Controls.Add(lblTotalValue)
        NewOrder.Controls.Add(lblVATValue)
        NewOrder.Controls.Add(lblExVATValue)
        NewOrder.Controls.Add(lblTotal)
        NewOrder.Controls.Add(lblVAT)
        NewOrder.Controls.Add(lblExVAT)
        NewOrder.Controls.Add(lblBilling)
        NewOrder.Controls.Add(lblShipping)
        NewOrder.Controls.Add(txtBillCountry)
        NewOrder.Controls.Add(lblBillCountry)
        NewOrder.Controls.Add(txtBillPostCode)
        NewOrder.Controls.Add(lblBillPostCode)
        NewOrder.Controls.Add(txtBillTownCity)
        NewOrder.Controls.Add(lblBillTownCity)
        NewOrder.Controls.Add(txtBillAddressLine2)
        NewOrder.Controls.Add(lblBillAddressLine2)
        NewOrder.Controls.Add(txtBillAddressLine1)
        NewOrder.Controls.Add(lblBillAddressLine1)
        NewOrder.Controls.Add(txtShipCountry)
        NewOrder.Controls.Add(lblShipCountry)
        NewOrder.Controls.Add(txtShipPostCode)
        NewOrder.Controls.Add(lblShipPostCode)
        NewOrder.Controls.Add(txtShipTownCity)
        NewOrder.Controls.Add(lblShipTownCity)
        NewOrder.Controls.Add(txtShipAddressLine2)
        NewOrder.Controls.Add(lblShipAddressLine2)
        NewOrder.Controls.Add(lblSame)
        NewOrder.Controls.Add(cbxSame)
        NewOrder.Controls.Add(txtShipAddressLine1)
        NewOrder.Controls.Add(lblShipAddressLine1)
        NewOrder.Controls.Add(txtNotes)
        NewOrder.Controls.Add(lblNotes)
        NewOrder.Controls.Add(txtDate)
        NewOrder.Controls.Add(lblDate)
        NewOrder.Controls.Add(txtCompanyName)
        NewOrder.Controls.Add(lblCompanyName)
        NewOrder.Controls.Add(txtOrderID)
        NewOrder.Controls.Add(lblOrderID)
        NewOrder.Controls.Add(txtCustomerID)
        NewOrder.Controls.Add(txtFullName)
        NewOrder.Controls.Add(lblCustomerID)
        NewOrder.Controls.Add(lblFullName)
        NewOrder.Controls.Add(lblNewOrderTitle)
        NewOrder.Name = "NewOrder"
        NewOrder.Text = "New Order"
        NewOrder.ResumeLayout(False)
        NewOrder.PerformLayout()

        NewOrder.Show()


        AddHandler btnCancel.Click, Sub(sender, e) btnCancel_Click(NewOrder)
        AddHandler btnAdd.Click, Sub(sender, e) btnAdd_Click(txtPartNumber, txtQuantity, txtPrice, tblItems, lblExVATValue, lblVATValue, lblTotalValue)
        AddHandler btnDelete.Click, Sub(sender, e) btnDelete_Click(tblItems, lblExVATValue, lblVATValue, lblTotalValue)
        AddHandler btnSubmit.Click, Sub(sender, e) btnSubmit_Click(NewOrder, tblItems, txtFullName, txtCustomerID, txtCompanyName, txtOrderID, txtDate, txtNotes, txtShipAddressLine1, txtShipAddressLine2, txtShipTownCity, txtShipPostCode, txtShipCountry, txtBillAddressLine1, txtBillAddressLine2, txtBillTownCity, txtBillPostCode, txtBillCountry)
        AddHandler cbxSame.Click, Sub(sender, e) cbxSame_Click(txtShipAddressLine1, txtShipAddressLine2, txtShipTownCity, txtShipPostCode, txtShipCountry, txtBillAddressLine1, txtBillAddressLine2, txtBillTownCity, txtBillPostCode, txtBillCountry)
    End Sub
    Sub btnCancel_Click(ByVal NewOrder As Form)

        ExVAT = 0
        VAT = 0
        total = 0

        NewOrder.Close()
    End Sub
    Sub btnAdd_Click(txtPartNumber As TextBox, ByVal txtQuantity As TextBox, ByVal txtPrice As TextBox, ByRef tblItems As TableLayoutPanel, ByRef lblExVATValue As Label, ByRef lblVATValue As Label, ByRef lblTotalValue As Label)

        Dim validQuantity As Boolean = False
        Dim validExVAT As Boolean = False

        If IsNumeric(txtQuantity.Text) = True Then
            validQuantity = True
        Else
            MsgBox("Invalid quantity")
        End If

        If IsNumeric(txtPrice.Text) = True Then
            validExVAT = True
        Else
            MsgBox("Invalid price")
        End If

        If validQuantity = True And validExVAT = True Then
            Dim listlblPartNo, listlblQty, listlblPrice As New List(Of Label)
            Dim lblPartNo, lblQty, lblPrice As New Label

            lblPartNo.Text = txtPartNumber.Text
            lblQty.Text = txtQuantity.Text
            lblPrice.Text = txtPrice.Text

            listlblPartNo.Add(lblPartNo)
            listlblQty.Add(lblQty)
            listlblPrice.Add(lblPrice)

            tblItems.GrowStyle = TableLayoutPanelGrowStyle.AddRows
            tblItems.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            tblItems.SuspendLayout()
            tblItems.RowCount += 1
            tblItems.Controls.Add(lblPartNo, 0, tblItems.RowCount - 1)
            tblItems.Controls.Add(lblQty, 1, tblItems.RowCount - 1)
            tblItems.Controls.Add(lblPrice, 2, tblItems.RowCount - 1)
            tblItems.ResumeLayout()

            ExVAT += CSng(tblItems.GetControlFromPosition(1, tblItems.RowCount - 1).Text) * CSng(tblItems.GetControlFromPosition(2, tblItems.RowCount - 1).Text)
            VAT = ExVAT * 0.2
            total = VAT + ExVAT

            lblExVATValue.Text = "£" & ExVAT.ToString
            lblVATValue.Text = "£" & VAT.ToString
            lblTotalValue.Text = "£" & total.ToString 'this form is for when an item is added to an order. it calculates the new prices and adds the items to the table
        End If
    End Sub
    Sub btnDelete_Click(ByRef tblItems As TableLayoutPanel, ByRef lblExVATValue As Label, ByRef lblVATValue As Label, ByRef lblTotalValue As Label)

        ExVAT -= CSng(tblItems.GetControlFromPosition(1, tblItems.RowCount - 1).Text) * CSng(tblItems.GetControlFromPosition(2, tblItems.RowCount - 1).Text)
        VAT = ExVAT * 0.2
        total = VAT + ExVAT
        lblExVATValue.Text = "£" & ExVAT.ToString
        lblVATValue.Text = "£" & VAT.ToString
        lblTotalValue.Text = "£" & total.ToString

        If tblItems.RowCount <> 1 Then
            For i As Integer = 0 To Main.tblPeople.ColumnCount - 1
                tblItems.Controls.Remove(tblItems.GetControlFromPosition(i, tblItems.RowCount - 1)) 'this removes the most recently added item from the table
            Next
            tblItems.RowCount -= 1
        End If
    End Sub
    Sub btnSubmit_Click(ByVal NewOrder As Form, ByRef tblItems As TableLayoutPanel, ByVal txtFullName As TextBox, txtCustomerID As TextBox, ByVal txtCompanyName As TextBox, ByVal txtOrderID As TextBox, ByVal txtDate As TextBox, ByVal txtNotes As TextBox, ByVal txtShipAddressLine1 As TextBox, ByVal txtShipAddressLine2 As TextBox, ByVal txtShipTownCity As TextBox, ByVal txtShipPostCode As TextBox, ByVal txtShipCountry As TextBox, ByVal txtBillAddressLine1 As TextBox, ByVal txtBillAddressLine2 As TextBox, ByVal txtBillTownCity As TextBox, ByVal txtBillPostCode As TextBox, ByVal txtBillCountry As TextBox)

        FileOpen(1, "Orders.txt", OpenMode.Append)
        Write(1, txtFullName.Text)
        Write(1, txtCustomerID.Text)
        Write(1, txtCompanyName.Text)
        Write(1, txtOrderID.Text)
        Write(1, txtDate.Text)
        Write(1, txtNotes.Text)
        Write(1, txtShipAddressLine1.Text)
        Write(1, txtShipAddressLine2.Text)
        Write(1, txtShipTownCity.Text)
        Write(1, txtShipPostCode.Text)
        Write(1, txtShipCountry.Text)
        Write(1, txtBillAddressLine1.Text)
        Write(1, txtBillAddressLine2.Text)
        Write(1, txtBillTownCity.Text)
        Write(1, txtBillPostCode.Text)
        Write(1, txtBillCountry.Text)
        WriteLine(1, total)
        FileClose(1) 'this adds all the data to the orders text file and saves the order

        FileOpen(2, txtOrderID.Text & ".txt", OpenMode.Append) 'this saves the items in the order
        For i = 1 To tblItems.RowCount - 1

            Write(2, tblItems.GetControlFromPosition(0, i).Text)
            Write(2, tblItems.GetControlFromPosition(1, i).Text)
            WriteLine(2, tblItems.GetControlFromPosition(2, i).Text)

        Next
        FileClose(2)
        ExVAT = 0
        VAT = 0
        total = 0

        NewOrder.Close()
    End Sub
    Sub cbxSame_Click(ByVal txtShipAddressLine1 As TextBox, ByVal txtShipAddressLine2 As TextBox, ByVal txtShipTownCity As TextBox, ByVal txtShipPostCode As TextBox, ByVal txtShipCountry As TextBox, ByRef txtBillAddressLine1 As TextBox, ByRef txtBillAddressLine2 As TextBox, ByRef txtBillTownCity As TextBox, ByRef txtBillPostCode As TextBox, ByRef txtBillCountry As TextBox)
        txtBillAddressLine1.Text = txtShipAddressLine1.Text
        txtBillAddressLine2.Text = txtShipAddressLine2.Text
        txtBillTownCity.Text = txtShipTownCity.Text
        txtBillPostCode.Text = txtShipPostCode.Text
        txtBillCountry.Text = txtShipCountry.Text

        If txtBillAddressLine1.ReadOnly = False Then
            txtBillAddressLine1.ReadOnly = True
            txtBillAddressLine2.ReadOnly = True
            txtBillTownCity.ReadOnly = True
            txtBillPostCode.ReadOnly = True
            txtBillCountry.ReadOnly = True
        Else
            txtBillAddressLine1.ReadOnly = False 'this fills in the billing address to whatever is in the shipping address
            txtBillAddressLine2.ReadOnly = False
            txtBillTownCity.ReadOnly = False
            txtBillPostCode.ReadOnly = False
            txtBillCountry.ReadOnly = False
        End If

    End Sub
End Module