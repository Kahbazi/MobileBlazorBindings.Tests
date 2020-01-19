using Xamarin.Forms;

namespace MobileBlazorBindings.Tests
{
    public static class SwitchExtensions
    {
        public static void Toggle(this Switch @switch)
        {
            @switch.IsToggled = !@switch.IsToggled;
        }
    }
}