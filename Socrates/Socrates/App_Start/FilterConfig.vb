Imports System.Web.Mvc

' Example: Filters #3: Global Filters
Module FilterConfig
    Public Sub RegisterGlobalFilters(filters As GlobalFilterCollection)
        filters.Add(New HandleErrorAttribute With {.View = "Error"})
    End Sub
End Module
