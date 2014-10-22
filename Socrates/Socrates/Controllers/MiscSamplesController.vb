Imports System.Web.Mvc

Public Class MiscSamplesController
    Inherits Controller

    ' GET: /MiscSamples
    Function Index() As ActionResult
        Return View()
    End Function

    ' Example: Child Actions & Partial Views #1: Simple Menu Example
    <ChildActionOnly>
    Function Menu(coords As MenuCoordinates) As ActionResult
        Return PartialView("_MenuPartial", coords)
    End Function

    ' Example: Filters #1: Output Caching
    <OutputCache(Duration:=60)>
    Function OutputCache() As ActionResult
        Return View()
    End Function

    ' Example: Filters #2: HandleError Filter
    ' Apress Pro MVC 5 Book Page 488 for list of Filter Types
    ' Note: Need to add customErrors mode="On" to Web.Config
    ' Note: Need to run without debugging Ctrl-F5
    <HandleError(View:="Error")>
    Function CreateError() As ActionResult
        Throw New Exception("Boom in MiscSamples/CreateError")
        Return Content("No Error")
    End Function
End Class

Public Class MenuCoordinates
    Public Property Height As Integer
    Public Property Width As Integer
    Public Property X As Integer
    Public Property Y As Integer

End Class