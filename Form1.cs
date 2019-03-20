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
        private DatabaseController dbController;
           
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs eventArgs)
        {
            dbController = new DatabaseController();
            lastUpdatedLabel.Text = "Last Updated: " + dbController.RemoteLastUpdated;
            tableComboBox.SelectedIndex = 0;
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt";
            dialog.Multiselect = true;
            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;

            string[] selectedFilenames = dialog.FileNames;
            LinkedList<string> csvMatchToImport = new LinkedList<string>();
            LinkedList<string> csvPitToImport = new LinkedList<string>();

            foreach (string filename in selectedFilenames)
            {
                string[] lines = File.ReadAllLines(filename);
                int validMatchscouting = 0, validPitScouting = 0;

                foreach (string line in lines)
                {
                    // Check if this is a valid match scouting entry
                    string[] values = line.Split(',');
                    if (values.Length == DatabaseController.MATCHSCOUTING_COLUMNS)
                    {
                        // Valid
                        validMatchscouting++;

                        // Import to database
                        csvMatchToImport.AddLast(line);
                    }
                    else if (values.Length == DatabaseController.PITSCOUTING_COLUMNS)
                    {
                        validPitScouting++;

                        csvPitToImport.AddLast(line);
                    }
                }

                Log(Path.GetFileName(filename) + " ~ Valid Match:" + validMatchscouting + ", Valid Pit:" + validPitScouting);
            }

            dbController.ImportMatchScoutingRows(csvMatchToImport);
            dbController.ImportPitScoutingRows(csvPitToImport);
        }

        public void Log(string message)
        {
            telemetryRichTextBox.AppendText(message + "\n");
        }

        private void NewQueryButton_Click(object sender, EventArgs eventArgs)
        {
            string queryName = StringPrompt();
            if (string.IsNullOrEmpty(queryName)) return;

            int fileStatus = dbController.CreateQueryFile(queryName, queryRichTextBox.Text);
            switch (fileStatus)
            {
                case DatabaseController.SUCCESS:
                    queryHeaderLabel.Text = "Current Query: " + dbController.CurrentQueryName;
                    break;
                case DatabaseController.ERROR_INVALID_FILENAME:
                    MessageBox.Show("Invalid filename", "Error", MessageBoxButtons.OK);
                    break;
                case DatabaseController.ERROR_FILE_ALREADY_EXISTS:
                    MessageBox.Show("File already exists", "Error", MessageBoxButtons.OK);
                    break;
                case DatabaseController.ERROR_INVALID_PERMISSION:
                    MessageBox.Show("No permissions to write to this location", "Error", MessageBoxButtons.OK);
                    break;
                default:
                    MessageBox.Show("An unknown error occurred", "Error", MessageBoxButtons.OK);
                    break;
            }
        }

        private void SaveQueryButton_Click(object sender, EventArgs eventArgs)
        {
            int saveStatus = dbController.SaveQueryFile(queryRichTextBox.Text);
            if (saveStatus != DatabaseController.SUCCESS) MessageBox.Show("Couldn't save query", "Error", MessageBoxButtons.OK);
        }

        private void SaveAsQueryButton_Click(object sender, EventArgs eventArgs)
        {
            NewQueryButton_Click(null, null);
        }

        private void LoadQueryButton_Click(object sender, EventArgs eventArgs)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = dbController.rootFolderPath;
                openFileDialog.Filter = "CSP Queries (*.cspq)|*.cspq";

                if (openFileDialog.ShowDialog() != DialogResult.OK) return;

                string filename = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string content = File.ReadAllText(openFileDialog.FileName);

                dbController.CurrentQueryName = filename;
                queryHeaderLabel.Text = "Current Query: " + filename;
                queryRichTextBox.Text = content;
            }
        }

        private void RunQueryButton_Click(object sender, EventArgs eventArgs)
        {
            QueryResultsForm resultsForm;
            int index = tableComboBox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Invalid Table Selected. Should be Match or Pit");
                return;
            }

            try
            {
                resultsForm = new QueryResultsForm(dbController, queryRichTextBox.Text, index);
                resultsForm.Show();
            }
            catch (EvaluateException e)
            {
                MessageBox.Show("Could not parse query: " + e.Message);
            }
        }

        private string StringPrompt()
        {
            Size size = new Size(300, 80);
            Form inputBox = new Form
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ClientSize = size,
                Text = "Query Name"
            };

            TextBox textBox = new TextBox
            {
                Size = new Size(size.Width - 10, 23),
                Location = new Point(5, 5)
            };
            inputBox.Controls.Add(textBox);

            Button okButton = new Button
            {
                DialogResult = DialogResult.OK,
                Name = "okButton",
                Size = new Size(75, 23),
                Text = "&OK",
                Location = new Point(size.Width - 80 - 80, 39)
            };
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button
            {
                DialogResult = DialogResult.Cancel,
                Name = "cancelButton",
                Size = new Size(75, 23),
                Text = "&Cancel",
                Location = new Point(size.Width - 80, 39)
            };
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;
            inputBox.ShowDialog();
            return textBox.Text;
        }

        private async void PullDatabaseButton_Click(object sender, EventArgs eventArgs)
        {
            pushDatabaseButton.Enabled = false;
            pullDatabaseButton.Enabled = false;
            Log("Pulling data from remote database");
            string result = await Task.Run(() => dbController.RemotePull());
            Log(result);
            pushDatabaseButton.Enabled = true;
            pullDatabaseButton.Enabled = true;
        }

        private async void PushDatabaseButton_Click(object sender, EventArgs eventArgs)
        {
            pushDatabaseButton.Enabled = false;
            pullDatabaseButton.Enabled = false;
            Log("Pushing data to remote database");
            string result = await Task.Run(() => dbController.RemotePush());
            Log(result);
            pushDatabaseButton.Enabled = true;
            pullDatabaseButton.Enabled = true;
        }

        private void MobileImportButton_Click(object sender, EventArgs eventArgs)
        {
            MobileImportForm importForm = new MobileImportForm();
            importForm.Show();
        }
    }
}
