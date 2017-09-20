using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new EFDemo.DafestyEntities();
            //dataGridView1.DataSource = context.Customers.ToList();

            //var q = from x in context.Customers where x.CustomerID == "1111" select x;
            //Customer c = q.First();
            //label1.Text = c.CustomerName;
            //label1.Text = q.GetType().ToString();

            //      var q = from x in context.Customers where x.MemberRate == "A" && x.CustomerName.Substring(0,1) == "N" select x;
            //dataGridView1.DataSource = q.ToList();

            //Customer c = context.Customers.Where(x => x.CustomerID == "1111").First();
            //label1.Text = c.CustomerName;

            // List<Customer> clist = context.Customers.Where(x => x.MemberRate == "A" && x.CustomerName.Substring(0,1) == "N" ).ToList();
            //dataGridView1.DataSource = clist;

            //int count = context.Customers.Count(x => x.MemberRate == "A");
            //label1.Text = count.ToString();

            //decimal? sum  = context.Customers.Where(x => x.MemberRate == "A").Sum (y => y.AmountSpent);
            //label1.Text = sum.ToString();

            var q = from x in context.Customers select x;// select new { x.CustomerID, x.CustomerName, x.MemberRate } ;
                                                       //    Customer cccc = q.First();
            dataGridView1.DataSource = q.ToList();


            //Customer c1 = new Customer();

            //Customer c2 = new Customer();
            //Customer c3 = new Customer();

            //List<Customer> clist = new List<Customer>();
            //clist.Add(c1);
            //clist.Add(c2);
            //clist.Add(c3);

            //clist.Add(new Customer());


        }
    }
}
