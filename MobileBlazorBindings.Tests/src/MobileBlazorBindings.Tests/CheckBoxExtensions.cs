using Xamarin.Forms;

namespace MobileBlazorBindings.Tests
{
    public static class CheckBoxExtensions
    {
        public static void Check(this CheckBox checkBox)
        {
            checkBox.IsChecked = true;
        }

        public static void Uncheck(this CheckBox checkBox)
        {
            checkBox.IsChecked = false;
        }
    }
}