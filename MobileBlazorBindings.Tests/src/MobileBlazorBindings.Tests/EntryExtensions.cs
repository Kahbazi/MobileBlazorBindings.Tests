using Xamarin.Forms;

namespace MobileBlazorBindings.Tests
{
    public static class EntryExtensions
    {
        public static void Complete(this Entry entry)
        {
            entry.SendCompleted();
        }
    }
}