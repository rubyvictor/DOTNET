using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace ADODemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickButtonEvent(object sender, EventArgs e)
        {
            string conS = "data source=(local);integrated security=SSPI;initial catalog=Dafesty";
            SqlConnection cn = new SqlConnection(conS);

            //COMMAND: placeholder for SQL commands
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "Update Customers set MemberCategory = 'C' where CustomerID='1000'";
            //Send the COMMAND INTO THE CONNECTION OBJECT
            cm.Connection = cn;
            //OPEN PIPELINE TO THE DB
            cn.Open();
            //FIRE THE COMMAND.  insert, delete, update, drop, - all NON QUERY methods.
            cm.ExecuteNonQuery();
            //CLOSE PIPEINE NOW
            cn.Close();

        }
    }
}
