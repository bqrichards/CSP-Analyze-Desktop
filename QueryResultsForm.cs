using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSP_Analyze
{
    public partial class QueryResultsForm : Form
    {
        public QueryResultsForm(DatabaseController controller, string rawQuery)
        {
            InitializeComponent();

            // TODO - Initialize the columns of the query view


            // Use the controller and query to run a search
            numberOfRowsLabel.Text = "Number of Rows: Loading";

            Task.Run(async () =>
            {
                LinkedList<CspAnalyzeDataSet.matchscoutingRow> list = await controller.GetResultsFromQuery(rawQuery);
                numberOfRowsLabel.Invoke(new Action(() => numberOfRowsLabel.Text = "Number of Rows: " + list.Count));
                resultsDataGridView.Invoke(new Action(() => GetMatchScoutingViewerFromList(list)));
            });
        }

        private void GetMatchScoutingViewerFromList(LinkedList<CspAnalyzeDataSet.matchscoutingRow> rows)
        {
            // TODO
        }
    }
}
