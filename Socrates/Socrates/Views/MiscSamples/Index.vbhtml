
@Code
    Layout = "_SampleLayout.vbhtml"
End Code

<div> 
    This is the Body

    @Html.Action("Menu", New MenuCoordinates With
                    {.Height = 100, .Width = 100, .X = 100, .Y = 100})
</div>

@Section Header
    This is the Header
End Section

@Section Footer
    This is the Footer
End Section