namespace Windows_Debloat_Project
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Timer systemInfoTimer;

        // Declare buttons only – all setup handled in Main.cs
        private System.Windows.Forms.Button btnRemoveOneDrive;
        private System.Windows.Forms.Button btnRemoveTelemetry;
        private System.Windows.Forms.Button btnDisableDefenderCloud;
        private System.Windows.Forms.Button btnDisableCortana;
        private System.Windows.Forms.Button btnDisableAdID;
        private System.Windows.Forms.Button btnBlockMicrosoftIPs;
        private System.Windows.Forms.Button btnDisableFeedback;
        private System.Windows.Forms.Button btnRemoveXbox;
        private System.Windows.Forms.Button btnDisableUpdates;
        private System.Windows.Forms.Button btnRemoveSuggestions;

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
            panelStats = new Panel();
            lblStats = new Label();
            systemInfoTimer = new System.Windows.Forms.Timer(components);
            btnRemoveOneDrive = new Button();
            btnRemoveTelemetry = new Button();
            btnDisableDefenderCloud = new Button();
            btnDisableCortana = new Button();
            btnDisableAdID = new Button();
            btnBlockMicrosoftIPs = new Button();
            btnDisableFeedback = new Button();
            btnRemoveXbox = new Button();
            btnDisableUpdates = new Button();
            btnRemoveSuggestions = new Button();
            panelStats.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(300, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(287, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "\U0001fa79 Win10 Debloater By Literal";
            lblTitle.Click += lblTitle_Click;
            // 
            // panelStats
            // 
            panelStats.BackColor = Color.FromArgb(36, 36, 38);
            panelStats.BorderStyle = BorderStyle.FixedSingle;
            panelStats.Controls.Add(lblStats);
            panelStats.Location = new Point(20, 20);
            panelStats.Name = "panelStats";
            panelStats.Size = new Size(220, 220);
            panelStats.TabIndex = 1;
            // 
            // lblStats
            // 
            lblStats.Font = new Font("Consolas", 9F);
            lblStats.ForeColor = Color.White;
            lblStats.Location = new Point(10, 10);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(200, 200);
            lblStats.TabIndex = 0;
            lblStats.Text = "Loading...";
            // 
            // systemInfoTimer
            // 
            systemInfoTimer.Interval = 1500;
            systemInfoTimer.Tick += UpdateSystemStats;
            // 
            // btnRemoveOneDrive
            // 
            btnRemoveOneDrive.Location = new Point(0, 0);
            btnRemoveOneDrive.Name = "btnRemoveOneDrive";
            btnRemoveOneDrive.Size = new Size(75, 23);
            btnRemoveOneDrive.TabIndex = 0;
            // 
            // btnRemoveTelemetry
            // 
            btnRemoveTelemetry.Location = new Point(0, 0);
            btnRemoveTelemetry.Name = "btnRemoveTelemetry";
            btnRemoveTelemetry.Size = new Size(75, 23);
            btnRemoveTelemetry.TabIndex = 0;
            // 
            // btnDisableDefenderCloud
            // 
            btnDisableDefenderCloud.Location = new Point(0, 0);
            btnDisableDefenderCloud.Name = "btnDisableDefenderCloud";
            btnDisableDefenderCloud.Size = new Size(75, 23);
            btnDisableDefenderCloud.TabIndex = 0;
            // 
            // btnDisableCortana
            // 
            btnDisableCortana.Location = new Point(0, 0);
            btnDisableCortana.Name = "btnDisableCortana";
            btnDisableCortana.Size = new Size(75, 23);
            btnDisableCortana.TabIndex = 0;
            // 
            // btnDisableAdID
            // 
            btnDisableAdID.Location = new Point(0, 0);
            btnDisableAdID.Name = "btnDisableAdID";
            btnDisableAdID.Size = new Size(75, 23);
            btnDisableAdID.TabIndex = 0;
            // 
            // btnBlockMicrosoftIPs
            // 
            btnBlockMicrosoftIPs.Location = new Point(0, 0);
            btnBlockMicrosoftIPs.Name = "btnBlockMicrosoftIPs";
            btnBlockMicrosoftIPs.Size = new Size(75, 23);
            btnBlockMicrosoftIPs.TabIndex = 0;
            // 
            // btnDisableFeedback
            // 
            btnDisableFeedback.Location = new Point(0, 0);
            btnDisableFeedback.Name = "btnDisableFeedback";
            btnDisableFeedback.Size = new Size(75, 23);
            btnDisableFeedback.TabIndex = 0;
            // 
            // btnRemoveXbox
            // 
            btnRemoveXbox.Location = new Point(0, 0);
            btnRemoveXbox.Name = "btnRemoveXbox";
            btnRemoveXbox.Size = new Size(75, 23);
            btnRemoveXbox.TabIndex = 0;
            // 
            // btnDisableUpdates
            // 
            btnDisableUpdates.Location = new Point(0, 0);
            btnDisableUpdates.Name = "btnDisableUpdates";
            btnDisableUpdates.Size = new Size(75, 23);
            btnDisableUpdates.TabIndex = 0;
            // 
            // btnRemoveSuggestions
            // 
            btnRemoveSuggestions.Location = new Point(0, 0);
            btnRemoveSuggestions.Name = "btnRemoveSuggestions";
            btnRemoveSuggestions.Size = new Size(75, 23);
            btnRemoveSuggestions.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 30);
            ClientSize = new Size(850, 520);
            Controls.Add(lblTitle);
            Controls.Add(panelStats);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Win10 Debloater By Literal";
            panelStats.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
