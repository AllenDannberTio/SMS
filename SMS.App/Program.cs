using SMS.App.Presenters;
using SMS.App.Views.IViews;

namespace SMS.App
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

            IProgramView programView = new ProgramView();
            new ProgramPresenter(programView);

            Application.Run((Form)programView);
        }
    }
}