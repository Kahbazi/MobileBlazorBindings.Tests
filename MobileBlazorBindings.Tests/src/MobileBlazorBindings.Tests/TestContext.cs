using System;
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
    public class TestContext
    {
        private readonly IHost _host;
        private readonly Application _application;

        public TestContext(DeviceInfo deviceInfo, IPlatformServices platformServices, Func<Application> applicationFunc, IHost host)
        {
            DependencyService.Register<ISystemResourcesProvider, TestResourceProvider>();
            Device.info = deviceInfo ?? throw new System.ArgumentNullException(nameof(deviceInfo));
            Device.PlatformServices = platformServices ?? throw new System.ArgumentNullException(nameof(platformServices));
            _application = applicationFunc?.Invoke() ?? throw new System.ArgumentNullException(nameof(applicationFunc));
            Application.SetCurrentApplication(_application);
            _host = host ?? throw new System.ArgumentNullException(nameof(host));
        }

        public async Task<Page> Start<TComponent>() where TComponent : IComponent
        {
            var renderer = new MobileBlazorBindingsRenderer(_host.Services, _host.Services.GetRequiredService<ILoggerFactory>());

            await renderer.AddComponent<TestComponent<TComponent>>(new ElementHandler(renderer, _application)).ConfigureAwait(false);

            _application.SendStart();

            return _application.MainPage;
        }
    }
}
