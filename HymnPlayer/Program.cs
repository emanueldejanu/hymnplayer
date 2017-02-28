using System;
using System.IO;
using System.Windows.Forms;
using HymnPlayer.Properties;

namespace HymnPlayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form mainForm = new PlayerForm();
            /*try
            {
                mainForm = new MainForm();
            }
            catch (FileNotFoundException exception)
            {
                if (exception.Message != "POWERPOINT")
                    throw;
                MessageBox.Show(Resources.PowerPointNotFound);
                return;
            }*/

            Application.Run(mainForm);
        }
    }
}
