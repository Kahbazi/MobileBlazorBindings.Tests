using Xamarin.Forms;

namespace MobileBlazorBindings.Tests
{
    public static class PickerExtensions
    {
        public static void Select(this Picker picker, int index)
        {
            picker.SelectedIndex = index;
        }
    }
}