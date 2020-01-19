using System;
using Microsoft.Extensions.Hosting;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace MobileBlazorBindings.Tests
{
    public class TestContextBuilder
    {
        private DeviceInfo _deviceInfo;
        private IPlatformServices _platformServices;
        private Func<Application> _applicationFunc;
        private IHost _host;

        public TestContextBuilder WithDeviceInfo(DeviceInfo deviceInfo)
        {
            _deviceInfo = deviceInfo;
            return this;
        }

        public TestContextBuilder WithPlatformServices(IPlatformServices platformServices)
        {
            _platformServices = platformServices;
            return this;
        }

        public TestContextBuilder WithApplication(Func<Application> applicationFunc)
        {
            _applicationFunc = applicationFunc;
            return this;
        }

        public TestContextBuilder WithHost(IHost host)
        {
            _host = host;
            return this;
        }

        public TestContext Build()
        {
            _deviceInfo ??= new TestDeviceInfo();
            _platformServices ??= new TestPlatformServices();
            _applicationFunc ??= () => new TestApplication();
            _host ??= Host.CreateDefaultBuilder().Build();
            return new TestContext(_deviceInfo, _platformServices, _applicationFunc, _host);
        }
    }
}
