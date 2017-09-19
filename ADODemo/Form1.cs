using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADODemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conS = "data source=(local); integrated security=SSPI; initial catalog=Dafesty";
            SqlConnection cn = new SqlConnection(conS);
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "Update Customers set MemberCategory ='C' where CustomerID='1000'";
            cm.Connection = cn;

            cn.Open();
            cm.ExecuteNonQuery();
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conS = "data source=(local); integrated security=SSPI; initial catalog=Dafesty";
            SqlConnection cn = new SqlConnection(conS);
            SqlCommand cm = new SqlCommand();

            string cid = textBox1.Text;
            string mc = textBox2.Text;

            string sql = "Update Customers set MemberCategory = '" + mc + "' where CustomerID='" +cid + "'";
            textBox3.Text = sql;
            cm.CommandText = sql;
cm.Connection = cn;

            cn.Open();
          int i =  cm.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
            cn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conS = "data source=(local); integrated security=SSPI; initial catalog=Dafesty";
            SqlConnection cn = new SqlConnection(conS);
            SqlCommand cm = new SqlCommand();

            string cid = textBox1.Text;
            string mc = textBox2.Text;

            string sql = "Update Customers set MemberCategory =@MC where CustomerID=@CID";

            cm.CommandText = sql;
            cm.Connection = cn;

            SqlParameter pMC = new SqlParameter("@MC", SqlDbType.NVarChar, 2);
            SqlParameter pCID = new SqlParameter("@CID", SqlDbType.NVarChar, 4);

            cm.Parameters.Add(pMC);
            cm.Parameters.Add(pCID);

            cn.Open();
            pMC.Value = mc;
            pCID.Value = Convert.ToString(cid);

            cm.ExecuteNonQuery();
            cn.Close();
        }
    }
}
