<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
</head>
<body>
    @RenderSection("Header")
    <div>
        @RenderBody()
    </div>
    @RenderSection("Footer")
</body>
</html>
