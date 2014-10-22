Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing
Imports System.Web.Mvc.Routing.Constraints

Public Module RouteConfig
    Public Sub RegisterRoutes(ByVal routes As RouteCollection)
        ' Default IgnoreRoute, do not attempt to route calls for .axd files
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

        ' Example: Routing #7: IgnoreRoute, do not attempt to route calls for images
        ' /images/logo         before IgnoreRoute short 404 error from ControllerFactory, after long 404 error from ASP.NET
        routes.IgnoreRoute("images/{*pathinfo}")

        ' Example: Routing #9: Outgoing Route
        ' Note: Do this example after View Examples with Hyperlinks
        'routes.MapRoute("OutgoingRoute", "{controller}Controller/{action}Action",
        '                New With {.controller = "Home", .action = "Students"})

        ' Example: Routing #1: Static Route
        ' /Static                   returns Hello from HomeController
        routes.MapRoute(name:="StaticRoute", url:="Static",
                        defaults:=New With {.controller = "Home", .action = "StaticRoute"})

        ' Example: Routing #2: Static Route with message parameter
        ' /Static?message=Hi
        ' /Static/Hi                returns Hi from HomeController
        ' /Static/Hola              returns Hola from HomeController
        routes.MapRoute(name:="StaticRouteWithMessage", url:="Static/{Message}",
                        defaults:=New With {.controller = "Home", .action = "StaticRouteWithMessage"})

        ' Example: Routing #3: Static Route with message parameter and default
        ' Note: Need a different URL otherwise the previous 2 routes block this one
        ' /Static2                  returns Hi
        routes.MapRoute(name:="StaticRouteWithMessageDefault", url:="Static2/{Message}",
                        defaults:=New With {.controller = "Home", .action = "StaticRouteWithMessage",
                                            .Message = "Hi"})

        ' Example: Routing #4: Route with RegEx Constraint, message must be at least 2 characters long
        ' /RegExConstraint/H        doesn't work
        ' /RegExConstraint/Hi       does
        routes.MapRoute(name:="RegExRouteConstraint", url:="RegExConstraint/{Message}",
                        defaults:=New With {.controller = "Home", .action = "StaticRouteWithMessage",
                                            .Message = "Hi"},
                        constraints:=New With {.Message = ".{2,}"})

        ' Example: Routing #5: Route with Custom Route Constraint, message must be at least 2 characters long
        ' See Private Class MessageConstraint below
        ' /CustomConstraint/H       doesn't work
        ' /CustomConstraint/Hi      does
        routes.MapRoute(name:="CustomRouteConstraint", url:="CustomConstraint/{Message}",
                        defaults:=New With {.controller = "Home", .action = "StaticRouteWithMessage",
                                            .Message = "Hi"},
                        constraints:=New With {.Message = New MessageRouteConstraint})

        ' Example: Routing #6: Route with Constraint Classes, message must be at least 2 characters long
        ' Apress Pro MVC 5 Book Page 403 for list of RouteConstraint Classes
        ' /RouteConstraintClass/H       doesn't work
        ' /RouteConstraintClass/Hi      does
        routes.MapRoute(name:="RouteConstraintClass", url:="RouteConstraintClass/{Message}",
                        defaults:=New With {.controller = "Home", .action = "StaticRouteWithMessage",
                                            .Message = "Hi"},
                        constraints:=New With {.Message = New MinLengthRouteConstraint(2)})

        ' /RouteConstraintClass2/H       doesn't work
        ' /RouteConstraintClass2/Hi      does
        ' /RouteConstraintClass2/11      doesn't work
        routes.MapRoute(name:="RouteConstraintClass2", url:="RouteConstraintClass2/{Message}",
                        defaults:=New With {.controller = "Home", .action = "StaticRouteWithMessage",
                                            .Message = "Hi"},
                        constraints:=New With {.Message = New CompoundRouteConstraint(
                            New IRouteConstraint() {New AlphaRouteConstraint(),
                                                    New MinLengthRouteConstraint(2)})})

        ' Default Route
        routes.MapRoute(
            name:="Default",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional},
            namespaces:={"Socrates"}
        )

        ' Example: Routing #8: CatchAll
        routes.MapRoute(
            name:="CatchAll",
            url:="{controller}/{action}/{*id}",
            defaults:=New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional}
        )
    End Sub

    ' Example: Routing #5: Custom Route Constraint Class
    Private Class MessageRouteConstraint
        Implements IRouteConstraint

        Public Function Match(httpContext As HttpContextBase, route As Route,
                              parameterName As String, values As RouteValueDictionary,
                              routeDirection As RouteDirection) As Boolean Implements IRouteConstraint.Match
            If routeDirection = routeDirection.IncomingRequest Then
                Dim message As String = values("Message")
                Return (message IsNot Nothing AndAlso message.Length >= 2)
            End If
            Return True
        End Function
    End Class

End Module