using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Transactions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTransactionExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new IssueTransactionExample.DafestyEntities();

            using( System.Transactions.TransactionScope ts = new TransactionScope())
            {
                // some work

                context.SaveChanges();

                // some more work

                context.SaveChanges();

                ts.Complete();
            }



        }
    }
}
