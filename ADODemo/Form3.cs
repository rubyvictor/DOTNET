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
    public partial class Form3 : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmb;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conS = "data source=(local); integrated security=SSPI; initial catalog=Dafesty";
            cn = new SqlConnection(conS);

             cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "Select CustomerID, CustomerName, MemberCategory from Customers";

             da = new SqlDataAdapter(cm);
            cmb = new SqlCommandBuilder(da);

            label1.Text = cmb.GetInsertCommand().CommandText;

            ds = new DataSet();
            da.Fill(ds, "Customers");

            //  label1.Text =  ds.Tables.Count.ToString();
            // label1.Text = ds.Tables[0].TableName;
            // label1.Text = ds.Tables[0].Columns.Count.ToString();
            //     label1.Text = ds.Tables[0].Columns[1].ColumnName.ToString();
            //   label1.Text = ds.Tables[0].Columns[1].DataType.ToString();
            //label1.Text = ds.Tables[0].Rows.Count.ToString();

            //  label1.Text = ds.Tables[0].Rows[4][2].ToString();
        //    label1.Text = ds.Tables["Customers"].Rows[4]["CustomerName"].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = ds.Tables["Customers"].Rows[4]["MemberCategory"].ToString();
            MessageBox.Show("");

            ds.Tables["Customers"].Rows[4]["MemberCategory"] = "X";

            label1.Text = ds.Tables["Customers"].Rows[4]["MemberCategory"].ToString();

            da.Update(ds, "Customers");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow r = ds.Tables["Customers"].NewRow();

            r["CustomerID"] = "1007";
            r["CustomerName"] = "Venkat";
            r["MemberCategory"] = "B";

            ds.Tables["Customers"].Rows.Add(r);

            label1.Text = ds.Tables[0].Rows.Count.ToString();

            da.Update(ds, "Customers");
        }
    }
}
