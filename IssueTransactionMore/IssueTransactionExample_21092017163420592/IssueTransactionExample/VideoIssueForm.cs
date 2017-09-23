using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Transactions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTransactionExample
{
    public partial class VideoIssueForm : Form
    {
        


        public VideoIssueForm()
        {
            InitializeComponent();
        }

        private void VideoIssueForm_Load(object sender, EventArgs e)
        {
            DateDueDTP.Value = DateTime.Now.AddDays(3);
            

            

        }
    

    private void SubmitButton_Click(object sender, EventArgs e)
    {
        DafestyEntities context = new DafestyEntities();

        using (TransactionScope ts = new TransactionScope())
        {
            short vc = Convert.ToInt16(VideoCodeTextBox.Text);
            IssueTran it = new IssueTransactionExample.IssueTran();
            it.CustomerID = CIDTextBox.Text;
            it.VideoCode = Convert.ToInt16(VideoCodeTextBox.Text);
            it.DateIssue = DateIssueDTP.Value.Date;
            it.DateDue = DateDueDTP.Value.Date;
            it.Remarks = RemarksTextBox.Text;
            it.RentalStatus = "OUT";

            context.IssueTrans.Add(it);

            Movy m = context.Movies.Where(x => x.VideoCode == vc).First();
            m.NumberRented++;

            context.SaveChanges();

            ts.Complete();
        }

    }

    
    public string FindCustomerNameFromID
        { get
            {
                using (DafestyEntities context = new DafestyEntities())
                {
                    string searchCID = CIDTextBox.Text.Trim();
                    try
                    {

                        return (from x in context.Customers where x.CustomerID == searchCID select x.CustomerName).First();

                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                return "";
            }
        }

    private void CustomerLookupButton_Click(object sender, EventArgs e)
    {
            
            CustomerNameTextBox.Text = FindCustomerNameFromID;
            
            CustomerSearchForm f = new IssueTransactionExample.CustomerSearchForm();
            //f.label1.Text = "Go to hell!";
            DialogResult r = f.ShowDialog();
            // CIDTextBox.Text = f.label1.Text;
            if (r == DialogResult.OK)
                CIDTextBox.Text = f.CIDValue;

        }
    }
}

