Namespace LanguageFeatures
    Public Class Properties
        ' Auto Implemented Properties
        Private _Name As String
        Public Property Name As String
            Get
                Return Me._Name
            End Get
            Set(value As String)
                Me._Name = value
            End Set
        End Property

        Private _ProductID2 As Integer
        Public Property ProductID As Integer

        Public Sub New()
            Me.New("No Name", 0)
        End Sub
        Public Sub New(Name As String, ProductID As Integer)
            Me.Name = Name
            Me.ProductID = ProductID
        End Sub
    End Class

    Public Class SomeCode
        Sub MySub()
            ' Automatic Type Inference
            Dim props = New Properties
            props.Name = "Widget"
            props.ProductID = 5

            ' Object Initializer 
            Dim props2 = New Properties With {.Name = "Widget", .ProductID = 5}

            ' Anonymous Type
            Dim props3 = New With {.Name = "Widget", .ProductID = 5, .Color = "Blue"}
        End Sub

        ' Extension Methods

        ' Lambda Expressions

        ' LINQ

        ' Async
    End Class
End Namespace
