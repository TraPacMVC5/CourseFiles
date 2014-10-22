@ModelType Course

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
        <h4>Course</h4>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                @Html.DisplayNameFor(Function(model) model.Number)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.Number)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.Title)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.Title)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.Duration)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.Duration)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.Description)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.Description)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.AvailabilityDate)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.AvailabilityDate)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.IsActive)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.IsActive)
            </dd>
    
        </dl>
    </div>
    <p>
        @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
        @Html.ActionLink("Back to List", "Index")
    </p>
</body>
</html>
