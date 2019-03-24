using System;
using System.Windows.Forms;

namespace CSP_Analyze
{
    public partial class NewQueryForm : Form
    {
        private DatabaseController dbController;

        public NewQueryForm(DatabaseController dbController)
        {
            InitializeComponent();
            this.dbController = dbController;
        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            string teamNumber = teamNumberTextBox.Text;
            resultsRichTextBox.Text = "";

            foreach (CspAnalyzeDataSet.matchscoutingRow row in dbController.matchscoutingDataTable.Rows)
            {
                if (row.team.ToString() == teamNumber)
                {
                    // Print match
                    string p = "Match Number: " + row.numMatch + "\nYellow/Red card: " + row.flYellow + "/" + row.flRed + "\n"
                        + "Cargoship Hatch: " + (row.auto_numShipFrontHatchSuccess + row.auto_numShipSideHatchSuccess) 
                        + "\nCargoship Cargo: " + (row.auto_numShipFrontCargoSuccess + row.auto_numShipSideCargoSuccess + row.tele_numShipFrontCargoSuccess + row.tele_numShipSideCargoSuccess)
                        + "\nRocket Hatches: " + (row.auto_numRocketHighHatchSuccess + row.auto_numRocketMidHatchSuccess + row.auto_numRocketLowHatchSuccess +
                        row.tele_numRocketHighAttempt + row.tele_numRocketMidHatchSuccess + row.tele_numRocketLowHatchSuccess) + 
                        "\nRocket Cargo: " + (row.auto_numRocketHighCargoSuccess + row.auto_numRocketMidCargoSuccess + row.auto_numRocketLowCargoSuccess +
                        row.tele_numRocketHighCargoSuccess + row.tele_numRocketMidCargoSuccess + row.tele_numRocketLowCargoSuccess) + "\nHighlight/Warning: " + row.comm_flHighlight + "/" + row.comm_flWarning + "\nCrashed: " + row.flCrashed + "\nEnd level: " + row.tele_idClimbLevel + "\n";

                    resultsRichTextBox.AppendText(p + "\n");
                }
            }
        }
    }
}
