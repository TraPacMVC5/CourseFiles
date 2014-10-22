﻿'Example: Models #13: Add InstructorController with Views Using EF
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace Socrates
    Public Class InstructorController
        Inherits System.Web.Mvc.Controller

        Private db As New SocratesContext

        ' GET: /Instructor/
        Function Index() As ActionResult
            Return View(db.Instructors.ToList())
        End Function

        ' GET: /Instructor/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim instructor As Instructor = db.Instructors.Find(id)
            If IsNothing(instructor) Then
                Return HttpNotFound()
            End If
            Return View(instructor)
        End Function

        ' GET: /Instructor/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /Instructor/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,FirstName,LastName")> ByVal instructor As Instructor) As ActionResult
            If ModelState.IsValid Then
                db.Instructors.Add(instructor)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            Return View(instructor)
        End Function

        ' GET: /Instructor/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim instructor As Instructor = db.Instructors.Find(id)
            If IsNothing(instructor) Then
                Return HttpNotFound()
            End If
            Return View(instructor)
        End Function

        ' POST: /Instructor/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,FirstName,LastName")> ByVal instructor As Instructor) As ActionResult
            If ModelState.IsValid Then
                db.Entry(instructor).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(instructor)
        End Function

        ' GET: /Instructor/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim instructor As Instructor = db.Instructors.Find(id)
            If IsNothing(instructor) Then
                Return HttpNotFound()
            End If
            Return View(instructor)
        End Function

        ' POST: /Instructor/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim instructor As Instructor = db.Instructors.Find(id)
            db.Instructors.Remove(instructor)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
