using MaterialSkin;

namespace BaiTap
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

            // Create an instance of MaterialSkinManager to pass as an argument to Form1.  
            var materialSkinManager = MaterialSkinManager.Instance;
            Application.Run(new Menu(materialSkinManager));
        }
    }
}