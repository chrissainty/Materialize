using System;
using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace Blazored.Materialize
{
    public class ExampleJsInterop
    {
        public static string Prompt(string message)
        {
            return RegisteredFunction.Invoke<string>(
                "Blazored.Materialize.ExampleJsInterop.Prompt",
                message);
        }
    }
}
