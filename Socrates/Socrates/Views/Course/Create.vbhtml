@ModelType Course

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
            <h4>Course</h4>
            <hr />
            @Html.ValidationSummary(true)
            <div class="form-group">
                @Html.LabelFor(Function(model) model.Number, New With { .class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Number)
                    @Html.ValidationMessageFor(Function(model) model.Number)
                </div>
            </div>
    
            <div class="form-group">
                @Html.LabelFor(Function(model) model.Title, New With { .class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Title)
                    @Html.ValidationMessageFor(Function(model) model.Title)
                </div>
            </div>
    
            <div class="form-group">
                @Html.LabelFor(Function(model) model.Duration, New With { .class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Duration)
                    @Html.ValidationMessageFor(Function(model) model.Duration)
                </div>
            </div>
    
            <div class="form-group">
                @Html.LabelFor(Function(model) model.Description, New With { .class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Description)
                    @Html.ValidationMessageFor(Function(model) model.Description)
                </div>
            </div>
    
            <div class="form-group">
                @Html.LabelFor(Function(model) model.AvailabilityDate, New With { .class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.AvailabilityDate)
                    @Html.ValidationMessageFor(Function(model) model.AvailabilityDate)
                </div>
            </div>
    
            <div class="form-group">
                @Html.LabelFor(Function(model) model.IsActive, New With { .class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.IsActive)
                    @Html.ValidationMessageFor(Function(model) model.IsActive)
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
