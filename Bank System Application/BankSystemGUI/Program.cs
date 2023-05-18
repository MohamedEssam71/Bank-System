namespace BankSystemGUI
{
    internal static class Program
    {
        public static string ConString = "Data Source=DESKTOP-V6573KH;Initial Catalog=BankSystem;Integrated Security=True";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            Application.Run(new MainPage());
        }
    }
}