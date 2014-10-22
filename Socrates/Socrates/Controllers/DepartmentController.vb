'Example: Models #5: Add DepartmentController Empty
Imports System.Web.Mvc

Public Class DepartmentController
    Inherits Controller

    'Example: Models #5a: Add EF List Code
    Private SocratesDB As New SocratesContext()

    ' GET: /Department
    Function Index() As ActionResult
        'Example: Models #5b: LINQ Methods Technique
        Dim departments = SocratesDB.Departments.OrderBy(Function(d) d.Name).ToList()

        'Example: Models #5c: LINQ for Entities Technique
        Dim departments2 = From d In SocratesDB.Departments
                           Order By d.Name Select d

        'Example: Models #5d: First Time this Successfully Runs, Database Created
        Return View(departments)

        'Example: Models #5f: Import Data into new Database
    End Function

    'Example: Models #6: Add Create HTTPGet Action Method
    Function Create() As ActionResult
        Return View()
    End Function

    'Example: Models #9: Add Create HTTPPost Action Method
    <HttpPost>
    Function Create(department As Department) As ActionResult
        'Example: Data Validation #2: Custom Model Error
        If SocratesDB.Departments.Where(Function(d) d.Name = department.Name).Count > 0 Then
            ModelState.AddModelError("Name", "Department Name Already In Use")
        Else
            Try
                SocratesDB.Departments.Add(department)
                SocratesDB.SaveChanges()

                Return RedirectToAction("Index")
            Catch
            End Try
        End If
        Return View(department)
    End Function
    ' Example: Client Side Validation #1: See Department/Create View at the Bottom for Script tags

    ' Example: BootStrap #2: Add Action Method to Test Bootstrap
    Function BootStrap() As ActionResult
        Return View()
    End Function

    ' Example: Ajax #1: AJAX Department Search, , check out Search View for Code
    Function Search() As ActionResult
        Return View()
    End Function

    <HttpPost>
    Function Search(q As String) As ActionResult
        Dim departments = SocratesDB.Departments.Where(Function(d) d.Name.Contains(q)).ToList()
        If departments Is Nothing OrElse departments.Count = 0 Then
            Return Content("No Departments Found")
        Else
            Return PartialView("_SearchResultsPartial", departments)
        End If
    End Function

    ' Example: JQuery.UI #1: Autocomplete, check out Search View for Code
    Function AutoComplete(term As String) As ActionResult
        Dim departments As New List(Of String)
        If Not String.IsNullOrEmpty(term) Then
            departments = (From d In SocratesDB.Departments
                           Where d.Name.Contains(term)
                           Order By d.Name
                           Select d.Name).ToList()
        End If
        Return Json(departments, JsonRequestBehavior.AllowGet)
    End Function
End Class