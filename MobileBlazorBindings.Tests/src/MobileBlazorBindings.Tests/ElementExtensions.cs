using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace MobileBlazorBindings.Tests
{
    public static class ElementExtensions
    {
        public static T FindFirst<T>(this Element element)
        {
            return element.Descendants().OfType<T>().FirstOrDefault();
        }

        public static IEnumerable<T> FindAll<T>(this Element element)
        {
            return element.Descendants().OfType<T>();
        }

        public static T Get<T>(this Element element, string automationId) where T : Element
        {
            return element.Descendants().OfType<T>().FirstOrDefault(e => e.AutomationId == automationId);
        }
    }
}
