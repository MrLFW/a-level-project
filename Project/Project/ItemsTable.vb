Imports System.IO.File
Imports System.IO
Module ItemsTable
    Sub LoadTableItems()

        Dim lblPartNumber As New Label()
        Dim lblQuantity As New Label()
        Dim lblExVAT As New Label()
        Dim lblVAT As New Label()
        Dim lblTotal As New Label()

        lblPartNumber.AutoSize = True
        lblPartNumber.Name = "lblPartNumber"
        lblPartNumber.Text = "Part Number"
        lblPartNumber.Font = New Font("Microsoft Sans Serif", 10)

        lblQuantity.AutoSize = True
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Text = "Quantity"
        lblQuantity.Font = New Font("Microsoft Sans Serif", 10)

        lblExVAT.AutoSize = True
        lblExVAT.Name = "lblExVAT"
        lblExVAT.Text = "ExVAT Per Item (£)"
        lblExVAT.Font = New Font("Microsoft Sans Serif", 10)

        lblVAT.AutoSize = True
        lblVAT.Name = "lblVAT"
        lblVAT.Text = "VAT Per Item (£)"
        lblVAT.Font = New Font("Microsoft Sans Serif", 10)

        lblTotal.AutoSize = True
        lblTotal.Name = "lblTotal"
        lblTotal.Text = "Total Per Item (£)"
        lblTotal.Font = New Font("Microsoft Sans Serif", 10)

        Main.tblItems.SuspendLayout()
        Main.tblItems.Controls.Add(lblPartNumber, 0, 0)
        Main.tblItems.Controls.Add(lblQuantity, 1, 0)
        Main.tblItems.Controls.Add(lblExVAT, 2, 0)
        Main.tblItems.Controls.Add(lblVAT, 3, 0)
        Main.tblItems.Controls.Add(lblTotal, 4, 0)
        Main.tblItems.ResumeLayout() 'this adds the headers to the items table
    End Sub
    Sub FillTableItems()

        ResetTableItems()
        selectedOrderID = Main.txtSearchOrderID.Text
        Dim lineCountI As Integer = ReadAllLines(selectedOrderID & ".txt").Length
        FileOpen(5, selectedOrderID & ".txt", OpenMode.Input)
        Main.tblItems.SuspendLayout()
        For i As Integer = 0 To lineCountI - 1
            Dim lblPartNumber As New Label
            Dim lblQuantity As New Label
            Dim lblTotal As New Label
            Dim lblVAT As New Label
            Dim lblExVATPerItem As New Label

            Dim lblPartNumberL(lineCountI) As Label
            Dim lblQuantityL(lineCountI) As Label
            Dim lblTotalL(lineCountI) As Label
            Dim lblVATL(lineCountI) As Label
            Dim lblExVATPerItemL(lineCountI) As Label

            lblPartNumberL(i) = lblPartNumber
            lblQuantityL(i) = lblQuantity
            lblTotalL(i) = lblTotal
            lblVATL(i) = lblVAT
            lblExVATPerItemL(i) = lblExVATPerItem

            Input(5, lblPartNumber.Text)
            Input(5, lblQuantity.Text)
            Input(5, lblExVATPerItem.Text)

            lblPartNumber.Name = "lblPartNumber" & i.ToString
            lblQuantity.Name = "lblQuantity" & i.ToString
            lblTotal.Name = "lblTotal" & i.ToString
            lblVAT.Name = "lblVAT" & i.ToString
            lblExVATPerItem.Name = "lblExVATPerItem" & i.ToString

            lblPartNumber.AutoSize = True
            lblQuantity.AutoSize = True
            lblTotal.AutoSize = True
            lblVAT.AutoSize = True
            lblExVATPerItem.AutoSize = True

            ExVAT = CInt(lblExVATPerItem.Text)
            VAT = ExVAT * 0.2
            total = VAT + ExVAT
            lblVAT.Text = VAT
            lblTotal.Text = total

            Main.tblItems.GrowStyle = TableLayoutPanelGrowStyle.AddRows
            Main.tblPeople.RowStyles.Add(New RowStyle(SizeType.Absolute, 30))
            Main.tblItems.RowCount += 1
            Main.tblItems.Controls.Add(lblPartNumberL(i), 0, Main.tblItems.RowCount - 1)
            Main.tblItems.Controls.Add(lblQuantityL(i), 1, Main.tblItems.RowCount - 1)
            Main.tblItems.Controls.Add(lblExVATPerItemL(i), 2, Main.tblItems.RowCount - 1)
            Main.tblItems.Controls.Add(lblVATL(i), 3, Main.tblItems.RowCount - 1)
            Main.tblItems.Controls.Add(lblTotalL(i), 4, Main.tblItems.RowCount - 1) 'this fills the table with the contents of an order's items

        Next i

        Main.tblItems.ResumeLayout()

        FileClose()
    End Sub
    Sub ResetTableItems()
        Main.tblItems.Controls.Clear()
        Main.tblItems.RowCount = 1
        LoadTableItems()
    End Sub
End Module
