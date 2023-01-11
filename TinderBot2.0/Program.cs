using TinderBot2._0.Licensing;

namespace TinderBot2._0
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            if (File.Exists("license.lic"))
            {
                // Live Server
                var l = new Licensing.Licensing
                {
                    Url = "https://licensing.deviar.net",
                    SoftwareId = 3
                };

                var result = l.RegisterLicense(File.ReadAllText("license.lic")).GetAwaiter().GetResult();

                if (!result)
                {
                    Application.Exit();
                }

                Application.Run(new Form1());
            }
            else
            {
                Application.Run(new ActivateLicense());
            }
        }
    }
}