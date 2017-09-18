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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void UpdateDB(object sender, EventArgs e)
        {
            string connectionString = "data source=(local);integrated security=SSPI;initial catalog=Dafesty";
            SqlConnection connect = new SqlConnection(connectionString);

            //String queryFormat = "Update Movies set RentalPrice = {1} where VideoCode = {0}";
            //String query = string.Format(queryFormat, VideoCode.Text, RentalPrice.Text);

            // BEware of query using concatenation which is risky due to SQL injection
            String rp = RentalPrice.Text;
            String vic = VideoCode.Text;
            String queryString = "Update Movies set RentalPrice = '" +rp+ "' where VideoCode = '" +vic+"'";
            textBox1.Text = queryString;

            SqlCommand cmd = new SqlCommand(queryString,connect);
            cmd.Connection = connect;
            connect.Open();
            cmd.BeginExecuteNonQuery();
            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "data source=(local);integrated security=SSPI;initial catalog=Dafesty";
            SqlConnection connect = new SqlConnection(connectionString);

            String queryString = "Update Movies set RentalPrice = @RP where VideoCode = @VIC";
            SqlCommand cmd = new SqlCommand(queryString, connect);
            cmd.Connection = connect;

            String rp = RentalPrice.Text;
            String vic = VideoCode.Text;

            textBox1.Text = queryString;
            
            //Use Parameters instead of concatenation

            SqlParameter pRP = new SqlParameter("@RP", SqlDbType.NVarChar, 4);
            SqlParameter pVIC = new SqlParameter("@VIC", SqlDbType.NVarChar, 4);
            cmd.Parameters.Add(pRP);
            cmd.Parameters.Add(pVIC);
            //Assign values to the inputs from textbox
            pRP.Value = rp;
            pVIC.Value = vic;


            connect.Open();
            
            cmd.BeginExecuteNonQuery();
            connect.Close();
        }
    }
}
