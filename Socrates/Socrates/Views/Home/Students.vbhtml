@code
    'Example: View #5: Layout Page Call
    'Example: View #6: _ViewStart.vbhtml comment this out
    'Layout = "~/Views/Shared/_Layout.vbhtml"
    
    
    ' Example: View #7: Make ViewModel Strongly Typed
    ' Note: intellisense on Model & student vars before and after
End Code

@ModelType IEnumerable(Of String)

@Code
    ViewBag.Title = "Socrates - List Students"
    ViewBag.PageTitle = "Socrates - List Students"
End Code

<!-- Example: View #4: Use a Simple Model to Send Data to View -->
@For Each student In Model
    @student@<br>
Next

