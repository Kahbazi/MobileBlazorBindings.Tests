using XF = Xamarin.Forms;

namespace MobileBlazorBindings.Tests
{
    public class TestResourceProvider : XF.Internals.ISystemResourcesProvider
    {
        public XF.Internals.IResourceDictionary GetSystemResources()
        {
            return new TestResourceDictionary();
        }
    }
}
