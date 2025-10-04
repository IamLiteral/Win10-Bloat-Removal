using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Windows_Debloat_Project.Windows10.Modules;
using Windows_Debloat_Project.Windows10.Components;
using Windows_Debloat_Project.Windows10.Wrappers;

namespace Windows_Debloat_Project
{
    public partial class Main : Form
    {
        private Button btnRunAllPrivacy;
        private TextBox txtLogger;

        public Main()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetupAllButtons();
            SetupLogger();
            Logger.LogBox = txtLogger;
            systemInfoTimer.Start();
        }

        private void SetupLogger()
        {
            txtLogger = new TextBox
            {
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                BackColor = Color.FromArgb(18, 20, 28),
                ForeColor = Color.FromArgb(210, 218, 235),
                Font = new Font("Consolas", 9F),
                ReadOnly = true,
                BorderStyle = BorderStyle.None,
                Dock = DockStyle.Fill,
                Margin = new Padding(0, 12, 0, 0),
                Text = "Activity log will appear here."
            };

            panelLogger.Controls.Add(txtLogger);
            panelLogger.Controls.SetChildIndex(lblLoggerTitle, 0);
            lblLoggerTitle.BringToFront();
        }

        private void SetupAllButtons()
        {
            flowButtons.SuspendLayout();

            AddActionButton("Remove OneDrive", btnRemoveOneDrive_Click);
            AddActionButton("Remove Telemetry", btnRemoveTelemetry_Click);
            AddActionButton("Disable Defender Cloud", btnDisableDefenderCloud_Click);
            AddActionButton("Disable Cortana", btnDisableCortana_Click);
            AddActionButton("Disable Windows Update", btnDisableUpdates_Click);
            AddActionButton("Disable Advertising ID", btnDisableAdID_Click);
            AddActionButton("Block Microsoft IPs", btnBlockMicrosoftIPs_Click);
            AddActionButton("Disable Feedback", btnDisableFeedback_Click);
            AddActionButton("Remove Xbox Apps", btnRemoveXbox_Click);
            AddActionButton("Remove Suggested Apps", btnRemoveSuggestions_Click);

            flowButtons.ResumeLayout();

            btnRunAllPrivacy = new Button
            {
                Text = "Run All Privacy Fixes",
                Dock = DockStyle.Fill,
                Height = 48,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                BackColor = Color.FromArgb(220, 76, 70),
                ForeColor = Color.White,
                Cursor = Cursors.Hand,
                Margin = new Padding(0)
            };

            btnRunAllPrivacy.FlatAppearance.BorderSize = 0;
            btnRunAllPrivacy.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 99, 92);
            btnRunAllPrivacy.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 70, 64);
            btnRunAllPrivacy.Click += btnRunAllPrivacy_Click;

            panelRunAll.Controls.Add(btnRunAllPrivacy);
        }

        private void AddActionButton(string text, EventHandler handler)
        {
            var button = new DebloatButton(text, handler)
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                MaximumSize = new Size(220, 44),
            };

            flowButtons.Controls.Add(button);
        }

        private void Confirm(Action action, string message)
        {
            try
            {
                Logger.Log("Running: " + message);
                action();
                Logger.Log("✔ Success: " + message);
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Logger.Log("❌ Error: " + ex.Message);
                MessageBox.Show($"Error: {ex.Message}", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button Handlers (single-purpose)
        private void btnRemoveOneDrive_Click(object sender, EventArgs e) => Confirm(RemoveOneDrive.Execute, "OneDrive removed.");
        private void btnRemoveTelemetry_Click(object sender, EventArgs e) => Confirm(RemoveTelemetry.Execute, "Telemetry removed.");
        private void btnDisableDefenderCloud_Click(object sender, EventArgs e) => Confirm(DisableDefenderCloud.Execute, "Defender Cloud disabled.");
        private void btnDisableCortana_Click(object sender, EventArgs e) => Confirm(DisableCortana.Execute, "Cortana disabled.");
        private void btnDisableAdID_Click(object sender, EventArgs e) => Confirm(DisableAdvertisingID.Execute, "Ad ID disabled.");
        private void btnBlockMicrosoftIPs_Click(object sender, EventArgs e) => Confirm(BlockMicrosoftIPs.Execute, "Microsoft IPs blocked.");
        private void btnDisableFeedback_Click(object sender, EventArgs e) => Confirm(DisableFeedback.Execute, "Feedback disabled.");
        private void btnRemoveXbox_Click(object sender, EventArgs e) => Confirm(RemoveXboxBloat.Execute, "Xbox apps removed.");
        private void btnDisableUpdates_Click(object sender, EventArgs e) => Confirm(DisableWindowsUpdate.Execute, "Windows Update disabled.");
        private void btnRemoveSuggestions_Click(object sender, EventArgs e) => Confirm(RemoveSuggestedApps.Execute, "Suggestions removed.");

        // Run All Handler
        private void btnRunAllPrivacy_Click(object sender, EventArgs e)
        {
            Confirm(RunAllPrivacy.Execute, "All privacy fixes applied.");
        }

        private void UpdateSystemStats(object sender, EventArgs e)
        {
            try
            {
                string os = Environment.OSVersion.VersionString;
                string cpu = Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER") ?? "Unknown CPU";
                string ram = $"{Math.Round(new ComputerInfo().TotalPhysicalMemory / (1024.0 * 1024 * 1024), 1)} GB";
                string disk = $"{Math.Round(new DriveInfo("C").TotalSize / (1024.0 * 1024 * 1024), 1)} GB";

                lblStats.Text =
                    $"🖥 OS: {os}\n" +
                    $"🧠 CPU: {cpu.Split('@')[0].Trim()}\n" +
                    $"💾 RAM: {ram}\n" +
                    $"📁 Disk: {disk}";
            }
            catch (Exception ex)
            {
                lblStats.Text = $"Error: {ex.Message}";
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
