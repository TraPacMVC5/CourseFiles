@ModelType IEnumerable(Of Course)

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <p>
        @Html.ActionLink("Create New", "Create")
    </p>
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.Number)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Title)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Duration)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Description)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.AvailabilityDate)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.IsActive)
            </th>
            <th></th>
        </tr>
    
    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Number)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Title)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Duration)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Description)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.AvailabilityDate)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.IsActive)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
                @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
            </td>
        </tr>
    Next
    
    </table>
</body>
</html>
