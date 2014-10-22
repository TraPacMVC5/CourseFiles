'Example: Models #3: Add EF Code First POCO
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

'<Table("Departments")>
Public Class Department
    '<Column("DepartmentID", TypeName:="int")>
    Public Property Id As Integer
    'Example: Data Validation #1: Custom Error Message
    <Required(ErrorMessage:="You Idiot, Department Name is Required...")>
    Public Property Name As String

    Public Overridable Property Instructors As ICollection(Of Instructor)
    Public Overridable Property Courses As ICollection(Of Course)


End Class
