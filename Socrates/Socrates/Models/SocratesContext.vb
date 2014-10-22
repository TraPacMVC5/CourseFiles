'Example: Models #4: Add EF DBContext
Imports System.Data.Entity

Public Class SocratesContext
    Inherits DbContext

    Public Property Courses As DbSet(Of Course)
    Public Property Departments As DbSet(Of Department)
    Public Property Instructors As DbSet(Of Instructor)

    Public Sub New(ConnectionString As String)
        MyBase.New(ConnectionString)
    End Sub

    Public Sub New()
    End Sub

    'Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
    '    modelBuilder.Entity(Of Department)().Property(Function(t) t.Name).IsRequired()
    'End Sub
End Class
