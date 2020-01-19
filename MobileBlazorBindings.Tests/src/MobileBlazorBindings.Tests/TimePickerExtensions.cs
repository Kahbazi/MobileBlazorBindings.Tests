using System;
using Xamarin.Forms;

namespace MobileBlazorBindings.Tests
{
    public static class TimePickerExtensions
    {
        public static void Input(this TimePicker timePicker, TimeSpan timeSpan)
        {
            timePicker.Time = timeSpan;
        }
    }
}