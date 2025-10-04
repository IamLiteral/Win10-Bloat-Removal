namespace Windows_Debloat_Project
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private Windows10.Components.GradientPanel panelHeader;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblStatsTitle;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Timer systemInfoTimer;
        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label lblActionsTitle;
        private System.Windows.Forms.FlowLayoutPanel flowButtons;
        private System.Windows.Forms.Panel panelLogger;
        private System.Windows.Forms.Label lblLoggerTitle;
        private System.Windows.Forms.Panel panelRunAll;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            panelHeader = new Windows10.Components.GradientPanel();
            lblSubtitle = new Label();
            panelStats = new Panel();
            lblStats = new Label();
            systemInfoTimer = new System.Windows.Forms.Timer(components);
            layoutMain = new TableLayoutPanel();
            panelButtons = new Panel();
            flowButtons = new FlowLayoutPanel();
            panelRunAll = new Panel();
            lblActionsTitle = new Label();
            panelLogger = new Panel();
            lblLoggerTitle = new Label();
            lblStatsTitle = new Label();
            panelHeader.SuspendLayout();
            panelStats.SuspendLayout();
            layoutMain.SuspendLayout();
            panelButtons.SuspendLayout();
            panelLogger.SuspendLayout();
            SuspendLayout();
            //
            // panelHeader
            //
            panelHeader.Angle = 90F;
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.EndColor = Color.FromArgb(27, 32, 60);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(30, 18, 30, 18);
            panelHeader.Size = new Size(920, 110);
            panelHeader.StartColor = Color.FromArgb(58, 123, 213);
            panelHeader.TabIndex = 0;
            //
            // lblSubtitle
            //
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(210, 218, 235);
            lblSubtitle.Location = new Point(33, 68);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(331, 19);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Streamline Windows 10 for performance, privacy, and ease.";
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(336, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Windows 10 Debloat Suite";
            lblTitle.Click += lblTitle_Click;
            //
            // panelStats
            //
            panelStats.BackColor = Color.FromArgb(32, 35, 45);
            panelStats.Controls.Add(lblStats);
            panelStats.Controls.Add(lblStatsTitle);
            panelStats.Dock = DockStyle.Fill;
            panelStats.Location = new Point(30, 20);
            panelStats.Margin = new Padding(0, 0, 20, 20);
            panelStats.Name = "panelStats";
            panelStats.Padding = new Padding(20, 24, 20, 20);
            panelStats.Size = new Size(310, 280);
            panelStats.TabIndex = 1;
            //
            // lblStats
            //
            lblStats.Dock = DockStyle.Fill;
            lblStats.Font = new Font("Consolas", 10F);
            lblStats.ForeColor = Color.FromArgb(210, 218, 235);
            lblStats.Location = new Point(20, 54);
            lblStats.Padding = new Padding(0, 12, 0, 0);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(270, 206);
            lblStats.TabIndex = 1;
            lblStats.Text = "Loading...";
            //
            // systemInfoTimer
            //
            systemInfoTimer.Interval = 1500;
            systemInfoTimer.Tick += UpdateSystemStats;
            //
            // layoutMain
            //
            layoutMain.BackColor = Color.Transparent;
            layoutMain.ColumnCount = 2;
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62F));
            layoutMain.Controls.Add(panelStats, 0, 0);
            layoutMain.Controls.Add(panelButtons, 1, 0);
            layoutMain.Controls.Add(panelLogger, 0, 1);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(0, 110);
            layoutMain.Name = "layoutMain";
            layoutMain.Padding = new Padding(30, 20, 30, 30);
            layoutMain.RowCount = 2;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            layoutMain.Size = new Size(920, 490);
            layoutMain.TabIndex = 2;
            layoutMain.SetRowSpan(panelButtons, 2);
            //
            // panelButtons
            //
            panelButtons.BackColor = Color.FromArgb(32, 35, 45);
            panelButtons.Controls.Add(flowButtons);
            panelButtons.Controls.Add(panelRunAll);
            panelButtons.Controls.Add(lblActionsTitle);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(360, 20);
            panelButtons.Margin = new Padding(20, 0, 0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(24, 24, 24, 24);
            panelButtons.Size = new Size(530, 450);
            panelButtons.TabIndex = 2;
            //
            // flowButtons
            //
            flowButtons.AutoScroll = true;
            flowButtons.BackColor = Color.FromArgb(28, 30, 38);
            flowButtons.FlowDirection = FlowDirection.LeftToRight;
            flowButtons.Dock = DockStyle.Fill;
            flowButtons.Location = new Point(24, 64);
            flowButtons.Name = "flowButtons";
            flowButtons.AutoScrollMargin = new Size(0, 16);
            flowButtons.Padding = new Padding(4, 0, 4, 0);
            flowButtons.Size = new Size(482, 306);
            flowButtons.TabIndex = 2;
            flowButtons.WrapContents = true;
            //
            // panelRunAll
            //
            panelRunAll.Dock = DockStyle.Bottom;
            panelRunAll.Location = new Point(24, 370);
            panelRunAll.Name = "panelRunAll";
            panelRunAll.Padding = new Padding(0, 18, 0, 18);
            panelRunAll.Size = new Size(482, 80);
            panelRunAll.TabIndex = 1;
            //
            // lblActionsTitle
            //
            lblActionsTitle.AutoSize = false;
            lblActionsTitle.Dock = DockStyle.Top;
            lblActionsTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblActionsTitle.ForeColor = Color.WhiteSmoke;
            lblActionsTitle.Location = new Point(24, 24);
            lblActionsTitle.Name = "lblActionsTitle";
            lblActionsTitle.Size = new Size(482, 40);
            lblActionsTitle.TabIndex = 0;
            lblActionsTitle.Text = "Privacy & Debloat Actions";
            lblActionsTitle.TextAlign = ContentAlignment.MiddleLeft;
            //
            // panelLogger
            //
            panelLogger.BackColor = Color.FromArgb(32, 35, 45);
            panelLogger.Controls.Add(lblLoggerTitle);
            panelLogger.Dock = DockStyle.Fill;
            panelLogger.Location = new Point(30, 290);
            panelLogger.Margin = new Padding(0, 0, 20, 0);
            panelLogger.Name = "panelLogger";
            panelLogger.Padding = new Padding(20, 24, 20, 20);
            panelLogger.Size = new Size(310, 180);
            panelLogger.TabIndex = 3;
            //
            // lblLoggerTitle
            //
            lblLoggerTitle.AutoSize = false;
            lblLoggerTitle.Dock = DockStyle.Top;
            lblLoggerTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLoggerTitle.ForeColor = Color.WhiteSmoke;
            lblLoggerTitle.Location = new Point(20, 24);
            lblLoggerTitle.Name = "lblLoggerTitle";
            lblLoggerTitle.Size = new Size(270, 28);
            lblLoggerTitle.TabIndex = 0;
            lblLoggerTitle.Text = "Activity Log";
            lblLoggerTitle.TextAlign = ContentAlignment.MiddleLeft;
            //
            // lblStatsTitle
            //
            lblStatsTitle.AutoSize = false;
            lblStatsTitle.Dock = DockStyle.Top;
            lblStatsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatsTitle.ForeColor = Color.WhiteSmoke;
            lblStatsTitle.Location = new Point(20, 24);
            lblStatsTitle.Name = "lblStatsTitle";
            lblStatsTitle.Size = new Size(270, 30);
            lblStatsTitle.TabIndex = 0;
            lblStatsTitle.Text = "System Snapshot";
            lblStatsTitle.TextAlign = ContentAlignment.MiddleLeft;
            //
            // Main
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 20, 28);
            ClientSize = new Size(920, 600);
            Controls.Add(layoutMain);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Windows 10 Debloat Suite";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelStats.ResumeLayout(false);
            layoutMain.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            panelLogger.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
