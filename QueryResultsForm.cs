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

        public BindingSource bindingSource;

        public QueryResultsForm(DatabaseController controller, string query)
        {
            InitializeComponent();
            this.controller = controller;

            DataTable table = controller.matchscoutingDataTable.Copy();
            bindingSource = new BindingSource
            {
                DataSource = table
            };

            try
            {
                bindingSource.Filter = query;
            }
            catch (SyntaxErrorException e)
            {
                MessageBox.Show("Syntax Error: " + e.Message);
            }
        }

        private void QueryResultsForm_Load(object sender, EventArgs eventArgs)
        {
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
