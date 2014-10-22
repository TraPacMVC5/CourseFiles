@ModelType Instructor

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Details</title>
</head>
<body>
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
    </div>
    <p>
        @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
        @Html.ActionLink("Back to List", "Index")
    </p>
</body>
</html>
