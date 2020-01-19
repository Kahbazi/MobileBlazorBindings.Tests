using System;
using Xamarin.Forms;

namespace MobileBlazorBindings.Tests
{
    public static class DatePickerExtensions
    {
        public static void Input(this DatePicker datePicker, DateTime dateTime)
        {
            datePicker.Date = dateTime;
        }
    }
}