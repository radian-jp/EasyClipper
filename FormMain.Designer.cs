namespace EasyClipper;

partial class FormMain
{
    /// <summary>
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows フォーム デザイナーで生成されたコード

    /// <summary>
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.txtLog = new System.Windows.Forms.TextBox();
            this.LabelStart = new System.Windows.Forms.Label();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.TextMarginLeft = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextMarginRight = new System.Windows.Forms.NumericUpDown();
            this.TextMarginBottom = new System.Windows.Forms.NumericUpDown();
            this.TextMarginTop = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TextMarginLeft)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextMarginRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextMarginBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextMarginTop)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLog.Location = new System.Drawing.Point(314, 11);
            this.txtLog.Margin = new System.Windows.Forms.Padding(0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(451, 194);
            this.txtLog.TabIndex = 10;
            this.txtLog.TabStop = false;
            this.txtLog.WordWrap = false;
            // 
            // LabelStart
            // 
            this.LabelStart.BackColor = System.Drawing.Color.White;
            this.LabelStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelStart.Location = new System.Drawing.Point(14, 9);
            this.LabelStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelStart.Name = "LabelStart";
            this.LabelStart.Size = new System.Drawing.Size(179, 46);
            this.LabelStart.TabIndex = 2;
            this.LabelStart.Text = "Drag && Drop to\r\nTarget Window";
            this.LabelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblSetCapture_MouseDown);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Enabled = false;
            this.ButtonStop.Location = new System.Drawing.Point(201, 9);
            this.ButtonStop.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(110, 46);
            this.ButtonStop.TabIndex = 1;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // TextMarginLeft
            // 
            this.TextMarginLeft.Location = new System.Drawing.Point(59, 42);
            this.TextMarginLeft.Margin = new System.Windows.Forms.Padding(0);
            this.TextMarginLeft.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.TextMarginLeft.Name = "TextMarginLeft";
            this.TextMarginLeft.Size = new System.Drawing.Size(48, 23);
            this.TextMarginLeft.TabIndex = 1;
            this.TextMarginLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextMarginRight);
            this.groupBox1.Controls.Add(this.TextMarginBottom);
            this.groupBox1.Controls.Add(this.TextMarginTop);
            this.groupBox1.Controls.Add(this.TextMarginLeft);
            this.groupBox1.Location = new System.Drawing.Point(1, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(309, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Margin";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(197, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Right";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(89, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bottom";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(94, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Top";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Left";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextMarginRight
            // 
            this.TextMarginRight.Location = new System.Drawing.Point(251, 42);
            this.TextMarginRight.Margin = new System.Windows.Forms.Padding(4);
            this.TextMarginRight.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.TextMarginRight.Name = "TextMarginRight";
            this.TextMarginRight.Size = new System.Drawing.Size(48, 23);
            this.TextMarginRight.TabIndex = 3;
            this.TextMarginRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextMarginBottom
            // 
            this.TextMarginBottom.Location = new System.Drawing.Point(148, 70);
            this.TextMarginBottom.Margin = new System.Windows.Forms.Padding(4);
            this.TextMarginBottom.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.TextMarginBottom.Name = "TextMarginBottom";
            this.TextMarginBottom.Size = new System.Drawing.Size(48, 23);
            this.TextMarginBottom.TabIndex = 4;
            this.TextMarginBottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextMarginTop
            // 
            this.TextMarginTop.Location = new System.Drawing.Point(148, 11);
            this.TextMarginTop.Margin = new System.Windows.Forms.Padding(4);
            this.TextMarginTop.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.TextMarginTop.Name = "TextMarginTop";
            this.TextMarginTop.Size = new System.Drawing.Size(48, 23);
            this.TextMarginTop.TabIndex = 2;
            this.TextMarginTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 218);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LabelStart);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.ButtonStop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "EasyClipper";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.TextMarginLeft)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextMarginRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextMarginBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextMarginTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtLog;
    private System.Windows.Forms.Label LabelStart;
    private System.Windows.Forms.Button ButtonStop;
    private System.Windows.Forms.NumericUpDown TextMarginLeft;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown TextMarginBottom;
    private System.Windows.Forms.NumericUpDown TextMarginTop;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown TextMarginRight;
}

