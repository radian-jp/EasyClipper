using System;
using Windows.Win32;
using Windows.Win32.Graphics.Gdi;
using Windows.Win32.Foundation;

namespace EasyClipper.Native;

internal class GdiObject
{
    public HPEN HighlightPen { get; } = PInvoke.CreatePen(PEN_STYLE.PS_SOLID, 3, new COLORREF(0x000000ff));

    public static GdiObject Shared { get; } = new GdiObject();

    ~GdiObject()
    {
        PInvoke.DeleteObject(HighlightPen);
    }
}
