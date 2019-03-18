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
        private readonly DatabaseController controller;
        private string query;

        private BindingSource bindingSource;

        public QueryResultsForm(DatabaseController controller, string rawQuery)
        {
            InitializeComponent();
            this.controller = controller;
            this.query = rawQuery;
        }

        private void QueryResultsForm_Load(object sender, EventArgs eventArgs)
        {
            DataTable table = controller.matchscoutingDataTable.Copy();
            bindingSource = new BindingSource
            {
                DataSource = table
            };

            if (query != null)
            {
                bindingSource.Filter = query;
            }

            resultsDataGridView.DataSource = bindingSource;

            // Use the controller and query to run a search
            numberOfRowsLabel.Text = "Number of Rows: Loading";

            Task.Run(() =>
            {
                if (numberOfRowsLabel.InvokeRequired)
                {
                    numberOfRowsLabel.Invoke(new Action(() => numberOfRowsLabel.Text = "Number of Rows: " + resultsDataGridView.Rows.Count));
                }
                else
                {
                    numberOfRowsLabel.Text = "Number of Rows: " + resultsDataGridView.Rows.Count;
                }
            });
        }
    }
}
