'Example: Models #2: Add EF Code First POCO
Imports System.ComponentModel.DataAnnotations

Public Class Course
    Public Property Id As Integer
    <Required> Public Property Number As String
    <Required> Public Property Title As String
    <Required> Public Property Duration As Single
    Public Property Description As String
    <Required> Public Property AvailabilityDate As DateTime
    Public Property IsActive As Boolean

    Public Overridable Property Department As Department
    Public Overridable Property Instructors As ICollection(Of Instructor)
End Class