@modeltype IEnumerable(Of Department)
@Code
    ' Example: BootStrap #3: Make this View use BootstrapLayout
    ViewBag.Title = "Socrates - List Departments"
    Layout = Nothing


    ' Example: Models #5e: Add View Empty with Model and Loop Code
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>ViewBag.Title</title>
</head>
<body>
    <h2>Departments</h2>
    <ul>
        @For Each department In Model
            @<li>@department.Name</li>
        Next
    </ul>
</body>
</html>