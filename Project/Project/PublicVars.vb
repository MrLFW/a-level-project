Imports System.IO.File
Imports System.IO
Module PublicVars
    Public username As String

    Public linecountP As Integer = ReadAllLines("People.txt").Length
    Public linecountO As Integer = ReadAllLines("Orders.txt").Length
    Public linecountS As Integer = ReadAllLines("Stock.txt").Length

    Public accessLevel As String

    Public selectedCustomerID As String
    Public selectedOrderID As String

    Public checkedColumnPeople As New List(Of RadioButton)

    Public pcustomerNameColumn(linecountP), pemailColumn(linecountP), pphoneNumberColumn(linecountP), passociatedCompanyColumn(linecountP), pdateCreatedColumn(linecountP), pcustomerIDColumn(linecountP), pnotesColumn(linecountP) As Label
    Public fullNameL(linecountO), customerIDL(linecountO), companyNameL(linecountO), orderIDL(linecountO), orderDateL(linecountO), notesL(linecountO), ShipAddressLine1L(linecountO), ShipAddressLine2L(linecountO), ShipTownCityL(linecountO), ShipPostCodeL(linecountO), ShipCountryL(linecountO), BillAddressLine1L(linecountO), BillAddressLine2L(linecountO), BillTownCityL(linecountO), BillPostCodeL(linecountO), BillCountryL(linecountO), totalPriceL(linecountO) As Label
    Public partNoA(linecountS), descriptionA(linecountS), ExVATPriceA(linecountS), quantityA(linecountS) As Label
    'this module contains all the needed public variables
End Module
