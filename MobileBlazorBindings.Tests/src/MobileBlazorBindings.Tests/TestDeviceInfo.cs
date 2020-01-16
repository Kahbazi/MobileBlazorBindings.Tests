using XF = Xamarin.Forms;

namespace MobileBlazorBindings.Tests
{
    public class TestDeviceInfo : XF.Internals.DeviceInfo
    {
        public override XF.Size PixelScreenSize => new XF.Size(600, 800);

        public override XF.Size ScaledScreenSize => new XF.Size(600, 800);

        public override double ScalingFactor => 1;
    }
}
