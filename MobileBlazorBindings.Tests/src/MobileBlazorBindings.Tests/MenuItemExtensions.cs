using Xamarin.Forms;

namespace MobileBlazorBindings.Tests
{
    public static class MenuItemExtensions
    {
        public static void Click(this MenuItem menuItem)
        {
            (menuItem as IMenuItemController).Activate();
        }
    }
}