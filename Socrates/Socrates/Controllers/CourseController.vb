'Example: Models #10: Add CourseController with Read/Write Actions
Imports System.Web.Mvc
Imports System.Net
Imports System.Data.Entity

Public Class CourseController
    Inherits Controller

    'Example: Models #11: Add Appropriate View for Each Action Method

    'Example: Models #12: Add Appropriate ToDo Code for Each Action Method
    Private SocrateDB As New SocratesContext()

    ' GET: /Course
    Function Index() As ActionResult
        Return View(SocrateDB.Courses.ToList())
    End Function

    ' GET: /Course/Details/5
    Function Details(ByVal id As Integer) As ActionResult
        If IsNothing(id) Then
            Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
        End If
        Dim course As Course = SocrateDB.Courses.Find(id)
        If IsNothing(course) Then
            Return HttpNotFound()
        End If
        Return View(course)
    End Function

    ' GET: /Course/Create
    Function Create() As ActionResult
        Return View()
    End Function

    ' POST: /Course/Create
    <HttpPost()>
    Function Create(course As Course) As ActionResult
        Try
            SocrateDB.Courses.Add(course)
            SocrateDB.SaveChanges()
            Return RedirectToAction("Index")
        Catch
            Return View(course)
        End Try
    End Function

    ' GET: /Course/Edit/5
    Function Edit(ByVal id As Integer) As ActionResult
        If IsNothing(id) Then
            Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
        End If
        Dim course As Course = SocrateDB.Courses.Find(id)
        If IsNothing(course) Then
            Return HttpNotFound()
        End If
        Return View(course)
    End Function

    ' POST: /Course/Edit/5
    <HttpPost()>
    Function Edit(course As Course) As ActionResult
        Try
            SocrateDB.Entry(course).State = EntityState.Modified
            SocrateDB.SaveChanges()
            Return RedirectToAction("Index")
        Catch
            Return View(course)
        End Try
    End Function

    ' GET: /Course/Delete/5
    Function Delete(ByVal id As Integer) As ActionResult
        If IsNothing(id) Then
            Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
        End If
        Dim course As Course = SocrateDB.Courses.Find(id)
        If IsNothing(course) Then
            Return HttpNotFound()
        End If
        Return View(course)
    End Function

    ' POST: /Course/Delete/5
    <HttpPost()>
    Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
        Dim course As Course = SocrateDB.Courses.Find(id)
        Try
            SocrateDB.Courses.Remove(course)
            SocrateDB.SaveChanges()

            Return RedirectToAction("Index")
        Catch
            Return View(course)
        End Try
    End Function
End Class