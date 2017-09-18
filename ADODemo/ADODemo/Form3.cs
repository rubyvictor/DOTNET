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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void RetrieveMovieTitle(object sender, EventArgs e)
        {
            string connectionString = "data source=(local);integrated security=SSPI;initial catalog=Dafesty";
            SqlConnection connect = new SqlConnection(connectionString);

            String query = "Select MovieTitle from Movies";

            SqlCommand cmd = new SqlCommand(query,connect);
            cmd.Connection = connect;
            connect.Open();
            cmd.BeginExecuteReader();
            connect.Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
