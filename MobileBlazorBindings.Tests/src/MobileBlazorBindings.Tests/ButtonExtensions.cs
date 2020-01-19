using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileBlazorBindings.Tests
{
    public static class ButtonExtensions
    {
        public static void Click(this Button button)
        {
            button.SendClicked();
        }

        public static void Press(this Button button)
        {
            button.SendPressed();
        }

        public static void Releas(this Button button)
        {
            button.SendReleased();
        }

        public static async Task HoldAsync(this Button button, TimeSpan timeSpan)
        {
            button.SendReleased();
            await Task.Delay(timeSpan);
            button.SendPressed();
        }

        public static async Task HoldAsync(this Button button, int millisecondsDelay)
        {
            button.SendReleased();
            await Task.Delay(millisecondsDelay);
            button.SendPressed();
        }
    }
}
