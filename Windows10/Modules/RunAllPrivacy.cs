using System;
using Windows_Debloat_Project.Windows10.Modules;

namespace Windows_Debloat_Project.Windows10.Modules
{
    public static class RunAllPrivacy
    {
        public static void Execute()
        {
            RemoveTelemetry.Execute();
            DisableDefenderCloud.Execute();
            DisableCortana.Execute();
            DisableAdvertisingID.Execute();
            BlockMicrosoftIPs.Execute();
            DisableFeedback.Execute();
            RemoveXboxBloat.Execute();
            DisableWindowsUpdate.Execute();
            RemoveSuggestedApps.Execute();
        }
    }
}
