using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTransactionExample
{
    public partial class CustomerSearchForm : Form
    {
        public string CIDValue
        {
            get { return dataGridView1.CurrentRow.Cells[0].Value.ToString(); }
        }

        public string CIDValue2
        {
            get
            {
                return dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }
        public CustomerSearchForm(VideoIssueForm videoIssueForm)
        {
            InitializeComponent();
        }

        private void CustomerSearchForm_Load(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            dataGridView1.DataSource =  context.Customers.ToList();

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
          //label1.Text =  dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
