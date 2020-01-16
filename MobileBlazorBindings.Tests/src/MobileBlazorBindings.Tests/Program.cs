using System.Threading.Tasks;
using Xamarin.Forms;
using Xunit;

namespace MobileBlazorBindings.Tests
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var page = await TestContext.Start<Counter>();

            var label = page.FindFirst<Label>();
            var button = page.FindFirst<Button>();

            Assert.Equal("The button was clicked 0 times", label.Text);

            button.Click();

            Assert.Equal("The button was clicked 1 times", label.Text);
            
            button.Click();
            button.Click();
            
            Assert.Equal("The button was clicked 3 times", label.Text);
        }
    }
}
