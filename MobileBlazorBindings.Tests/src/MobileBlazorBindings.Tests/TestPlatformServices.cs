using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using XF = Xamarin.Forms;

namespace MobileBlazorBindings.Tests
{
    public class TestPlatformServices : XF.Internals.IPlatformServices
    {
        public Action Action;
        public bool IsInvokeRequired => false;

        public string RuntimePlatform => "test";

        public void BeginInvokeOnMainThread(Action action)
        {
            action();
        }

        public XF.Internals.Ticker CreateTicker()
        {
            return XF.Internals.Ticker.Default;
        }

        public Assembly[] GetAssemblies()
        {
            return AppDomain.CurrentDomain.GetAssemblies();
        }

        public string GetMD5Hash(string input)
        {
            return input;
        }

        public double GetNamedSize(XF.NamedSize size, Type targetElementType, bool useOldSizes)
        {
            return 50;
        }

        public XF.SizeRequest GetNativeSize(XF.VisualElement view, double widthConstraint, double heightConstraint)
        {
            throw new NotImplementedException();
        }

        public Task<Stream> GetStreamAsync(Uri uri, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public XF.Internals.IIsolatedStorageFile GetUserStoreForApplication()
        {
            throw new NotImplementedException();
        }

        public void OpenUriAction(Uri uri)
        {
        }

        public void QuitApplication()
        {
        }

        public void StartTimer(TimeSpan interval, Func<bool> callback)
        {
        }
    }
}
