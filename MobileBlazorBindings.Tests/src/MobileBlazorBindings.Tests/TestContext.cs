using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.MobileBlazorBindings;
using Microsoft.MobileBlazorBindings.Elements.Handlers;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace MobileBlazorBindings.Tests
{
    public static class TestContext
    {
        public static async Task<Page> Start<TComponent>() where TComponent : IComponent
        {
            DependencyService.Register<ISystemResourcesProvider, TestResourceProvider>();

            Device.info = new TestDeviceInfo();
            Device.PlatformServices = new TestPlatformServices();

            TestApplication application = new TestApplication();
            Application.SetCurrentApplication(application);


            var host = Host.CreateDefaultBuilder().Build();

            var renderer = new MobileBlazorBindingsRenderer(host.Services, host.Services.GetRequiredService<ILoggerFactory>());

            await renderer.AddComponent<TComponent>(new ElementHandler(renderer, application)).ConfigureAwait(false);

            application.SendStart();

            return application.MainPage;
        }
    }
}
