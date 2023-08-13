using Windows.Win32;
using Windows.Win32.Foundation;

namespace EasyClipper.Native;

internal class WindowUtil
{
    public static HWND GetDesktopListView()
    {
        var hWndDesktop = PInvoke.FindWindow("Progman", "Program Manager");
        hWndDesktop = PInvoke.FindWindowEx(hWndDesktop, HWND.Null, "SHELLDLL_DefView", null);
        hWndDesktop = PInvoke.FindWindowEx(hWndDesktop, HWND.Null, "SysListView32", null);
        return hWndDesktop;
    }

    public static HWND GetWindowFromCursor()
    {
        Point pt = Cursor.Position;
        return PInvoke.WindowFromPoint(pt);
    }
}
