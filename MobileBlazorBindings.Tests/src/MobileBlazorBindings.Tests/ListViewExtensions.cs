using Xamarin.Forms;

namespace MobileBlazorBindings.Tests
{
    public static class ListViewExtensions
    {
        public static void Refresh(this ListView listView)
        {
            listView.SendRefreshing();
        }

        public static void Scroll(this ListView listView, double x, double y)
        {
            listView.SendScrolled(new ScrolledEventArgs(x, y));
        }
    }
}