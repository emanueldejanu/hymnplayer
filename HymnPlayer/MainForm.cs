using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using HymnPlayer.Properties;
using Microsoft.Win32;

namespace HymnPlayer
{
    public partial class MainForm : Form
    {
        private NumericUpDown currentNumericHymnControl;
        private readonly string powerPointExePath;
        string basePath = @"d:\Kit\920 Imnuri Crestine";

        public MainForm()
        {
            InitializeComponent();
            currentNumericHymnControl = numStartHymn;
            Rectangle screenArea = Screen.PrimaryScreen.WorkingArea;
            Location = new Point(screenArea.Width - Width - 10, screenArea.Bottom - Height - 10);
            powerPointExePath = GetPowerPointExePath();
        }

        private string GetPowerPointExePath()
        {
            RegistryKey regKey =
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\powerpnt.exe");
            if (regKey == null)
                throw new FileNotFoundException("POWERPOINT");
            string filePath = regKey.GetValue(null) as string ?? string.Empty;
            if (filePath.Length == 0 || !File.Exists(filePath))
                throw new FileNotFoundException("POWERPOINT");
            return Path.GetFullPath(filePath);
        }

        private void KeyPadButtonClick(object sender, EventArgs e)
        {
            Button keyPadButton = (Button)sender;
            int number = int.Parse(keyPadButton.Text);
            try
            {
                if (currentNumericHymnControl.Text.Length == 0)
                    currentNumericHymnControl.Value = number;
                else
                    currentNumericHymnControl.Value = currentNumericHymnControl.Value * 10 + number;
            }
            catch (ArgumentOutOfRangeException)
            {
            }

        }

        private void ShowHymn(NumericUpDown numericControl)
        {
            int number = (int)numericControl.Value;
            if (number <= 0)
                MessageBox.Show(this, Resources.NoHymnSelected);
            int category = number / 100 * 100;
            string path = Path.Combine(basePath, string.Format("{0:D3}-{1:D3}", category == 0 ? 1 : category, category + 99));
            string filePath = FindHymn(path, number);
            if (!string.IsNullOrEmpty(filePath))
            {
                Process powerPoint = new Process
                {
                    StartInfo =
                    {
                        FileName = powerPointExePath,
                        Arguments = " /S " + "\"" + filePath + "\""
                    }
                };
                powerPoint.Start();
            }

        }

        private static string FindHymn(string path, int number)
        {
            var files = Directory.GetFiles(path, string.Format("{0:D3}.*.pptx", number));
            if (files.Length == 0)
                return string.Empty;
            return files[0];
        }

        private void ShowStartHymnClick(object sender, EventArgs e)
        {
            ShowHymn(numStartHymn);
        }

        private void ShowEndHymnClick(object sender, EventArgs e)
        {
            ShowHymn(numEndHymn);
        }

        private void NumericControlActivated(object sender, EventArgs e)
        {
            currentNumericHymnControl = (NumericUpDown)sender;
            currentNumericHymnControl.Select(0, currentNumericHymnControl.Text.Length);
        }
    }
}
