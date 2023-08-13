using Windows.Win32.Foundation;

namespace EasyClipper.Native
{
    internal partial class FormHighlight : Form
    {
        private Pen _penBorder = new Pen(Brushes.Red, 20);

        public FormHighlight()
        {
            InitializeComponent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _penBorder.Dispose();

            base.OnFormClosed(e);
        }

        public void SetPositionFromHWND(HWND hwnd)
        {
            if (!hwnd.IsExist())
                return;
            
            var rectBorder = hwnd.GetRectExact();
            this.Size = rectBorder.Size;
            this.Location = new Point(rectBorder.X, rectBorder.Y);
            this.Show();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            this.Opacity = 0.3;

            base.OnVisibleChanged(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(_penBorder, e.ClipRectangle);

            base.OnPaint(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            this.Invalidate();
        }
    }
}
