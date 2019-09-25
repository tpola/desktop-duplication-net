using SharpDX.Mathematics.Interop;

namespace DesktopDuplication
{
    static class SharpDX_Extensions
    {
        public static int Width(this RawRectangle r) => r.Right - r.Left;
        public static int Height(this RawRectangle r) => r.Bottom - r.Top;
    }
}
