
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Search</title>
    <link rel="stylesheet" href="/Content/themes/base/jquery.ui.all.css" />
</head>
<body>
    <div> 
        @Using Ajax.BeginForm("Search", "Department", Nothing,
                              New AjaxOptions With {
                                 .HttpMethod = "POST",
                                 .InsertionMode = InsertionMode.Replace,
                                 .UpdateTargetId = "searchResults"
                              })
        @<input type="text" name="q" data-autocomplete="@Url.Action("AutoComplete")"/>
        @<input type="submit" value="Search"/>
        End Using
    </div>
    <div id="searchResults"></div>
    <script src="/Scripts/jquery-2.1.0.min.js"></script>
    <script src="/Scripts/jquery.unobtrusive-ajax.min.js"></script>
    <script src="/Scripts/jquery-ui-1.10.4.js"></script>
    <script>
        $(document).ready(function () {
            $(":input[data-autocomplete]").each(function () {
                $(this).autocomplete({ source: $(this).attr("data-autocomplete") });
            });
        })
    </script>
</body>
</html>
