using Microsoft.AspNetCore.Blazor.Components;

namespace Blazored.Materialize.Buttons {

    public class ButtonBase : BlazorComponent {
        
        [Parameter] protected bool IsDisabled { get; set ;}
        [Parameter] protected bool IsSmall { get; set; }
        [Parameter] protected bool IsLarge { get; set; }
    }

}