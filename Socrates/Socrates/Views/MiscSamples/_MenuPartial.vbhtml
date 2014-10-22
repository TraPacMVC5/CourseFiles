@modeltype MenuCoordinates
<style>
    .Menu {
        background-color: Yellow;
        Position: absolute;
        border: 2px solid black;
        border-radius: 10px;
        text-align: center;
        left: @(Model.X)px;
        top: @(Model.Y)px;
        height: @(Model.Height)px;
        width: @(Model.Width)px;
    }
</style>

<div class="Menu">Menu</div>
