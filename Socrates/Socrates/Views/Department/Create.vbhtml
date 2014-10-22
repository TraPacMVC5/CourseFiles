@ModelType Department

@Code
    ' Example: Models #7: Add Create View - Empty with Model
    Layout = Nothing
    
    ' Example: Models #8: Add Create Form Code & Validation Below
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Create</title>
</head>
<body>
    @Using (Html.BeginForm())
        @<h1>Add a New Department</h1>
           
        @Html.ValidationSummary()
        @<br>
       
        @Html.LabelFor(Function(model) model.Name)
        @Html.EditorFor(Function(model) model.Name)
        @Html.ValidationMessageFor(Function(model) model.Name)

        @<br>
        @<input type="submit" value="Create"/>
    End Using

    <div>
        @Html.ActionLink("Back to Index", "Index")
    </div>
    <script src="/Scripts/jquery-2.1.0.min.js"></script>
    <script src="/Scripts/jquery.validate.min.js"></script>
    <script src="/Scripts/jquery.validate.unobtrusive.js"></script>
</body>
</html>
