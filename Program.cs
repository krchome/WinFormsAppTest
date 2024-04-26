using ObserverPatternDemo;
using System;
using System.Windows.Forms;

namespace ObserverPatternDemo
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Instantiate the forms
            MainForm mainForm = new MainForm();
            frmObserver1 observer1 = new frmObserver1();
            frmObserver2 observer2 = new frmObserver2();

            // Show all forms
            mainForm.Show();
            observer1.Show();
            observer2.Show();

            // Start the application's message loop
            Application.Run();
        }
    }
}
