using EasyClipper.Native;
using Windows.Win32;
using Windows.Win32.Foundation;
using System.Diagnostics;

namespace EasyClipper;

public partial class FormMain : Form
{
    private HWND _hwndCursor;
    private HWND _hwndClip;
    private uint _pidClip;
    private uint _pidThis;
    private Config _config = Config.Load();
    private Task? _taskClip;
    private CancellationTokenSource _cts = new CancellationTokenSource();
    private FormHighlight? _formHighlight;

    public FormMain()
    {
        InitializeComponent();

        _pidThis = (uint)Process.GetCurrentProcess().Id;
    }

    private void LoadConfig()
    {
        TextMarginLeft.Value = _config.Left;
        TextMarginTop.Value = _config.Top;
        TextMarginRight.Value = _config.Right;
        TextMarginBottom.Value = _config.Bottom;
    }

    private void SaveConfig()
    {
        _config.Left = (int)TextMarginLeft.Value;
        _config.Top = (int)TextMarginTop.Value;
        _config.Right = (int)TextMarginRight.Value;
        _config.Bottom = (int)TextMarginBottom.Value;
        _config.Save();
    }

    private void StartClipTask()
    {
        ButtonStop.Enabled = true;
        _hwndClip = _hwndCursor;
        _cts = new CancellationTokenSource();

        _taskClip = Task.Factory.StartNew(() =>
        {
            while (!_cts.Token.IsCancellationRequested)
            {
                // ウィンドウが閉じられているならループ終了
                if (!_hwndClip.IsExist())
                {
                    break;
                }

                Thread.Sleep(1);

                // アクティブウィンドウのプロセスIDを取得し、クリップ対象プロセスじゃないならクリップ解除
                var hwndActive = PInvoke.GetForegroundWindow();
                uint pidActive = hwndActive.GetPID();
                if (_pidClip != pidActive)
                {
                    PInvoke.ClipCursor((RECT?)null);
                    continue;
                }

                // ウィンドウ位置からクリップ範囲を計算
                var rectWnd = _hwndClip.GetRectExact();
                Rectangle rectClipNew = new Rectangle();
                rectClipNew.X = rectWnd.X + (int)TextMarginLeft.Value;
                rectClipNew.Y = rectWnd.Y + (int)TextMarginTop.Value;
                rectClipNew.Width = rectWnd.Width
                    - (int)TextMarginLeft.Value
                    - (int)TextMarginRight.Value;
                rectClipNew.Height = rectWnd.Height
                    - (int)TextMarginTop.Value
                    - (int)TextMarginBottom.Value;

                // クリップ範囲が変化していればClipCursorを再セット
                if (rectClipNew != Cursor.Clip)
                {
                    Cursor.Clip = rectClipNew;
                }
            }

            Cursor.Clip = Rectangle.Empty;
            _hwndClip = HWND.Null;
            _pidClip = 0;
            BeginInvoke(() =>
            {
                txtLog.Clear();
                ButtonStop.Enabled = false;
            });

        }, _cts.Token);
    }

    private void EndClipTask()
    {
        if (_taskClip == null)
            return;

        var task = Interlocked.Exchange(ref _taskClip, null);
        if (task != null)
        {
            _cts.Cancel();
            task.Wait();
        }
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        LoadConfig();

        TextMarginLeft.ValueChanged += (o, e) => { SaveConfig(); };
        TextMarginTop.ValueChanged += (o, e) => { SaveConfig(); };
        TextMarginRight.ValueChanged += (o, e) => { SaveConfig(); };
        TextMarginBottom.ValueChanged += (o, e) => { SaveConfig(); };
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        EndClipTask();
        SaveConfig();

        base.OnFormClosed(e);
    }

    private void lblSetCapture_MouseDown(object sender, MouseEventArgs e)
    {
        this.Capture = true;
        this.Cursor = Cursors.Cross;
    }

    private void FormMain_MouseUp(object sender, MouseEventArgs e)
    {
        this.Capture = false;
        this.Cursor = Cursors.Default;
        if (!_hwndCursor.IsNull)
        {
            Interlocked.Exchange(ref _formHighlight, null)?.Close();
            StartClipTask();
        }
        _hwndCursor = HWND.Null;
    }

    private void FormMain_MouseMove(object sender, MouseEventArgs e)
    {
        if (!this.Capture || this.Cursor != Cursors.Cross)
        {
            return;
        }

        var hwnd = WindowUtil.GetWindowFromCursor();
        uint pid = hwnd.GetPID();
        if (pid == _pidThis)
            return;

        var hwndDesktop = WindowUtil.GetDesktopListView();
        if (pid == hwndDesktop.GetPID())
            return;

        var className = hwnd.GetClassName();
        var windowText = hwnd.GetText();
        var rect = hwnd.GetRectExact();
        txtLog.Text = "HWND:" + hwnd.Value.ToString("X8")
            + "\r\nPID:" + pid
            + "\r\nWindowText:" + windowText
            + "\r\nClassName:" + className
            + $"\r\nPosition:({rect.X},{rect.Y},{rect.right},{rect.bottom})";

        _hwndCursor = hwnd;
        _pidClip = pid;
        if (_formHighlight == null)
        {
            _formHighlight = new FormHighlight();
            _formHighlight.Show(this);
        }

        _formHighlight.SetPositionFromHWND(_hwndCursor);
    }

    private void ButtonStop_Click(object sender, EventArgs e) => EndClipTask();
}
