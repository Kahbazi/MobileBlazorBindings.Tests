using System;
using System.Runtime.CompilerServices;
using XF = Xamarin.Forms;

namespace MobileBlazorBindings.Tests
{
    public class TestApplication : XF.Application
    {
        public override XF.IDispatcher Dispatcher => base.Dispatcher;

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        protected override void CleanUp()
        {
            base.CleanUp();
        }

        protected override void OnAppLinkRequestReceived(Uri uri)
        {
            base.OnAppLinkRequestReceived(uri);
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
        }

        protected override void OnChildAdded(XF.Element child)
        {
            base.OnChildAdded(child);
        }

        protected override void OnChildRemoved(XF.Element child)
        {
            base.OnChildRemoved(child);
        }

        protected override void OnParentSet()
        {
            base.OnParentSet();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
        }

        protected override void OnPropertyChanging([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanging(propertyName);
        }

        protected override void OnResume()
        {
            base.OnResume();
        }

        protected override void OnSleep()
        {
            base.OnSleep();
        }

        protected override void OnStart()
        {
            base.OnStart();
        }
    }
}
