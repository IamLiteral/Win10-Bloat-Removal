using System;
using Windows_Debloat_Project.Windows10.Wrappers;

namespace Windows_Debloat_Project.Windows10.Modules
{
    public static class RunAllPrivacy
    {
        public static void Execute()
        {
            Logger.Log("🔥 Starting batch: Run All Privacy Fixes\n");

            try
            {
                Logger.Log("➡️ Executing: Remove Telemetry");
                RemoveTelemetry.Execute();

                Logger.Log("➡️ Executing: Disable Defender Cloud Features");
                DisableDefenderCloud.Execute();

                Logger.Log("➡️ Executing: Disable Cortana");
                DisableCortana.Execute();

                Logger.Log("➡️ Executing: Disable Advertising ID");
                DisableAdvertisingID.Execute();

                Logger.Log("➡️ Executing: Block Microsoft IPs");
                BlockMicrosoftIPs.Execute();

                Logger.Log("➡️ Executing: Disable Feedback Prompts");
                DisableFeedback.Execute();

                Logger.Log("➡️ Executing: Remove Xbox Bloatware");
                RemoveXboxBloat.Execute();

                Logger.Log("➡️ Executing: Configure Windows Update to notify");
                ConfigureWindowsUpdate.Execute();

                Logger.Log("➡️ Executing: Disable Activity History");
                DisableActivityHistory.Execute();

                Logger.Log("➡️ Executing: Disable Location Tracking");
                DisableLocationTracking.Execute();

                Logger.Log("➡️ Executing: Disable Background Apps");
                DisableBackgroundApps.Execute();

                Logger.Log("➡️ Executing: Disable Tailored Experiences");
                DisableTailoredExperiences.Execute();

                Logger.Log("➡️ Executing: Disable Typing Personalization");
                DisableTypingPersonalization.Execute();

                Logger.Log("➡️ Executing: Harden Start Menu Search");
                HardenSearchExperience.Execute();

                Logger.Log("➡️ Executing: Remove Suggested Apps");
                RemoveSuggestedApps.Execute();

                Logger.Log("✅ All privacy fixes applied successfully.\n");
            }
            catch (Exception ex)
            {
                Logger.Log("❌ Error during batch execution: " + ex.Message);
            }
        }
    }
}
