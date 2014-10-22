Imports System.Web.Mvc

Namespace Areas.Area54
    Public Class Area54AreaRegistration
        Inherits AreaRegistration

        Public Overrides ReadOnly Property AreaName() As String
            Get
                Return "Area54"
            End Get
        End Property

        Public Overrides Sub RegisterArea(ByVal context As AreaRegistrationContext)
            context.MapRoute(
                "Area54_default",
                "Area54/{controller}/{action}/{id}",
                New With {.action = "Index", .id = UrlParameter.Optional},
                Nothing, {"Socrates.Areas.Area54"}
            )
        End Sub
    End Class
End Namespace