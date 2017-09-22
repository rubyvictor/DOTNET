using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.EntityClient;
using System.Data.Objects;

namespace EF4TestsWinApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      /* EXAMPLE: 1 
       * Single Enity  
          Include Model 1 to run this
       */

      //EF4TestsEntities ent = new EF4TestsEntities();
      //Customer c = ent.Customers.First(x => x.CustomerID == "1111");
      //label1.Text = c.CustomerName;
      //c.CustomerName = DateTime.Now.TimeOfDay.ToString();
      //ent.SaveChanges();



      /* EXAMPLE: 2 
       * Entity Splitting One Entity -> Two Tables        
       * Include Model 2 to run this
       */

      //EF4TestsEntities2 ent = new EF4TestsEntities2();
      //Customer c = ent.Customers.First(x => x.CustomerID == "1111");
      //label1.Text = c.ContactPerson;
      //c.ContactPerson = c.CustomerName + DateTime.Now.TimeOfDay.ToString();
      //ent.SaveChanges();


      /* EXAMPLE: 3
       * Entity Splitting Inherited Enitity -> One Tables        
       * Include Model 3 to run this
       *  Note: 
       *  1. Customers are A Category Members and Low Customers are C Category members
       *  2. Typically all categories are to be defined, but for this eg just A & C are demonstrated
       *  3. Condition field (ie: Member Category) cannot be mapped to entity and its value is set by the Class type
       */

      //EF4TestsEntities3 ent = new EF4TestsEntities3();
      //Customer c1 = ent.Customers.First(x => x.CustomerID == "1002"); // Assume 1002 is C
      //label1.Text = c1.CustomerID + " : " + c1.GetType().ToString();

      //Customer c2 = ent.Customers.First(x => x.CustomerID == "1111"); // 1111 is A
      //label2.Text = c2.CustomerID + " : " + c2.GetType().ToString();

      //Customer c = new LowCustomer();
      //c.CustomerID = "9999";
      //c.CustomerName = "New Low Customer";
      //ent.AddToCustomers(c);
      //ent.SaveChanges();

      /* EXAMPLE: 4
       * Many to Many relationships
       * EF creates this relationships intelligently when you generate the 
       * three tables - ie: the two participating entity tables & and the link relation table
       * 
       * Include Model 4 to run this example
       */

      //EF4TestsEntities4 ent = new EF4TestsEntities4();
      //Customer c = ent.Customers.First(x => x.CustomerID == "1000");
      //label1.Text = c.CustomerName;
      //label2.Text = "";
      //foreach (Product p in c.Products)
      //{
      //  label2.Text += p.ProductID + " : " + p.ProductName + Environment.NewLine;
      //}

      //Product associateP = ent.Products.First(x => x.ProductID == "K1");
      //c.Products.Add(associateP);
      //ent.SaveChanges();


      /* EXAMPLE: 5
       * Many to Many relationships
       * EF creates this relationships intelligently when you generate the 
       * three tables - ie: the two participating entity tables & and the link relation table
       * 
       * Include Model 5 to run this example
       */

      //Model5Container context = new Model5Container();
      //TimeStampTest data = context.TimeStampTests.First(x => x.F1 == 1);
      //data.F2 = "z" + DateTime.Now.Minute;

      //MessageBox.Show("Press ok to save data");
      //context.SaveChanges();


      /* EXAMPLE: 6
       * Entity SQL sample
       * 
       * Include Model 6 to run this example
       */


      //string eSQL = "select value cust from EF4TestsEntities6.Customers as cust  where cust.CustomerID = '1111'";
      //EntityConnection eCon = new EntityConnection("metadata=res://*/Model6.csdl|res://*/Model6.ssdl|res://*/Model6.msl;provider=System.Data.SqlClient;provider connection string=\"Data Source=(local);Initial Catalog=EF4Tests;Integrated Security=True;MultipleActiveResultSets=True\"");
      //EntityCommand eCom = new EntityCommand(eSQL, eCon);

      //eCon.Open();

      //EntityDataReader eRdr = eCom.ExecuteReader(CommandBehavior.SequentialAccess);
      //eRdr.Read();
      //label1.Text = eRdr["CustomerID"].ToString();
      //label2.Text = eRdr["CustomerName"].ToString();

      //eRdr.Close();
      //eCon.Close();

      // Additiona tests

 
      //Entities ent = new Entities();
      //ProductPackList pl = ent.ProductPackLists.First<ProductPackList>(x => x.PartName == "Monitor");

      //label1.Text = pl.PartName + " belongs to " + pl.Product.ProductName;

      //Product p = ent.Products.First<Product>(y => y.ProductID == "M1");

      //label2.Text = p.ProductName + " contains: " + Environment.NewLine;

      //foreach (ProductPackList item in p.ProductPackLists)
      //{
      //  label2.Text += item.PartName + Environment.NewLine;
      //}


    }
  }
}
