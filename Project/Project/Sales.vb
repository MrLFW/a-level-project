Imports Word = Microsoft.Office.Interop.Word

Module Sales
    Sub LoadSalesPanel()
        Dim orderDateS As String = ""
        Dim orderDateA(11) As Date
        Dim orderDate As Date

        Dim orderTotal As Single = 0
        Dim orderTotalA(11) As Single

        Dim totalSales As Single
        FileOpen(1, "Orders.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, orderDateS)
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, orderTotal)
            totalSales += orderTotal

            orderDate = CDate(orderDateS)
            orderTotalA(orderDate.Month - 1) += orderTotal

        End While
        FileClose(1)

        Main.lblTotalSales.Text = "£" & totalSales
        Main.lblTotalProfit.Text = "£" & Math.Truncate(totalSales * 0.6)

        Main.lblMonthSales.Text = "£" & orderTotalA(Date.Today.Month - 1)
        Main.lblMonthProfit.Text = "£" & Math.Truncate(orderTotalA(Date.Today.Month - 1) * 0.6)

        Main.lblLastMonthSales.Text = "£" & orderTotalA(Date.Today.Month - 2)
        Main.lblLastMonthProfit.Text = "£" & Math.Truncate(orderTotalA(Date.Today.Month - 2) * 0.6) 'this calculates sales by taking data from the text file

    End Sub
    Sub CreatePickingList()

        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Dim oTable As Word.Table
        Dim oPara1 As Word.Paragraph, oPara2 As Word.Paragraph
        Dim oPara3 As Word.Paragraph, oPara4 As Word.Paragraph
        Dim oRng As Word.Range
        Dim oShape As Word.InlineShape
        Dim oChart As Object
        Dim Pos As Double

        'Start Word and open the document template.
        oWord = CreateObject("Word.Application")
        oWord.Visible = True
        oDoc = oWord.Documents.Add

        'Insert a paragraph at the beginning of the document.
        oPara1 = oDoc.Content.Paragraphs.Add
        oPara1.Range.Text = "Heading 1"
        oPara1.Range.Font.Bold = True
        oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
        oPara1.Range.InsertParagraphAfter()

        'Insert a paragraph at the end of the document.
        '** \endofdoc is a predefined bookmark.
        oPara2 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara2.Range.Text = "Heading 2"
        oPara2.Format.SpaceAfter = 6
        oPara2.Range.InsertParagraphAfter()

        'Insert another paragraph.
        oPara3 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara3.Range.Text = "This is a sentence of normal text. Now here is a table:"
        oPara3.Range.Font.Bold = False
        oPara3.Format.SpaceAfter = 24
        oPara3.Range.InsertParagraphAfter()

        'Insert a 3 x 5 table, fill it with data, and make the first row
        'bold and italic.
        Dim r As Integer, c As Integer
        oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 3, 5)
        oTable.Range.ParagraphFormat.SpaceAfter = 6
        For r = 1 To 3
            For c = 1 To 5
                oTable.Cell(r, c).Range.Text = "r" & r & "c" & c
            Next
        Next
        oTable.Rows.Item(1).Range.Font.Bold = True
        oTable.Rows.Item(1).Range.Font.Italic = True

        'Add some text after the table.
        'oTable.Range.InsertParagraphAfter()
        oPara4 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara4.Range.InsertParagraphBefore()
        oPara4.Range.Text = "And here's another table:"
        oPara4.Format.SpaceAfter = 24
        oPara4.Range.InsertParagraphAfter()

        'Insert a 5 x 2 table, fill it with data, and change the column widths.
        oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 5, 2)
        oTable.Range.ParagraphFormat.SpaceAfter = 6
        For r = 1 To 5
            For c = 1 To 2
                oTable.Cell(r, c).Range.Text = "r" & r & "c" & c
            Next
        Next
        oTable.Columns.Item(1).Width = oWord.InchesToPoints(2)   'Change width of columns 1 & 2
        oTable.Columns.Item(2).Width = oWord.InchesToPoints(3)

        'Keep inserting text. When you get to 7 inches from top of the
        'document, insert a hard page break.
        Pos = oWord.InchesToPoints(7)
        oDoc.Bookmarks.Item("\endofdoc").Range.InsertParagraphAfter()
        Do
            oRng = oDoc.Bookmarks.Item("\endofdoc").Range
            oRng.ParagraphFormat.SpaceAfter = 6
            oRng.InsertAfter("A line of text")
            oRng.InsertParagraphAfter()
        Loop While Pos >= oRng.Information(Word.WdInformation.wdVerticalPositionRelativeToPage)
        oRng.Collapse(Word.WdCollapseDirection.wdCollapseEnd)
        oRng.InsertBreak(Word.WdBreakType.wdPageBreak)
        oRng.Collapse(Word.WdCollapseDirection.wdCollapseEnd)
        oRng.InsertAfter("We're now on page 2. Here's my chart:")
        oRng.InsertParagraphAfter()

        'Insert a chart and change the chart.
        oShape = oDoc.Bookmarks.Item("\endofdoc").Range.InlineShapes.AddOLEObject(ClassType:="MSGraph.Chart.8", FileName:="", LinkToFile:=False, DisplayAsIcon:=False)
        oChart = oShape.OLEFormat.Object
        oChart.charttype = 4 'xlLine = 4
        oChart.Application.Update()
        oChart.Application.Quit()
        'If desired, you can proceed from here using the Microsoft Graph 
        'Object model on the oChart object to make additional changes to the
        'chart.
        oShape.Width = oWord.InchesToPoints(6.25)
        oShape.Height = oWord.InchesToPoints(3.57)

        'Add text after the chart.
        oRng = oDoc.Bookmarks.Item("\endofdoc").Range
        oRng.InsertParagraphAfter()
        oRng.InsertAfter("THE END.")

        'All done. Close this form.

    End Sub
    Sub LoadChart()
        Dim orderDateS As String = ""
        Dim orderDate As Date

        Dim orderTotal As Single = 0
        Dim orderTotalA(11) As Single
        FileOpen(1, "Orders.txt", OpenMode.Input)

        While Not EOF(1)
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, orderDateS)
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, "")
            Input(1, orderTotal)
            orderDate = CDate(orderDateS)
            orderTotalA(orderDate.Month - 1) += orderTotal
        End While
        FileClose(1)
        Main.chartMonth.Series("Sales").Points.AddXY("Jan", orderTotalA(0))
        Main.chartMonth.Series("Sales").Points.AddXY("Feb", orderTotalA(1))
        Main.chartMonth.Series("Sales").Points.AddXY("Mar", orderTotalA(2))
        Main.chartMonth.Series("Sales").Points.AddXY("Apr", orderTotalA(3))
        Main.chartMonth.Series("Sales").Points.AddXY("May", orderTotalA(4))
        Main.chartMonth.Series("Sales").Points.AddXY("Jun", orderTotalA(5))
        Main.chartMonth.Series("Sales").Points.AddXY("Jul", orderTotalA(6))
        Main.chartMonth.Series("Sales").Points.AddXY("Aug", orderTotalA(7))
        Main.chartMonth.Series("Sales").Points.AddXY("Sep", orderTotalA(8))
        Main.chartMonth.Series("Sales").Points.AddXY("Oct", orderTotalA(9))
        Main.chartMonth.Series("Sales").Points.AddXY("Nov", orderTotalA(10))
        Main.chartMonth.Series("Sales").Points.AddXY("Dec", orderTotalA(11))

        Main.chartMonth.Series("Profit").Points.AddXY("Jan", orderTotalA(0) * 0.6)
        Main.chartMonth.Series("Profit").Points.AddXY("Feb", orderTotalA(1) * 0.6)
        Main.chartMonth.Series("Profit").Points.AddXY("Mar", orderTotalA(2) * 0.6)
        Main.chartMonth.Series("Profit").Points.AddXY("Apr", orderTotalA(3) * 0.6)
        Main.chartMonth.Series("Profit").Points.AddXY("May", orderTotalA(4) * 0.6)
        Main.chartMonth.Series("Profit").Points.AddXY("Jun", orderTotalA(5) * 0.6)
        Main.chartMonth.Series("Profit").Points.AddXY("Jul", orderTotalA(6) * 0.6)
        Main.chartMonth.Series("Profit").Points.AddXY("Aug", orderTotalA(7) * 0.6)
        Main.chartMonth.Series("Profit").Points.AddXY("Sep", orderTotalA(8) * 0.6)
        Main.chartMonth.Series("Profit").Points.AddXY("Oct", orderTotalA(9) * 0.6)
        Main.chartMonth.Series("Profit").Points.AddXY("Nov", orderTotalA(10) * 0.6)
        Main.chartMonth.Series("Profit").Points.AddXY("Dec", orderTotalA(11) * 0.6) 'this sub creates the chart on the sales page

    End Sub
    Sub LoadTableOrders2()

        Dim lblCustomerName As New Label()
        Dim lblOrderID As New Label()
        Dim lblOrderDate As New Label()
        Dim lblAddressLine1 As New Label()
        Dim lblTownCity As New Label()
        Dim lblPostCode As New Label()
        Dim lblCountry As New Label()
        Dim lblNotes As New Label()
        Dim lblTotal As New Label()

        lblCustomerName.AutoSize = True
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Text = "Customer Name"
        lblCustomerName.Font = New Font("Microsoft Sans Serif", 10)

        lblOrderID.AutoSize = True
        lblOrderID.Name = "lblOrderID"
        lblOrderID.Text = "Order ID"
        lblOrderID.Font = New Font("Microsoft Sans Serif", 10)

        lblOrderDate.AutoSize = True
        lblOrderDate.Name = "lblOrderDate"
        lblOrderDate.Text = "Order Date"
        lblOrderDate.Font = New Font("Microsoft Sans Serif", 10)

        lblAddressLine1.AutoSize = True
        lblAddressLine1.Name = "lblAddressLine1"
        lblAddressLine1.Text = "Address Line 1"
        lblAddressLine1.Font = New Font("Microsoft Sans Serif", 10)

        lblTownCity.AutoSize = True
        lblTownCity.Name = "lblTownCity"
        lblTownCity.Text = "TownCity"
        lblTownCity.Font = New Font("Microsoft Sans Serif", 10)

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

        Main.tblOrders2.SuspendLayout()
        Main.tblOrders2.Controls.Add(lblCustomerName, 0, 0)
        Main.tblOrders2.Controls.Add(lblOrderID, 1, 0)
        Main.tblOrders2.Controls.Add(lblOrderDate, 2, 0)
        Main.tblOrders2.Controls.Add(lblAddressLine1, 3, 0) 'this creates the headers for the second orders table
        Main.tblOrders2.Controls.Add(lblTownCity, 4, 0)
        Main.tblOrders2.Controls.Add(lblPostCode, 5, 0)
        Main.tblOrders2.Controls.Add(lblCountry, 6, 0)
        Main.tblOrders2.Controls.Add(lblTotal, 7, 0)
        Main.tblOrders2.Controls.Add(lblNotes, 8, 0)
        Main.tblOrders2.ResumeLayout()
        FillOrdersTable2()
    End Sub
    Sub FillOrdersTable2()
        Dim linecountO As Integer = IO.File.ReadAllLines("Orders.txt").Length

        ResetTableOrders()
        FileOpen(1, "Orders.txt", OpenMode.Input)
        Main.tblOrders2.SuspendLayout()

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
            ShipAddressLine1.Name = "ShipAddressLine1" & i.ToString
            ShipTownCity.Name = "ShipTownCity" & i.ToString
            ShipPostCode.Name = "ShipPostCode" & i.ToString
            ShipCountry.Name = "ShipCountry" & i.ToString
            totalPrice.Name = "totalPrice" & i.ToString
            notes.Name = "notes" & i.ToString

            fullName.AutoSize = True
            orderID.AutoSize = True
            orderDate.AutoSize = True
            ShipAddressLine1.AutoSize = True
            ShipTownCity.AutoSize = True
            ShipPostCode.AutoSize = True
            ShipCountry.AutoSize = True
            totalPrice.AutoSize = True
            notes.AutoSize = True

            Main.tblOrders2.GrowStyle = TableLayoutPanelGrowStyle.AddRows
            Main.tblOrders2.RowStyles.Add(New RowStyle(SizeType.Absolute, 30))
            Main.tblOrders2.RowCount += 1
            Main.tblOrders2.Controls.Add(fullNameL(i), 0, Main.tblOrders2.RowCount - 1)
            Main.tblOrders2.Controls.Add(orderIDL(i), 1, Main.tblOrders2.RowCount - 1)
            Main.tblOrders2.Controls.Add(orderDateL(i), 2, Main.tblOrders2.RowCount - 1)
            Main.tblOrders2.Controls.Add(ShipAddressLine1L(i), 3, Main.tblOrders2.RowCount - 1) 'this fills the table with all the previous orders
            Main.tblOrders2.Controls.Add(ShipTownCityL(i), 4, Main.tblOrders2.RowCount - 1)
            Main.tblOrders2.Controls.Add(ShipPostCodeL(i), 5, Main.tblOrders2.RowCount - 1)
            Main.tblOrders2.Controls.Add(ShipCountryL(i), 6, Main.tblOrders2.RowCount - 1)
            Main.tblOrders2.Controls.Add(totalPriceL(i), 7, Main.tblOrders2.RowCount - 1)
            Main.tblOrders2.Controls.Add(notesL(i), 8, Main.tblOrders2.RowCount - 1)
        Next i
        Main.tblOrders2.ResumeLayout()

        FileClose()

    End Sub
End Module
