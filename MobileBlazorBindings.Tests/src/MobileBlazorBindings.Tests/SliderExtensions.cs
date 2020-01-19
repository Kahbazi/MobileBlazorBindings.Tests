using Xamarin.Forms;

namespace MobileBlazorBindings.Tests
{
    public static class SliderExtensions
    {
        public static void Input(this Slider slider, double value)
        {
            slider.Value = value;
        }
    }
}