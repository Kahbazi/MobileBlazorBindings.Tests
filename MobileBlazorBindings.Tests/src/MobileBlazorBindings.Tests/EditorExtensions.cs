using Xamarin.Forms;

namespace MobileBlazorBindings.Tests
{
    public static class EditorExtensions
    {
        public static void Complete(this Editor editor)
        {
            editor.SendCompleted();
        }
    }
}