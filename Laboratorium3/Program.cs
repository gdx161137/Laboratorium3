namespace Laboratorium3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new WF_lab3_zad1_v2.Form1());
        }
    }
}