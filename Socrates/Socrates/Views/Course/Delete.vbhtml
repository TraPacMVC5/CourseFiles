@ModelType Course

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
