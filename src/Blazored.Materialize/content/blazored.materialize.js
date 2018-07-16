// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

Blazor.registerFunction('Blazored.Materialize.ExampleJsInterop.Prompt', function (message) {
    return prompt(message, 'Type anything here');
});

Blazor.registerFunction('Blazored.Materialize.Carousel', () => {
    var elems = document.querySelectorAll('.carousel');
    var options = {};
    M.Carousel.init(elems, options);
});

Blazor.registerFunction('Blazored.Materialize.Collapsible', () => {
    var elems = document.querySelectorAll('.collapsible');
    var options = {};
    M.Collapsible.init(elems, options);
});
