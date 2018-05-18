using Microsoft.AspNetCore.Blazor.Components;

namespace Blazored.Materialize.Base
{
    public class BaseComponent : BlazorComponent
    {
        [Parameter]
        protected string Css { get; set; }
    }
}