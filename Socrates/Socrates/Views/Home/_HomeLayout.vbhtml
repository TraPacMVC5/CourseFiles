@code
    'Example: View #5: Layout Page
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
</head>
<body>
    You are logged in as: @User.Identity.Name
    <div>
        <h1>@ViewBag.PageTitle</h1>

        @RenderBody()
    </div>
</body>
</html>
