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
        private readonly int leftX = 260;
        private readonly int rightX = 540;
        private readonly int startY = 80;
        private readonly int spacing = 40;

        private Button btnRunAllPrivacy;
        private TextBox txtLogger;

        public Main()
        {
            InitializeComponent();
            SetupAllButtons();
            SetupLogger();
            Logger.LogBox = txtLogger;
            systemInfoTimer.Start();
        }

        private void SetupLogger()
        {
            txtLogger = new TextBox();
            txtLogger.Multiline = true;
            txtLogger.ScrollBars = ScrollBars.Vertical;
            txtLogger.BackColor = Color.Black;
            txtLogger.ForeColor = Color.Lime;
            txtLogger.Font = new Font("Consolas", 9F);
            txtLogger.Location = new Point(20, 360);
            txtLogger.Size = new Size(800, 120);
            txtLogger.ReadOnly = true;
            Controls.Add(txtLogger);
        }

        private void SetupAllButtons()
        {
            // Left Column
            Controls.Add(new DebloatButton("Remove OneDrive", leftX, startY + spacing * 0, btnRemoveOneDrive_Click));
            Controls.Add(new DebloatButton("Remove Telemetry", leftX, startY + spacing * 1, btnRemoveTelemetry_Click));
            Controls.Add(new DebloatButton("Disable Defender Cloud", leftX, startY + spacing * 2, btnDisableDefenderCloud_Click));
            Controls.Add(new DebloatButton("Disable Cortana", leftX, startY + spacing * 3, btnDisableCortana_Click));
            Controls.Add(new DebloatButton("Disable Windows Update", leftX, startY + spacing * 4, btnDisableUpdates_Click));

            // Right Column
            Controls.Add(new DebloatButton("Disable Advertising ID", rightX, startY + spacing * 0, btnDisableAdID_Click));
            Controls.Add(new DebloatButton("Block Microsoft IPs", rightX, startY + spacing * 1, btnBlockMicrosoftIPs_Click));
            Controls.Add(new DebloatButton("Disable Feedback", rightX, startY + spacing * 2, btnDisableFeedback_Click));
            Controls.Add(new DebloatButton("Remove Xbox Apps", rightX, startY + spacing * 3, btnRemoveXbox_Click));
            Controls.Add(new DebloatButton("Remove Suggested Apps", rightX, startY + spacing * 4, btnRemoveSuggestions_Click));

            // Run All Button
            btnRunAllPrivacy = new DebloatButton("🔥 Run All Privacy Fixes", leftX, startY + spacing * 6, btnRunAllPrivacy_Click)
            {
                Width = 540,
                Height = 40,
                BackColor = Color.DarkRed,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold)
            };
            Controls.Add(btnRunAllPrivacy);
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
