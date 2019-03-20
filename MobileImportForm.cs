using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSP_Analyze
{
    public partial class MobileImportForm : Form
    {
        private string matchNumber;

        public MobileImportForm()
        {
            InitializeComponent();
        }

        private void PullButton_Click(object sender, EventArgs e)
        {
            Log("Pulling all match " + matchNumber + " records.");

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "adb.exe",
                Arguments = "shell ls /sdcard/CSP/MATCH/",
                RedirectStandardOutput = true,
                UseShellExecute = false
            };
            process.StartInfo = startInfo;
            process.Start();

            process.WaitForExit();
            Log(process.StandardOutput.ReadToEnd());
        }

        private void Log(string message)
        {
            if (message == null)
            {
                message = "null";
            }
            else if (string.IsNullOrWhiteSpace(message))
            {
                message = "Result was empty";
            } else if (string.IsNullOrEmpty(message))
            {
                message = "Result was empty";
            }

            mobileImportTelemetry.AppendText(message + "\n");
        }

        private void MatchNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = ((TextBox)sender).Text;
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                pullButton.Enabled = false;
                return;
            }

            bool isNumeric = int.TryParse(text, out _);
            if (!isNumeric)
            {
                Log("Invalid input - must be a number");
                pullButton.Enabled = false;
                return;
            }

            matchNumber = text;
            pullButton.Enabled = true;
        }
    }
}
