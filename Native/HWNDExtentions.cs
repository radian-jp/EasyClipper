using System.Runtime.InteropServices;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.Graphics.Dwm;
using Windows.Win32.Graphics.Gdi;

namespace EasyClipper.Native
{
    internal static class HWNDExtentions
    {
        public static uint GetPID(this HWND hwnd)
        {
            unsafe
            {
                uint pid;
                PInvoke.GetWindowThreadProcessId(hwnd, &pid);
                return pid;
            }
        }

        public static uint GetThreadID(this HWND hwnd)
        {
            unsafe
            {
                uint pid;
                return PInvoke.GetWindowThreadProcessId(hwnd, &pid);
            }
        }

        public static RECT GetRectExact(this HWND hwnd)
        {
            PInvoke.DwmIsCompositionEnabled(out var enableAero);

            if (enableAero)
            {
                unsafe
                {
                    RECT rect;
                    if (PInvoke.DwmGetWindowAttribute(hwnd, DWMWINDOWATTRIBUTE.DWMWA_EXTENDED_FRAME_BOUNDS, &rect, (uint)Marshal.SizeOf(rect)).Succeeded)
                    {
                        return rect;
                    }
                    else
                    {
                        PInvoke.GetWindowRect(hwnd, out rect);
                        return rect;
                    }
                }
            }
            else
            {
                PInvoke.GetWindowRect(hwnd, out var rect);
                return rect;
            }
        }

        public static void SetHighlight(this HWND hwnd)
        {
            var hWindowDC = PInvoke.GetWindowDC(hwnd);
            if (hWindowDC == IntPtr.Zero)
            {
                return;
            }

            var rectInner = hwnd.GetRectExact(); // Aero有効の場合の実Windowサイズ
            PInvoke.GetWindowRect(hwnd, out var rect);

            var hPrevPen = PInvoke.SelectObject(hWindowDC, GdiObject.Shared.HighlightPen);
            var hPrevBrush = PInvoke.SelectObject(hWindowDC, PInvoke.GetStockObject(GET_STOCK_OBJECT_FLAGS.HOLLOW_BRUSH));

            var xGap = rectInner.X - rect.X;
            var yGap = rectInner.Y - rect.Y;
            PInvoke.Rectangle(hWindowDC, xGap, yGap, rectInner.Width + xGap, rectInner.Height + yGap);

            PInvoke.SelectObject(hWindowDC, hPrevPen);
            PInvoke.SelectObject(hWindowDC, hPrevBrush);
            PInvoke.ReleaseDC(hwnd, hWindowDC);
        }

        public static void RemoveHighlight(this HWND hwndWindowToBeRefreshed)
        {
            unsafe
            {
                PInvoke.InvalidateRect(hwndWindowToBeRefreshed, (RECT?)null, true);
                PInvoke.UpdateWindow(hwndWindowToBeRefreshed);
                PInvoke.RedrawWindow(hwndWindowToBeRefreshed, null, null, REDRAW_WINDOW_FLAGS.RDW_FRAME | REDRAW_WINDOW_FLAGS.RDW_INVALIDATE | REDRAW_WINDOW_FLAGS.RDW_UPDATENOW | REDRAW_WINDOW_FLAGS.RDW_ALLCHILDREN);
            }
        }

        public static string GetText(this HWND hwnd)
        {
            unsafe
            {
                const int bufSize = 256;
                char* pBuf = stackalloc char[bufSize];
                var length = PInvoke.GetWindowText(hwnd, pBuf, bufSize - 1);
                if (length == 0)
                    return string.Empty;

                return new string(pBuf, 0, length);
            }
        }

        public static string GetClassName(this HWND hwnd)
        {
            unsafe
            {
                const int bufSize = 256;
                char* pBuf = stackalloc char[bufSize];
                var length = PInvoke.GetClassName(hwnd, pBuf, bufSize - 1);
                if (length == 0)
                    return string.Empty;

                return new string(pBuf, 0, length);
            }
        }

        public static bool IsExist(this HWND hwnd) => hwnd.IsNull ? false : PInvoke.IsWindow(hwnd);
    }
}
