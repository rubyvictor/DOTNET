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
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlCommandBuilder cmb;
        DataSet ds;

        public Form3()
        {
            InitializeComponent();
        }

        private void RetrieveMovieTitle(object sender, EventArgs e)
        {
            string connectionString = "data source=(local);integrated security=SSPI;initial catalog=Dafesty";
            SqlConnection connect = new SqlConnection(connectionString);

            String query = "Select MovieTitle from Movies where Rating = @R";
            String rating = textBox1.Text;

            SqlCommand cmd = new SqlCommand(query,connect);
            cmd.Connection = connect;

            SqlParameter rateMovie = new SqlParameter("@R",SqlDbType.NVarChar,2);
            cmd.Parameters.Add(rateMovie);
            rateMovie.Value = rating;

            //Factory Pattern.  Create an object and return it to me, without creating using new keyword
            //Example.  string.split. instantiate an array object, without instantiating it.
            //Get reader option. Reader has one record at a time.  
            //Pointer in DB is at the line before the first record
           //STep 1: open connection
            connect.Open();
            //Step 2: execute reader
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();

            //label1.Text = rd[1].ToString();
            //Label1.Text = rd["MovieTitle"].ToString();
            while (rd.Read())
            {
                //label1.Text = rd["MovieTitle"].ToString();
                listBox1.Items.Add(rd["MovieTitle"].ToString());
            }

            rd.Close();

            connect.Close();

        }

        


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }

        public static void DatasetStructure()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void DisplayData()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }

        private void DataSetGet(object sender, EventArgs e)
        {
            //NorthWind Example 1.3

            string connectionStr = "data source=(local);integrated security=SSPI;initial catalog=NorthWind;";
            SqlConnection connect = new SqlConnection(connectionStr);

            String commandText = "Select CompanyName from Customers";

            cmd = new SqlCommand(commandText, connect);
            da = new SqlDataAdapter(cmd);
            cmb = new SqlCommandBuilder(da);

            label2.Text = cmb.GetInsertCommand().CommandText;

            ds = new DataSet();
            connect.Open();
            da.Fill(ds, "Customers");//give a name Customers of type String to the Data Table.  DataTable inside Dataset

            //listBox1.Items.Add(da.Fill(ds,"Customers"));
            //listBox1.Items.Add(ds.Tables.Count);
            //listBox1.Items.Add(ds.Tables[0].Columns.Count.ToString());
            //listBox1.Items.Add(ds.Tables[0].Columns[1].ColumnName.ToString());
            ////pick column, pick row, like a 2D array
            //listBox1.Items.Add(ds.Tables[0].Rows[0][1].ToString());
            ////Less confusing
            //listBox1.Items.Add(ds.Tables["Customers"].Rows[4]["CompanyName"].ToString());
            listBox1.Items.Add(ds.Tables["Customers"].Rows[2].ToString());
            
            //Save data to Database
            //da.Update(ds, "Customers");
            // UPDATE Customers
            // SET CustomerID = '007'
            // WHERE CompanyName='Alfreds Futterkiste';
            connect.Close();
            


        }

        private void insert(object sender, EventArgs e)
        {
            DataRow r = ds.Tables["Customers"].NewRow();
            r["CustomerID"] = "777";
            r["CompanyName"] = "ViktorLi";

            ds.Tables["Customers"].Rows.Add(r);
            label2.Text = ds.Tables[0].Rows.Count.ToString();

            da.Update(ds, "Customers");

        }
    }
}
