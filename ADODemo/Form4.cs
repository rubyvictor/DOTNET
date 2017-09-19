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
    public partial class Form4 : Form
    {

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmb;
        int position = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void HandleLoad(object sender, EventArgs e)
        {
            String cnS = "data source=(local);integrated security=SSPI;initial catalog=Dafesty";
            cn = new SqlConnection(cnS);

            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "Select CustomerID, CustomerName, MemberCategory from Customers";

            da = new SqlDataAdapter(cmd);
            cmb = new SqlCommandBuilder(da);

            
            ds = new DataSet();
            da.Fill(ds, "Customers");

            textBox1.Text = ds.Tables["Customers"].Rows[0]["CustomerID"].ToString();
            textBox2.Text = ds.Tables["Customers"].Rows[0]["CustomerName"].ToString();
            textBox3.Text = ds.Tables["Customers"].Rows[0]["MemberCategory"].ToString();

            //Must set Primary Key for handleFind()
            ds.Tables[0].PrimaryKey = new DataColumn[]
            {
                ds.Tables[0].Columns["CustomerID"]
            };
        }

        //Need to change this
        private void HandleUpdate(object sender, EventArgs e)
        {
            ds.Tables["Customers"].Rows[position]["CustomerID"] = textBox1.Text.Trim();
            ds.Tables["Customers"].Rows[position]["CustomerName"] = textBox2.Text.Trim();
            ds.Tables["Customers"].Rows[position]["MemberCategory"] = textBox3.Text.Trim();
            da.Update(ds, "Customers");
        }

        // Need to change this
        private void HandleInsert(object sender, EventArgs e)
        {
            DataRow r = ds.Tables["Customers"].NewRow();

            r["CustomerID"] = textBox1.Text.Trim();
            r["CustomerName"] = textBox2.Text.Trim();
            r["MemberCategory"] = textBox3.Text.Trim();

            ds.Tables["Customers"].Rows.Add(r);

            da.Update(ds, "Customers");

            PopulateTextBox();
        }

        private void handleDelete(object sender, EventArgs e)
        {
            ds.Tables["Customers"].Rows[position].Delete();
            
            da.Update(ds, "Customers");
        }

        
        private void HandleFind(object sender, EventArgs e)
        {
            int i;

            for (i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (textBox4.Text.Trim() == ds.Tables["Customers"].Rows[i]["CustomerID"].ToString())
                break;

                
            }
            position=i;
            PopulateTextBox();
            toolStripStatusLabel1.Text = "Record: " + position;

            //String searchID = textBox4.Text.Trim();

            //SqlParameter pID = new SqlParameter("@ID", SqlDbType.NVarChar, 5);
            //cmd.Parameters.Add(pID);
            //pID.Value = searchID;

            //DataRow foundRows = ds.Tables["Customers"].Rows.Find(searchID);


            //textBox1.Text = foundRows[0].ToString();
            //textBox2.Text = foundRows[1].ToString();
            //textBox3.Text = foundRows[2].ToString();
            ////Test to see results
            //label4.Text = foundRows.ToString();

        }

        //Support MEthod
        private void PopulateTextBox()
        {
            textBox1.Text = ds.Tables[0].Rows[position]["CustomerID"].ToString();
            textBox2.Text = ds.Tables[0].Rows[position]["CustomerName"].ToString();
            textBox3.Text = ds.Tables[0].Rows[position]["MemberCategory"].ToString();
        }

        // Make a support method, DRY.  don't repeat filling up textboxes..
        private void NextButton(object sender, EventArgs e)
        {
            if (position < ds.Tables["Customers"].Rows.Count - 1)
            {
                position++;
            }
            
            PopulateTextBox();
            toolStripStatusLabel1.Text = "Record: " + position;
        }

        private void LeftButton(object sender, EventArgs e)
        {
            if (position > 0)
            {
                position--;
            }

            toolStripStatusLabel1.Text = "Record:" + position;
            
            PopulateTextBox();

        }

        private void GoToFirst(object sender, EventArgs e)
        {
            position = 0;
            PopulateTextBox();
            toolStripStatusLabel1.Text = "Record: " + position;
        }

        private void GoToLast(object sender, EventArgs e)
        {
            position = ds.Tables["Customers"].Rows.Count - 1;
            PopulateTextBox();
            toolStripStatusLabel1.Text = "Record: " + position;
        }
    }
}
