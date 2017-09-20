using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADODemo
{
    public partial class EFDemo : Form
    {
        public EFDemo()
        {
            InitializeComponent();
        }

        private void clickButton(object sender, EventArgs e)
        {
            //DafestyEntities context = new DafestyEntities();
            //Display all customers in the dataGridView1
            //dataGridView1.DataSource = context.Customers.ToList();

            


            //Display one CustomerName in Label1
            //var qry = from x in context.Customers where x.CustomerID == "1111" select x;
            //Customer c = qry.First();
            //label1.Text = c.CustomerName;
            //label1.Text = qry.GetType().ToString();

            //var q = from x in context.Customers where x.MemberRating == "A" && x.CustomerName.Substring(0,1) == "N" select x;
            //dataGridView1.DataSource = q.ToList();
            //predicate Lambda version
            //List<Customer> cList = context.Customers.Where(x => x.MemberRating == "A" && x.CustomerName.Substring(0, 1) == "N").ToList();
            //dataGridView1.DataSource = cList;

            //predicate lambda
            //Customer c = context.Customers.Where(x => x.CustomerID == "1111").First();
            //label1.Text = c.CustomerID;

            //Advance queries.  e.g. Count
            //int count = context.Customers.Count(x => x.MemberRating == "A");
            //label1.Text = count.ToString();

            //Total it is a double but database has NULL so make decimal null (like optional)
            //decimal? sum = context.Customers.Where(x => x.MemberRating == "A").Sum(x => x.AmountSpent);
            //label1.Text = sum.ToString();

            //Anonymous CLASS new
            //FORMAT the dataGridView in design>column>collections> etc...so that design is 
            //Customised at design time.

            //var q = from x in context.Customers.OrderBy(x => x.CustomerName) select x; //select new {x.CustomerID, x.CustomerName,x.MemberRating};
            //                                                                       //Customer cTest = q.First();// won't work because class is Anonymous

            //dataGridView1.DataSource = q.ToList();


            //Anonymous OBJECT example
            //Customer c1 = new Customer();

            //Customer c2 = new Customer();

            //Customer c3 = new Customer();

            //List<Customer> cList = new List<Customer>();
            //cList.Add(c1);
            //cList.Add(c2);
            //cList.Add(c3);

            ////Anonymous OBJECT
            //cList.Add(new Customer());


            //EXERCISE WORKSHOP
            // 1.
            DafestyEntities3 context2 = new DafestyEntities3();
            //dataGridView1.DataSource = context2.Movies.ToList();
            // 2.
            //var q = from x in context2.Movies.OrderBy(x => x.MovieTitle) select x;
            //dataGridView1.DataSource = q.ToList();

            //3.
            //var q = from x in context2.Movies.OrderByDescending(x => x.RentalPrice) select x;
            //dataGridView1.DataSource = q.ToList();

            //4.
            //var q = from x in context2.Movies.Where(x => x.Rating == "R") select x;
            //dataGridView1.DataSource = q.ToList();

            //5.
            //List<Movy> movieList = (context2.Movies.Where(x => x.MovieType == "Sci-fi" && x.ProducerID == "Warner")).ToList();
            //dataGridView1.DataSource = movieList;

            //6.
            //int count = context2.Movies.Count(x => x.MovieType == "Action");
            //label1.Text = count.ToString();

            //7.
            //int? sumAction = context2.Movies.Where(x=> x.MovieType == "Action").Sum(x => x.TotalStock);
            //label1.Text = sumAction.ToString();

            //8.
            //double? avgComedy = context2.Movies.Where(x=>x.MovieType == "Comedy").Average(x => x.RentalPrice);
            //label1.Text = avgComedy.ToString();

            //9.
            //var q = from x in context2.Movies.Where(x => x.Rating == "R") select new {x.VideoCode,x.MovieTitle, x.RentalPrice };
            //dataGridView1.DataSource = q.To List();

            //10. 
            var queryGroupTotalStock = from x in context2.Movies group x by x.MovieType into g select new {g.Key, totalStock = g.Sum(z=> z.TotalStock)};



            dataGridView1.DataSource = queryGroupTotalStock.ToList();
            
            

            //11.
            //var q = from x in context2.Movies.Where(x => x.VideoCode == 5) select x;
            //var q = from x in context2.Movies.Where(x => x.VideoCode == 5) select new { x.MovieTitle, x.Rating, x.Producer.ProducerName };
            ////Movy movie = q.First();
            ////label1.Text = movie.MovieTitle + " " + movie.Rating + movie.Producer.ProducerName;
            //dataGridView1.DataSource = q.ToList();

            //12.
            //var q = from x in context2.Movies.Where(x => x.Producer.ProducerName == "Walt Disney Studio") select new {x.Producer.ProducerName,x.MovieTitle,x.MovieType};
            //dataGridView1.DataSource = q.ToList();

            //13.
            //var q = from x in context2.Movies select new { x.Rating,x.Producer.ProducerName, x.MovieTitle, x.MovieType };
            //dataGridView1.DataSource = q.ToList();

            //Extra save changes from an update: saveChanges()

            //Movy m = context2.Movies.Where(x => x.MovieTitle == "The Last Starfighter").First();
            //m.Rating = "AA";
            //context2.SaveChanges();
            //label1.Text = m.Rating + " " + m.MovieTitle;

            //Delete.  Remove()
            //context2.Movies.Remove(m);
            //context2.SaveChanges();



        }
    }
}
