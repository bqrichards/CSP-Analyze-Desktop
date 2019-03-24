using System;
using System.Data;
using System.Windows.Forms;

namespace CSP_Analyze
{
    public partial class QueryResultsForm : Form
    {
        public BindingSource bindingSource;

        public QueryResultsForm(DatabaseController controller, string query, int table)
        {
            InitializeComponent();
            
            DataTable dataTable;
            if (table == 0)
            {
                dataTable = controller.matchscoutingDataTable.Copy();
            }
            else if (table == 1)
            {
                dataTable = controller.pitscoutingDataTable.Copy();
            }
            else
            {
                throw new ArgumentException("int table can only be 0 or 1");
            }

            bindingSource = new BindingSource
            {
                DataSource = dataTable
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
            numberOfRowsLabel.Text = "Number of Rows: " + resultsDataGridView.Rows.Count;
        }
    }
}
