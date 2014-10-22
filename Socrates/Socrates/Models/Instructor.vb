'Example: Models #1: Add EF Code First POCO
Imports System.ComponentModel.DataAnnotations

Public Class Instructor
    Public Property Id As Integer
    <Required> Public Property FirstName As String
    <Required> Public Property LastName As String

    Public Overridable Property Department As Department
    Public Overridable Property Courses As ICollection(Of Course)

    Public ReadOnly Property FullName As String
        Get
            Return FirstName & " " & LastName
        End Get
    End Property
End Class
