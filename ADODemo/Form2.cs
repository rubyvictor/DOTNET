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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conS = "data source=(local); integrated security=SSPI; initial catalog=Dafesty";
            SqlConnection cn = new SqlConnection(conS);

            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "Select CustomerID, CustomerName, MemberCategory from Customers";

            cn.Open();
            SqlDataReader rd = cm.ExecuteReader();
            //  rd.Read(); rd.Read(); rd.Read(); rd.Read(); rd.Read();

            //     label1.Text = rd[2].ToString();
            //  label1.Text = rd["CustomerName"].ToString();

            label1.Text = "";

            while(rd.Read())
            {
                label1.Text += rd["CustomerName"].ToString() + "    " + rd["MemberCategory"].ToString()  + Environment.NewLine;
            }
           
            rd.Close();
            cn.Close();
        }
    }
}
