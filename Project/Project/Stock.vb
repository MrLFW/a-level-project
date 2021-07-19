Imports System.IO.File
Imports System.IO
Module Stock
    Dim partNo, description As String
    Dim ExVATPrice As Single
    Dim quantity As Integer
    Public found As Boolean = False
    Sub FillTableStock()

        Main.tblStock.RowStyles(0) = New RowStyle(SizeType.Absolute, 35)

        FileOpen(3, "Stock.txt", OpenMode.Input)
        partNo = ""
        description = ""
        ExVATPrice = 0
        quantity = 0

        Main.tblStock.SuspendLayout()
        For i As Integer = 0 To linecountS - 1

            Dim partNoL, descriptionL, ExVATPriceL, quantityL As New Label

            partNoA(i) = partNoL
            descriptionA(i) = descriptionL
            ExVATPriceA(i) = ExVATPriceL
            quantityA(i) = quantityL

            Input(3, partNo)
            Input(3, description)
            Input(3, ExVATPrice)
            Input(3, quantity)

            partNoL.Text = partNo
            descriptionL.Text = description
            ExVATPriceL.Text = ExVATPrice
            quantityL.Text = quantity

            partNoL.Name = "partNoL" & linecountS.ToString
            partNoL.AutoSize = True
            partNoL.Font = New Font("Microsoft Sans Serif", 15.0)
            partNoL.AutoSize = True

            descriptionL.Name = "descriptionL" & linecountS.ToString
            descriptionL.AutoSize = True
            descriptionL.Font = New Font("Microsoft Sans Serif", 15.0)
            descriptionL.AutoSize = True

            ExVATPriceL.Name = "ExVATPriceL" & linecountS.ToString
            ExVATPriceL.AutoSize = True
            ExVATPriceL.Font = New Font("Microsoft Sans Serif", 15.0)
            ExVATPriceL.AutoSize = True

            quantityL.Name = "quantityL" & linecountS.ToString
            quantityL.AutoSize = True
            quantityL.Font = New Font("Microsoft Sans Serif", 15.0)
            quantityL.AutoSize = True

            Main.tblStock.GrowStyle = TableLayoutPanelGrowStyle.AddRows
            Main.tblStock.RowStyles.Add(New RowStyle(SizeType.AutoSize))

            Main.tblStock.RowCount += 1
            Main.tblStock.Controls.Add(partNoA(i), 0, Main.tblStock.RowCount - 1)
            Main.tblStock.Controls.Add(descriptionA(i), 1, Main.tblStock.RowCount - 1) 'this sub takes all the stock from the stock file and fills the table up on the stock tab
            Main.tblStock.Controls.Add(ExVATPriceA(i), 2, Main.tblStock.RowCount - 1)
            Main.tblStock.Controls.Add(quantityA(i), 3, Main.tblStock.RowCount - 1)

        Next
        Main.tblStock.ResumeLayout()
        FileClose(3)
    End Sub
    Sub AppendTableStock()
        Dim valid As Boolean = True

        Try
            Dim exvattest As Single = CSng(Main.txtExVAT1.Text)
            Dim qtest As Integer = CInt(Main.txtQuantity1.Text)

        Catch ex As ArithmeticException
            valid = False
            FileClose(4)
            MsgBox("Value is too large")
        End Try

        If IsNumeric(Main.txtExVAT1.Text) = True And IsNumeric(Main.txtQuantity1.Text) = True Then

            Dim partNoL, descriptionL, ExVATPriceL, quantityL As New Label
            FileOpen(4, "Stock.txt", OpenMode.Append)
            Write(4, Main.txtPartNumber1.Text)
            Write(4, Main.txtDescription1.Text)
            Write(4, CSng(Main.txtExVAT1.Text))
            WriteLine(4, CInt(Main.txtQuantity1.Text))
            FileClose(4)
            Dim lineCount As Integer = ReadAllLines("Stock.txt").Length

            partNoL.Text = Main.txtPartNumber1.Text
            descriptionL.Text = Main.txtDescription1.Text
            ExVATPriceL.Text = Main.txtExVAT1.Text
            quantityL.Text = Main.txtQuantity1.Text

            partNoL.Name = "partNoL" & lineCount.ToString
            descriptionL.Name = "descriptionL" & lineCount.ToString
            ExVATPriceL.Name = "ExVATPriceL" & lineCount.ToString
            quantityL.Name = "quantityL" & lineCount.ToString

            partNoL.AutoSize = True
            descriptionL.AutoSize = True
            ExVATPriceL.AutoSize = True
            quantityL.AutoSize = True

            partNoL.Font = New Font("Microsoft Sans Serif", 15.0)
            descriptionL.Font = New Font("Microsoft Sans Serif", 15.0)
            ExVATPriceL.Font = New Font("Microsoft Sans Serif", 15.0)
            quantityL.Font = New Font("Microsoft Sans Serif", 15.0)

            Main.tblStock.GrowStyle = TableLayoutPanelGrowStyle.AddRows
            Main.tblStock.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            Main.tblStock.RowCount += 1

            Main.tblStock.SuspendLayout()

            Main.tblStock.Controls.Add(partNoL, 0, Main.tblStock.RowCount - 1)
            Main.tblStock.Controls.Add(descriptionL, 1, Main.tblStock.RowCount - 1) 'this sub adds new stock to the table and saves the new stock to the text file
            Main.tblStock.Controls.Add(ExVATPriceL, 2, Main.tblStock.RowCount - 1)
            Main.tblStock.Controls.Add(quantityL, 3, Main.tblStock.RowCount - 1)

            Main.tblStock.ResumeLayout()
        Else
            MsgBox("Price and quantity must be numerical")
        End If

    End Sub
    Sub fillPanelStock()
        Dim partNo1, description1 As String
        Dim ExVATPrice1 As Single
        Dim quantity1 As Integer
        Main.lblPartNoFound.Visible = True
        FileOpen(6, "Stock.txt", OpenMode.Input)
        Main.panelEditDelete.SuspendLayout()
        Dim i As Integer = 0
        While Not EOF(6)
            i += 1
            Input(6, partNo1)
            Input(6, description1)
            Input(6, ExVATPrice1)
            Input(6, quantity1)
            If Main.txtSearchPartNo.Text = partNo1 Then 'when an item is searched for, this sub is called and it fills the text boxes with the items data
                Main.txtNewPartNo.Text = partNo1
                Main.txtDescription2.Text = description1
                Main.txtExVAT2.Text = ExVATPrice1
                Main.txtQuantity2.Text = quantity1
                found = True
                Main.lblPartNoFound.Visible = False
                Exit While
            End If
        End While
        If found = False Then
            Main.lblPartNoFound.Visible = True
        End If
        found = False
        FileClose(6)
    End Sub
    Sub EditStock()
        Dim stockRow As Integer
        Dim validPartNoSearch As Boolean = True
        Dim validPrice As Boolean = False
        Dim validQuantity As Boolean = False

        For i As Integer = 1 To Main.tblStock.RowCount - 1
            If Main.txtSearchPartNo.Text = Main.tblStock.GetControlFromPosition(0, i).Text Then
                stockRow = i
                validPartNoSearch = True
                Exit For
            Else
                validPartNoSearch = False
            End If
        Next
        If IsNumeric(Main.txtExVAT2.Text) = True Then
            validPrice = True
        Else
            validPrice = False
            MsgBox("Invalid price")
        End If
        If IsNumeric(Main.txtQuantity2.Text) = True Then
            validQuantity = True
        Else
            validQuantity = False
            MsgBox("Invalid Quantity")
        End If
        If validPartNoSearch = True And validPrice = True And validQuantity = True Then

            Main.tblStock.GetControlFromPosition(0, stockRow).Text = Main.txtNewPartNo.Text
            Main.tblStock.GetControlFromPosition(1, stockRow).Text = Main.txtDescription2.Text 'this sub saves the new edits on an item of stock
            Main.tblStock.GetControlFromPosition(2, stockRow).Text = Main.txtExVAT2.Text
            Main.tblStock.GetControlFromPosition(3, stockRow).Text = Main.txtQuantity2.Text

            IO.File.WriteAllText("Stock.txt", "")

            FileOpen(1, "Stock.txt", OpenMode.Append)
            For i = 1 To Main.tblStock.RowCount - 1
                Write(1, Main.tblStock.GetControlFromPosition(0, i).Text)
                Write(1, Main.tblStock.GetControlFromPosition(1, i).Text)
                Write(1, CSng(Main.tblStock.GetControlFromPosition(2, i).Text))
                WriteLine(1, CInt(Main.tblStock.GetControlFromPosition(3, i).Text))
            Next
            FileClose(1)
        ElseIf validPartNoSearch = False Then
            MsgBox("Please enter a valid part number")
        End If

    End Sub
    Sub DeleteStock()


        Dim stockRow As Integer
        Dim validPartNoSearch As Boolean = True
        For i As Integer = 1 To Main.tblStock.RowCount - 1
            If Main.txtSearchPartNo.Text = Main.tblStock.GetControlFromPosition(0, i).Text Then
                stockRow = i
                validPartNoSearch = True
                Exit For
            Else
                validPartNoSearch = False
            End If
        Next

        If validPartNoSearch = True Then
            Main.tblStock.SuspendLayout()

            Dim delLine As Integer = stockRow
            Dim lines As List(Of String) = ReadAllLines("Stock.txt").ToList
            lines.RemoveAt(delLine - 1) ' index starts at 0 
            WriteAllLines("Stock.txt", lines)

            For i As Integer = 0 To Main.tblStock.ColumnCount - 1
                Main.tblStock.Controls.Remove(Main.tblStock.GetControlFromPosition(i, stockRow))
            Next

            For i As Integer = stockRow To Main.tblStock.RowCount - 1

                For j As Integer = 0 To Main.tblStock.ColumnCount - 1
                    Dim control = Main.tblStock.GetControlFromPosition(j, i)

                    If control IsNot Nothing Then
                        Main.tblStock.SetRow(control, i - 1)
                    End If
                Next
            Next

            Dim removeStyle = Main.tblStock.RowCount - 1
            If Main.tblStock.RowStyles.Count > removeStyle Then Main.tblStock.RowStyles.RemoveAt(removeStyle) 'removes a selected row of the table by referencing the part number in the search box
            Main.tblStock.RowCount -= 1
            Main.tblStock.ResumeLayout()
        ElseIf validPartNoSearch = False Then
            MsgBox("Please enter a valid part number")
        End If
    End Sub
End Module
