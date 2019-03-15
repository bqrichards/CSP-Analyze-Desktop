using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSP_Analyze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt";
            dialog.Multiselect = true;
            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;

            string[] selectedFilenames = dialog.FileNames;
            foreach (string filename in selectedFilenames)
            {
                string[] lines = File.ReadAllLines(filename);
                int validImports = 0;

                foreach (string line in lines)
                {
                    // Check if this is a valid match scouting entry
                    string[] values = line.Split(',');
                    if (values.Length == DatabaseController.MATCHSCOUTING_COLUMNS)
                    {
                        // Valid
                        validImports++;

                        // TODO - import to database

                    }
                }

                Log(filename + " had " + validImports + " valid line(s) imported");
            }
        }

        private void Log(string message)
        {
            telemetryRichTextBox.AppendText(message + "\n");
        }
    }
}
