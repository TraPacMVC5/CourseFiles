@ModelType System.Web.Mvc.HandleErrorInfo
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>View1</title>
</head>
<body>
    <div> 
        I'm Sorry, Something Went Boom!!!<br/>
        Exception Said: @Model.Exception.Message
    </div>
</body>
</html>
