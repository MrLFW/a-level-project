<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewOrder
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
        Me.lblNewOrderTitle = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.txtCompanyID = New System.Windows.Forms.TextBox()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.lblCompanyID = New System.Windows.Forms.Label()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtShipAddressLine1 = New System.Windows.Forms.TextBox()
        Me.lblShipAddressLine1 = New System.Windows.Forms.Label()
        Me.cbxSame = New System.Windows.Forms.CheckBox()
        Me.lblSame = New System.Windows.Forms.Label()
        Me.txtShipAddressLine2 = New System.Windows.Forms.TextBox()
        Me.lblShipAddressLine2 = New System.Windows.Forms.Label()
        Me.txtShipTownCity = New System.Windows.Forms.TextBox()
        Me.lblShipTownCity = New System.Windows.Forms.Label()
        Me.txtShipPostCode = New System.Windows.Forms.TextBox()
        Me.lblShipPostCode = New System.Windows.Forms.Label()
        Me.txtShipCountry = New System.Windows.Forms.TextBox()
        Me.lblShipCountry = New System.Windows.Forms.Label()
        Me.txtBillCountry = New System.Windows.Forms.TextBox()
        Me.lblBillCountry = New System.Windows.Forms.Label()
        Me.txtBillPostCode = New System.Windows.Forms.TextBox()
        Me.lblBillPostCode = New System.Windows.Forms.Label()
        Me.txtBillTownCity = New System.Windows.Forms.TextBox()
        Me.lblBillTownCity = New System.Windows.Forms.Label()
        Me.txtBillAddressLine2 = New System.Windows.Forms.TextBox()
        Me.lblBillAddressLine2 = New System.Windows.Forms.Label()
        Me.txtBillAddressLine1 = New System.Windows.Forms.TextBox()
        Me.lblBillAddressLine1 = New System.Windows.Forms.Label()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.lblBilling = New System.Windows.Forms.Label()
        Me.lblExVAT = New System.Windows.Forms.Label()
        Me.lblVAT = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblExVATValue = New System.Windows.Forms.Label()
        Me.lblVATValue = New System.Windows.Forms.Label()
        Me.lblTotalValue = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.tblItems = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPartNumberTbl = New System.Windows.Forms.Label()
        Me.lblQuantityTbl = New System.Windows.Forms.Label()
        Me.lblPriceTbl = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtPartNumber = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPartNumber = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tblItems.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNewOrderTitle
        '
        Me.lblNewOrderTitle.AutoSize = True
        Me.lblNewOrderTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewOrderTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblNewOrderTitle.Name = "lblNewOrderTitle"
        Me.lblNewOrderTitle.Size = New System.Drawing.Size(103, 24)
        Me.lblNewOrderTitle.TabIndex = 0
        Me.lblNewOrderTitle.Text = "New Order"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblFullName.Location = New System.Drawing.Point(54, 61)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(75, 18)
        Me.lblFullName.TabIndex = 1
        Me.lblFullName.Text = "Full Name"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblCustomerID.Location = New System.Drawing.Point(37, 87)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(92, 18)
        Me.lblCustomerID.TabIndex = 2
        Me.lblCustomerID.Text = "Customer ID"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(135, 59)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(128, 20)
        Me.txtFullName.TabIndex = 3
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(135, 85)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(128, 20)
        Me.txtCustomerID.TabIndex = 4
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(404, 59)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.ReadOnly = True
        Me.txtOrderID.Size = New System.Drawing.Size(82, 20)
        Me.txtOrderID.TabIndex = 6
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblOrderID.Location = New System.Drawing.Point(334, 61)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(64, 18)
        Me.lblOrderID.TabIndex = 5
        Me.lblOrderID.Text = "Order ID"
        '
        'txtCompanyID
        '
        Me.txtCompanyID.Location = New System.Drawing.Point(135, 137)
        Me.txtCompanyID.Name = "txtCompanyID"
        Me.txtCompanyID.Size = New System.Drawing.Size(128, 20)
        Me.txtCompanyID.TabIndex = 10
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(135, 111)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(128, 20)
        Me.txtCompanyName.TabIndex = 9
        '
        'lblCompanyID
        '
        Me.lblCompanyID.AutoSize = True
        Me.lblCompanyID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblCompanyID.Location = New System.Drawing.Point(39, 139)
        Me.lblCompanyID.Name = "lblCompanyID"
        Me.lblCompanyID.Size = New System.Drawing.Size(90, 18)
        Me.lblCompanyID.TabIndex = 8
        Me.lblCompanyID.Text = "Company ID"
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblCompanyName.Location = New System.Drawing.Point(13, 113)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(116, 18)
        Me.lblCompanyName.TabIndex = 7
        Me.lblCompanyName.Text = "Company Name"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(404, 85)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(128, 20)
        Me.txtDate.TabIndex = 12
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblDate.Location = New System.Drawing.Point(359, 87)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 18)
        Me.lblDate.TabIndex = 11
        Me.lblDate.Text = "Date"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(404, 111)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(128, 46)
        Me.txtNotes.TabIndex = 14
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblNotes.Location = New System.Drawing.Point(350, 113)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(48, 18)
        Me.lblNotes.TabIndex = 13
        Me.lblNotes.Text = "Notes"
        '
        'txtShipAddressLine1
        '
        Me.txtShipAddressLine1.Location = New System.Drawing.Point(135, 217)
        Me.txtShipAddressLine1.Name = "txtShipAddressLine1"
        Me.txtShipAddressLine1.Size = New System.Drawing.Size(128, 20)
        Me.txtShipAddressLine1.TabIndex = 16
        '
        'lblShipAddressLine1
        '
        Me.lblShipAddressLine1.AutoSize = True
        Me.lblShipAddressLine1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblShipAddressLine1.Location = New System.Drawing.Point(24, 219)
        Me.lblShipAddressLine1.Name = "lblShipAddressLine1"
        Me.lblShipAddressLine1.Size = New System.Drawing.Size(105, 18)
        Me.lblShipAddressLine1.TabIndex = 15
        Me.lblShipAddressLine1.Text = "Address Line 1"
        '
        'cbxSame
        '
        Me.cbxSame.AutoSize = True
        Me.cbxSame.Location = New System.Drawing.Point(517, 356)
        Me.cbxSame.Name = "cbxSame"
        Me.cbxSame.Size = New System.Drawing.Size(15, 14)
        Me.cbxSame.TabIndex = 17
        Me.cbxSame.UseVisualStyleBackColor = True
        '
        'lblSame
        '
        Me.lblSame.AutoSize = True
        Me.lblSame.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblSame.Location = New System.Drawing.Point(346, 352)
        Me.lblSame.Name = "lblSame"
        Me.lblSame.Size = New System.Drawing.Size(165, 18)
        Me.lblSame.TabIndex = 18
        Me.lblSame.Text = "Billing same as shipping"
        '
        'txtShipAddressLine2
        '
        Me.txtShipAddressLine2.Location = New System.Drawing.Point(135, 243)
        Me.txtShipAddressLine2.Name = "txtShipAddressLine2"
        Me.txtShipAddressLine2.Size = New System.Drawing.Size(128, 20)
        Me.txtShipAddressLine2.TabIndex = 20
        '
        'lblShipAddressLine2
        '
        Me.lblShipAddressLine2.AutoSize = True
        Me.lblShipAddressLine2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblShipAddressLine2.Location = New System.Drawing.Point(24, 245)
        Me.lblShipAddressLine2.Name = "lblShipAddressLine2"
        Me.lblShipAddressLine2.Size = New System.Drawing.Size(105, 18)
        Me.lblShipAddressLine2.TabIndex = 19
        Me.lblShipAddressLine2.Text = "Address Line 2"
        '
        'txtShipTownCity
        '
        Me.txtShipTownCity.Location = New System.Drawing.Point(135, 269)
        Me.txtShipTownCity.Name = "txtShipTownCity"
        Me.txtShipTownCity.Size = New System.Drawing.Size(128, 20)
        Me.txtShipTownCity.TabIndex = 22
        '
        'lblShipTownCity
        '
        Me.lblShipTownCity.AutoSize = True
        Me.lblShipTownCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblShipTownCity.Location = New System.Drawing.Point(55, 271)
        Me.lblShipTownCity.Name = "lblShipTownCity"
        Me.lblShipTownCity.Size = New System.Drawing.Size(74, 18)
        Me.lblShipTownCity.TabIndex = 21
        Me.lblShipTownCity.Text = "Town/City"
        '
        'txtShipPostCode
        '
        Me.txtShipPostCode.Location = New System.Drawing.Point(135, 295)
        Me.txtShipPostCode.Name = "txtShipPostCode"
        Me.txtShipPostCode.Size = New System.Drawing.Size(128, 20)
        Me.txtShipPostCode.TabIndex = 24
        '
        'lblShipPostCode
        '
        Me.lblShipPostCode.AutoSize = True
        Me.lblShipPostCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblShipPostCode.Location = New System.Drawing.Point(50, 297)
        Me.lblShipPostCode.Name = "lblShipPostCode"
        Me.lblShipPostCode.Size = New System.Drawing.Size(79, 18)
        Me.lblShipPostCode.TabIndex = 23
        Me.lblShipPostCode.Text = "Post Code"
        '
        'txtShipCountry
        '
        Me.txtShipCountry.Location = New System.Drawing.Point(135, 321)
        Me.txtShipCountry.Name = "txtShipCountry"
        Me.txtShipCountry.Size = New System.Drawing.Size(128, 20)
        Me.txtShipCountry.TabIndex = 26
        '
        'lblShipCountry
        '
        Me.lblShipCountry.AutoSize = True
        Me.lblShipCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblShipCountry.Location = New System.Drawing.Point(69, 323)
        Me.lblShipCountry.Name = "lblShipCountry"
        Me.lblShipCountry.Size = New System.Drawing.Size(60, 18)
        Me.lblShipCountry.TabIndex = 25
        Me.lblShipCountry.Text = "Country"
        '
        'txtBillCountry
        '
        Me.txtBillCountry.Location = New System.Drawing.Point(404, 321)
        Me.txtBillCountry.Name = "txtBillCountry"
        Me.txtBillCountry.Size = New System.Drawing.Size(128, 20)
        Me.txtBillCountry.TabIndex = 36
        '
        'lblBillCountry
        '
        Me.lblBillCountry.AutoSize = True
        Me.lblBillCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblBillCountry.Location = New System.Drawing.Point(338, 323)
        Me.lblBillCountry.Name = "lblBillCountry"
        Me.lblBillCountry.Size = New System.Drawing.Size(60, 18)
        Me.lblBillCountry.TabIndex = 35
        Me.lblBillCountry.Text = "Country"
        '
        'txtBillPostCode
        '
        Me.txtBillPostCode.Location = New System.Drawing.Point(404, 295)
        Me.txtBillPostCode.Name = "txtBillPostCode"
        Me.txtBillPostCode.Size = New System.Drawing.Size(128, 20)
        Me.txtBillPostCode.TabIndex = 34
        '
        'lblBillPostCode
        '
        Me.lblBillPostCode.AutoSize = True
        Me.lblBillPostCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblBillPostCode.Location = New System.Drawing.Point(319, 297)
        Me.lblBillPostCode.Name = "lblBillPostCode"
        Me.lblBillPostCode.Size = New System.Drawing.Size(79, 18)
        Me.lblBillPostCode.TabIndex = 33
        Me.lblBillPostCode.Text = "Post Code"
        '
        'txtBillTownCity
        '
        Me.txtBillTownCity.Location = New System.Drawing.Point(404, 269)
        Me.txtBillTownCity.Name = "txtBillTownCity"
        Me.txtBillTownCity.Size = New System.Drawing.Size(128, 20)
        Me.txtBillTownCity.TabIndex = 32
        '
        'lblBillTownCity
        '
        Me.lblBillTownCity.AutoSize = True
        Me.lblBillTownCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblBillTownCity.Location = New System.Drawing.Point(324, 271)
        Me.lblBillTownCity.Name = "lblBillTownCity"
        Me.lblBillTownCity.Size = New System.Drawing.Size(74, 18)
        Me.lblBillTownCity.TabIndex = 31
        Me.lblBillTownCity.Text = "Town/City"
        '
        'txtBillAddressLine2
        '
        Me.txtBillAddressLine2.Location = New System.Drawing.Point(404, 243)
        Me.txtBillAddressLine2.Name = "txtBillAddressLine2"
        Me.txtBillAddressLine2.Size = New System.Drawing.Size(128, 20)
        Me.txtBillAddressLine2.TabIndex = 30
        '
        'lblBillAddressLine2
        '
        Me.lblBillAddressLine2.AutoSize = True
        Me.lblBillAddressLine2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblBillAddressLine2.Location = New System.Drawing.Point(293, 245)
        Me.lblBillAddressLine2.Name = "lblBillAddressLine2"
        Me.lblBillAddressLine2.Size = New System.Drawing.Size(105, 18)
        Me.lblBillAddressLine2.TabIndex = 29
        Me.lblBillAddressLine2.Text = "Address Line 2"
        '
        'txtBillAddressLine1
        '
        Me.txtBillAddressLine1.Location = New System.Drawing.Point(404, 217)
        Me.txtBillAddressLine1.Name = "txtBillAddressLine1"
        Me.txtBillAddressLine1.Size = New System.Drawing.Size(128, 20)
        Me.txtBillAddressLine1.TabIndex = 28
        '
        'lblBillAddressLine1
        '
        Me.lblBillAddressLine1.AutoSize = True
        Me.lblBillAddressLine1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblBillAddressLine1.Location = New System.Drawing.Point(293, 219)
        Me.lblBillAddressLine1.Name = "lblBillAddressLine1"
        Me.lblBillAddressLine1.Size = New System.Drawing.Size(105, 18)
        Me.lblBillAddressLine1.TabIndex = 27
        Me.lblBillAddressLine1.Text = "Address Line 1"
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipping.Location = New System.Drawing.Point(131, 184)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(85, 24)
        Me.lblShipping.TabIndex = 37
        Me.lblShipping.Text = "Shipping"
        '
        'lblBilling
        '
        Me.lblBilling.AutoSize = True
        Me.lblBilling.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBilling.Location = New System.Drawing.Point(400, 184)
        Me.lblBilling.Name = "lblBilling"
        Me.lblBilling.Size = New System.Drawing.Size(60, 24)
        Me.lblBilling.TabIndex = 38
        Me.lblBilling.Text = "Billing"
        '
        'lblExVAT
        '
        Me.lblExVAT.AutoSize = True
        Me.lblExVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExVAT.Location = New System.Drawing.Point(59, 436)
        Me.lblExVAT.Name = "lblExVAT"
        Me.lblExVAT.Size = New System.Drawing.Size(101, 20)
        Me.lblExVAT.TabIndex = 39
        Me.lblExVAT.Text = "Price ExVAT:"
        '
        'lblVAT
        '
        Me.lblVAT.AutoSize = True
        Me.lblVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVAT.Location = New System.Drawing.Point(116, 466)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(44, 20)
        Me.lblVAT.TabIndex = 40
        Me.lblVAT.Text = "VAT:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(104, 496)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(56, 24)
        Me.lblTotal.TabIndex = 41
        Me.lblTotal.Text = "Total:"
        '
        'lblExVATValue
        '
        Me.lblExVATValue.AutoSize = True
        Me.lblExVATValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExVATValue.Location = New System.Drawing.Point(166, 436)
        Me.lblExVATValue.Name = "lblExVATValue"
        Me.lblExVATValue.Size = New System.Drawing.Size(18, 20)
        Me.lblExVATValue.TabIndex = 42
        Me.lblExVATValue.Text = "£"
        '
        'lblVATValue
        '
        Me.lblVATValue.AutoSize = True
        Me.lblVATValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVATValue.Location = New System.Drawing.Point(166, 466)
        Me.lblVATValue.Name = "lblVATValue"
        Me.lblVATValue.Size = New System.Drawing.Size(18, 20)
        Me.lblVATValue.TabIndex = 43
        Me.lblVATValue.Text = "£"
        '
        'lblTotalValue
        '
        Me.lblTotalValue.AutoSize = True
        Me.lblTotalValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalValue.Location = New System.Drawing.Point(166, 496)
        Me.lblTotalValue.Name = "lblTotalValue"
        Me.lblTotalValue.Size = New System.Drawing.Size(20, 24)
        Me.lblTotalValue.TabIndex = 44
        Me.lblTotalValue.Text = "£"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(754, 167)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(71, 23)
        Me.btnDelete.TabIndex = 46
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'tblItems
        '
        Me.tblItems.BackColor = System.Drawing.Color.Gainsboro
        Me.tblItems.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tblItems.ColumnCount = 3
        Me.tblItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tblItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tblItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.tblItems.Controls.Add(Me.lblPartNumberTbl, 0, 0)
        Me.tblItems.Controls.Add(Me.lblQuantityTbl, 1, 0)
        Me.tblItems.Controls.Add(Me.lblPriceTbl, 2, 0)
        Me.tblItems.Location = New System.Drawing.Point(602, 217)
        Me.tblItems.Name = "tblItems"
        Me.tblItems.RowCount = 2
        Me.tblItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblItems.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblItems.Size = New System.Drawing.Size(270, 204)
        Me.tblItems.TabIndex = 47
        '
        'lblPartNumberTbl
        '
        Me.lblPartNumberTbl.AutoSize = True
        Me.lblPartNumberTbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartNumberTbl.Location = New System.Drawing.Point(4, 1)
        Me.lblPartNumberTbl.Name = "lblPartNumberTbl"
        Me.lblPartNumberTbl.Size = New System.Drawing.Size(83, 16)
        Me.lblPartNumberTbl.TabIndex = 0
        Me.lblPartNumberTbl.Text = "Part Number"
        '
        'lblQuantityTbl
        '
        Me.lblQuantityTbl.AutoSize = True
        Me.lblQuantityTbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantityTbl.Location = New System.Drawing.Point(95, 1)
        Me.lblQuantityTbl.Name = "lblQuantityTbl"
        Me.lblQuantityTbl.Size = New System.Drawing.Size(56, 16)
        Me.lblQuantityTbl.TabIndex = 1
        Me.lblQuantityTbl.Text = "Quantity"
        '
        'lblPriceTbl
        '
        Me.lblPriceTbl.AutoSize = True
        Me.lblPriceTbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceTbl.Location = New System.Drawing.Point(186, 1)
        Me.lblPriceTbl.Name = "lblPriceTbl"
        Me.lblPriceTbl.Size = New System.Drawing.Size(39, 16)
        Me.lblPriceTbl.TabIndex = 2
        Me.lblPriceTbl.Text = "Price"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(677, 167)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(71, 23)
        Me.btnAdd.TabIndex = 45
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtPartNumber
        '
        Me.txtPartNumber.Location = New System.Drawing.Point(697, 85)
        Me.txtPartNumber.Name = "txtPartNumber"
        Me.txtPartNumber.Size = New System.Drawing.Size(128, 20)
        Me.txtPartNumber.TabIndex = 48
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(697, 111)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(128, 20)
        Me.txtQuantity.TabIndex = 49
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(697, 137)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(128, 20)
        Me.txtPrice.TabIndex = 50
        '
        'lblPartNumber
        '
        Me.lblPartNumber.AutoSize = True
        Me.lblPartNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblPartNumber.Location = New System.Drawing.Point(599, 87)
        Me.lblPartNumber.Name = "lblPartNumber"
        Me.lblPartNumber.Size = New System.Drawing.Size(92, 18)
        Me.lblPartNumber.TabIndex = 51
        Me.lblPartNumber.Text = "Part Number"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblQuantity.Location = New System.Drawing.Point(629, 113)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(62, 18)
        Me.lblQuantity.TabIndex = 52
        Me.lblQuantity.Text = "Quantity"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblPrice.Location = New System.Drawing.Point(568, 139)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(123, 18)
        Me.lblPrice.TabIndex = 53
        Me.lblPrice.Text = "ExVAT Per Item £"
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(598, 54)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(54, 24)
        Me.lblItems.TabIndex = 54
        Me.lblItems.Text = "Items"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(816, 489)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(89, 43)
        Me.btnSubmit.TabIndex = 55
        Me.btnSubmit.Text = "Submit Order"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(721, 489)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 43)
        Me.btnCancel.TabIndex = 56
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'NewOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 563)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblPartNumber)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtPartNumber)
        Me.Controls.Add(Me.tblItems)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblTotalValue)
        Me.Controls.Add(Me.lblVATValue)
        Me.Controls.Add(Me.lblExVATValue)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblVAT)
        Me.Controls.Add(Me.lblExVAT)
        Me.Controls.Add(Me.lblBilling)
        Me.Controls.Add(Me.lblShipping)
        Me.Controls.Add(Me.txtBillCountry)
        Me.Controls.Add(Me.lblBillCountry)
        Me.Controls.Add(Me.txtBillPostCode)
        Me.Controls.Add(Me.lblBillPostCode)
        Me.Controls.Add(Me.txtBillTownCity)
        Me.Controls.Add(Me.lblBillTownCity)
        Me.Controls.Add(Me.txtBillAddressLine2)
        Me.Controls.Add(Me.lblBillAddressLine2)
        Me.Controls.Add(Me.txtBillAddressLine1)
        Me.Controls.Add(Me.lblBillAddressLine1)
        Me.Controls.Add(Me.txtShipCountry)
        Me.Controls.Add(Me.lblShipCountry)
        Me.Controls.Add(Me.txtShipPostCode)
        Me.Controls.Add(Me.lblShipPostCode)
        Me.Controls.Add(Me.txtShipTownCity)
        Me.Controls.Add(Me.lblShipTownCity)
        Me.Controls.Add(Me.txtShipAddressLine2)
        Me.Controls.Add(Me.lblShipAddressLine2)
        Me.Controls.Add(Me.lblSame)
        Me.Controls.Add(Me.cbxSame)
        Me.Controls.Add(Me.txtShipAddressLine1)
        Me.Controls.Add(Me.lblShipAddressLine1)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtCompanyID)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.lblCompanyID)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.lblOrderID)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.lblNewOrderTitle)
        Me.Name = "NewOrder"
        Me.Text = "New Order"
        Me.tblItems.ResumeLayout(False)
        Me.tblItems.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNewOrderTitle As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents lblOrderID As Label
    Friend WithEvents txtCompanyID As TextBox
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents lblCompanyID As Label
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents lblNotes As Label
    Friend WithEvents txtShipAddressLine1 As TextBox
    Friend WithEvents lblShipAddressLine1 As Label
    Friend WithEvents cbxSame As CheckBox
    Friend WithEvents lblSame As Label
    Friend WithEvents txtShipAddressLine2 As TextBox
    Friend WithEvents lblShipAddressLine2 As Label
    Friend WithEvents txtShipTownCity As TextBox
    Friend WithEvents lblShipTownCity As Label
    Friend WithEvents txtShipPostCode As TextBox
    Friend WithEvents lblShipPostCode As Label
    Friend WithEvents txtShipCountry As TextBox
    Friend WithEvents lblShipCountry As Label
    Friend WithEvents txtBillCountry As TextBox
    Friend WithEvents lblBillCountry As Label
    Friend WithEvents txtBillPostCode As TextBox
    Friend WithEvents lblBillPostCode As Label
    Friend WithEvents txtBillTownCity As TextBox
    Friend WithEvents lblBillTownCity As Label
    Friend WithEvents txtBillAddressLine2 As TextBox
    Friend WithEvents lblBillAddressLine2 As Label
    Friend WithEvents txtBillAddressLine1 As TextBox
    Friend WithEvents lblBillAddressLine1 As Label
    Friend WithEvents lblShipping As Label
    Friend WithEvents lblBilling As Label
    Friend WithEvents lblExVAT As Label
    Friend WithEvents lblVAT As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblExVATValue As Label
    Friend WithEvents lblVATValue As Label
    Friend WithEvents lblTotalValue As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents tblItems As TableLayoutPanel
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtPartNumber As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPartNumber As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblItems As Label
    Friend WithEvents lblPartNumberTbl As Label
    Friend WithEvents lblQuantityTbl As Label
    Friend WithEvents lblPriceTbl As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
End Class
