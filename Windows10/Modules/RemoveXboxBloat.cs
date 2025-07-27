namespace Windows_Debloat_Project.Windows10.Modules
{
    public class RemoveXboxBloat
    {
        public static void Execute()
        {
            string script = @"
Get-AppxPackage *xbox* | Remove-AppxPackage
";
            var result = Windows_Debloat_Project.Windows10.Wrappers.ExecutionHelper.RunPowerShell(script);
            Console.WriteLine("Xbox apps removed:\n" + result);
        }
    }
}
