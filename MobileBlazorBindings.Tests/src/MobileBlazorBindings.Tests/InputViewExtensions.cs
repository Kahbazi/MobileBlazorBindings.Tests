using Xamarin.Forms;

namespace MobileBlazorBindings.Tests
{
    public static class InputViewExtensions
    {
        public static void Input(this InputView inputView, string text)
        {
            inputView.Text = text;
        }
    }
}