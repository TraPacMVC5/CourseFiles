@ModelType Instructor

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Delete</title>
</head>
<body>
    <h3>Are you sure you want to delete this?</h3>
    <div>
        <h4>Instructor</h4>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                @Html.DisplayNameFor(Function(model) model.FirstName)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.FirstName)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.LastName)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.LastName)
            </dd>
    
        </dl>
        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()
    
            @<div class="form-actions no-color">
                <input type="submit" value="Delete" class="btn btn-default" /> |
                @Html.ActionLink("Back to List", "Index")
            </div>
        End Using
    </div>
</body>
</html>
