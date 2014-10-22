@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <!-- Example: View #3: Use ViewBag to Change Title -->
    <title>@ViewBag.Title</title>
</head>
<body>
    <div> 
        You are logged in as: @User.Identity.Name
        @code
            ' Example: View #2: ViewData or ViewBag work together
        End code        
        <h1>@ViewData("PageTitle")</h1>

        @code
            ' Example: View #4: Link to Students Action
        End code
        @Html.ActionLink("Display Students", "Students", Nothing, New With {.class = "cssClassName"})
        <br />
        <a class="cssClassName" href="@Url.Action("Students")">Display Students</a>

        @*@Html.ActionLink("Display Students", "Students",
                             New With {.id = "Blah"}, New With {.class = "cssClassName"})*@
    </div>
</body>
</html>
