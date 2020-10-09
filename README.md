# FieldSharingGlitch

![](https://github.com/AskYous/FieldSharingGlitch/raw/master/Demo.gif)

This project is design to reproduce a possible glitch. When using a `@foreach` loop in the blazor code, fields that are initialized in the component don't seem to stay connected to their component and get shared with other components.

Notice the field `imageUrl` in ColorCard.razor. It **should** maintain its value, but instead, gets updated to another components value... or something weird is going on.

You can see this app live at https://blazor-field-glitch.azurewebsites.net. Try filtering for "Yellow," and notice how the picture for yellow is actually the picture for red.

Why is this happening?

