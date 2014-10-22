Imports System.Web.Mvc
Imports System.Collections.Generic

Public Class HomeController
    Inherits Controller

    ' GET: /Home
    Function Index() As ActionResult
        ' Example: View #3: Use ViewBag to Send a Title to View
        ViewBag.Title = "Socrates Home Page"
        ViewBag.PageTitle = "Welcome to Socrates"

        ' Example: View #1: Add View for Home Index Action
        ' Note: Before Adding View, right click in Action code and try to Go to View, error
        Return View()
    End Function

    ' Example: Authentication #1: Add Authorize Filter where needed
    ' Note: Add code to Index and Students view to display User
    ' Note: See Web.Config for Authentication Mode="Windows"
    ' Note: Solution Explorer, Click on Project, F4 for Properties Window, turn on Windows Authentication
    <Authorize(Users:="GeekTop00\Geek")>
    Function Students() As ViewResult
        ' Example: View #7: Use a Simple Model to Send Data to View
        ' See Students.vbhmtl for more Examples
        Dim studentNames As New List(Of String) From _
            {"Fred Flintstone", "Barney Rubble", "Pebbles Flintstone", "BamBam Rubble"}
        Return View(studentNames)
    End Function



    ' Example: Routing #1: Static Route 
    Function StaticRoute() As String
        Return "Hello from HomeController"
    End Function

    ' Example: Routing #2 - #5: Static Route with message parameter 
    ' Note: You can't overload Action Methods, they become ambiguous but can use Verbs <HttpGet> or <HttpPost>
    Function StaticRouteWithMessage(message As String) As String
        Return message & " from HomeController"
    End Function

    ' Example: Routing #7: Displaying Routing Data
    ' /Home/ShowRouteData           displays routing info (uses default route)
    Function ShowRouteData() As String
        ' Note:  Adding <br> tags bad, should be in a View
        Dim results As String = CType(RouteData.Route, System.Web.Routing.Route).Url & "<br>"
        For Each item In RouteData.Values
            results &= String.Format("{0} = {1}<br>", item.Key, item.Value)
        Next
        results &= String.Format("Useragent = {0}<br>", Request.UserAgent)
        results &= String.Format("Browser = {0}<br>", Request.Browser.Type)
        results &= String.Format("Browser Version = {0}<br>", Request.Browser.Version)
        Return results
    End Function



    ' Example: Controller #1: Return ContentResult
    ' Apress Pro MVC 5 Book Page 403 for list of RouteConstraint Classes
    ' /Home/ContentAction   or /HomeContextAction/Hi           
    Function ContentAction(id As String) As ActionResult ' or As ContentResult
        Return New ContentResult With {
            .ContentType = "text/plain",
            .Content = String.Format("ID = {0}", id)
        }
    End Function

    ' Example: Controller #2: Return ContentResult using Content Convenience Method
    ' /Home/ContentAction2  or /HomeContextAction2/Hi           
    Function ContentAction2(id As String) As ActionResult ' or As ContentResult
        Return Content(String.Format("ID = {0}", id))
    End Function

    ' Example: Controller #3: Return JsonResult using Json Convenience Method
    ' /Home/JsonAction      or /JsonAction/Hi           
    Function JsonAction(id As String) As ActionResult ' or As JsonResult
        Return Json(New With {.FirstName = "John", .LastName = "Doe", .id = id},
                    JsonRequestBehavior.AllowGet) ' Try without this Property first, get Error
    End Function

End Class

