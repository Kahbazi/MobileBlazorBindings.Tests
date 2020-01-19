using Microsoft.AspNetCore.Components;

namespace MobileBlazorBindings.Tests
{
    public class TestComponent<TComponent> : ComponentBase where TComponent : IComponent
    {
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.MobileBlazorBindings.Elements.ContentPage>(0);
            __builder.AddAttribute(1, "ChildContent", (RenderFragment)((__builder2) =>
            {
                __builder2.AddMarkupContent(2, "\r\n");
                __builder2.OpenComponent<TComponent>(3);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(4, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
    }
}