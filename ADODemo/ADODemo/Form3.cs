﻿using System;
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
    }
}
