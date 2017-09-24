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
    public partial class VideoSearchForm : Form
    {
        public VideoSearchForm(VideoIssueForm videoIssueForm)
        {
            InitializeComponent();
        }

        private void VideoSearchFormLoad(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            dataGridView1.DataSource = context.Movies.ToList();
        }

        public string VIDValue
        {
            get
            {
                return dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
        }

        public string VIDValue2
        {
            get
            {
                return dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        public string VIDValue3
        {
            get
            {
                return dataGridView1.CurrentRow.Cells[8].Value.ToString();
            }
        }

        public string VIDValue4
        {
            get
            {
                return dataGridView1.CurrentRow.Cells[9].Value.ToString();
            }
        }

        private void ClickCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ClickOK(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        
    }
}
