using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace MobileBlazorBindings.Tests
{
    public static class ElementExtensions
    {
        public static T FindFirst<T>(this Element element)
        {
            return element.Descendants().OfType<T>().First();
        }

        public static IEnumerable<T> FindAll<T>(this Element element)
        {
            return element.Descendants().OfType<T>();
        }
    }

    public static class ButtonExtensions
    {
        public static void Click(this Button button)
        {
            button.SendClicked();
        }
    }
}
