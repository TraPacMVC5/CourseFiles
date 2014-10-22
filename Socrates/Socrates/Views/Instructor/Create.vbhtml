@ModelType Instructor

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Create</title>
</head>
<body>
    @Using (Html.BeginForm()) 
        @Html.AntiForgeryToken()
        
        @<div class="form-horizontal">
            <h4>Instructor</h4>
            <hr />
            @Html.ValidationSummary(true)
            <div class="form-group">
                @Html.LabelFor(Function(model) model.FirstName, New With { .class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.FirstName)
                    @Html.ValidationMessageFor(Function(model) model.FirstName)
                </div>
            </div>
    
            <div class="form-group">
                @Html.LabelFor(Function(model) model.LastName, New With { .class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.LastName)
                    @Html.ValidationMessageFor(Function(model) model.LastName)
                </div>
            </div>
    
            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <input type="submit" value="Create" class="btn btn-default" />
                </div>
            </div>
        </div>
    End Using
    
    <div>
        @Html.ActionLink("Back to List", "Index")
    </div>
</body>
</html>
