using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Transactions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTransactionExample
{
    public partial class VideoIssueForm : Form
    {

        public CustomerSearchForm f1 = null;
        public VideoSearchForm f2 = null;



        public VideoIssueForm()
        {
            InitializeComponent();
        }

        private void VideoIssueForm_Load(object sender, EventArgs e)
        {
            DateDueDTP.Value = DateTime.Now.AddDays(3);
        }

        public string FindVideoNameFromCode
        {
            get
            {
                using (DafestyEntities context = new DafestyEntities())
                {
                    short searchVID = Convert.ToInt16(VideoCodeTextBox.Text);
                    try
                    {

                        return (from x in context.Movies where x.VideoCode == searchVID select x.MovieTitle).First();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                return "";
            }
        }


        private void SubmitButton_Click(object sender, EventArgs e)
    {
        DafestyEntities context = new DafestyEntities();

        using (TransactionScope ts = new TransactionScope())
        {
            short vc = Convert.ToInt16(VideoCodeTextBox.Text);
            IssueTran it = new IssueTransactionExample.IssueTran();
            
            
           
            if (checkDate(DateIssueDTP.Value.Date, DateDueDTP.Value.Date) == true)
                {
                    it.CustomerID = CIDTextBox.Text;
                    it.VideoCode = Convert.ToInt16(VideoCodeTextBox.Text);
                    it.DateIssue = DateIssueDTP.Value.Date;
                    it.DateDue = DateDueDTP.Value.Date;
                    it.Remarks = RemarksTextBox.Text;
                }
                else
                {
                    MessageBox.Show($"Please pick a date after your borrowing date: {DateIssueDTP.Value.Date.ToShortDateString()}");
                }
            
            

                //Must retrieve totalStock and numberRented before checking isMovieAvailable()



                if ((isMovieAvailable(Convert.ToInt16(totalStockBox.Text), Convert.ToInt16(NumberRentedBox.Text)) == true) && (Convert.ToInt16(NumberRentedBox.Text)<Convert.ToInt16(totalStockBox.Text)))
                {
                    it.RentalStatus = "OUT";
                } else
                {
                    MessageBox.Show($"The movie {MovieTitleTextBox.Text.ToString()} is out of stock. Please borrow another one.");
                }
            

            context.IssueTrans.Add(it);

            Movy m = context.Movies.Where(x => x.VideoCode == vc).First();
            m.NumberRented++;

            context.SaveChanges();

            ts.Complete();
        }

    }

        

        public string FindTotalStock
        {
            get
            {
                using (DafestyEntities context = new DafestyEntities())
                {
                    short searchVID = Convert.ToInt16(VideoCodeTextBox.Text);
                    try
                    {
                        return (from x in context.Movies where x.VideoCode == searchVID select x.TotalStock.ToString()).First();
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                return "";
            }
        }

        public string FindNumRented
        {
            get
            {
                using (DafestyEntities context = new DafestyEntities())
                {
                    short searchVID = Convert.ToInt16(VideoCodeTextBox.Text);
                    try
                    {
                        return (from x in context.Movies where x.VideoCode == searchVID select x.NumberRented.ToString()).First();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                return "";
            }

        }

        public string FindCustomerNameFromID
        { get
            {
                using (DafestyEntities context = new DafestyEntities())
                {
                    string searchCID = CIDTextBox.Text.Trim();
                    try
                    {

                        return (from x in context.Customers where x.CustomerID == searchCID select x.CustomerName).First();

                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                return "";
            }
        }


        // Check for stocks
        
        public bool isMovieAvailable(short? totalStocks, short? numberRented)
        {
            if ((totalStocks.ToString() == null) || (numberRented.ToString() == null))
            {
                throw new NotImplementedException();
            }
            else
            {
                DafestyEntities context = new DafestyEntities();
                Movy m = context.Movies.First();
                m.TotalStock = Convert.ToInt16(totalStocks);
                m.NumberRented = Convert.ToInt16(numberRented);

                if (totalStocks == numberRented)
                {
                    return false;
                }
                return true;
            }

        }

        
        public bool checkDate(DateTime issueDate, DateTime dateDue)
        {
            if ((issueDate == null) || (dateDue == null))
            {
                throw new NotImplementedException();
            } else
            {

                if (dateDue > issueDate)
                {
                    return true;
                    //dateDue = DateDueDTP.Value.Date;
                    //issueDate = DateIssueDTP.Value.Date;
                }
                else
                {
                    return false;
                }
                
            }

        }

        

        DialogResult r;
        private void CustomerLookupButton_Click(object sender, EventArgs e)
        {
            
            CustomerNameTextBox.Text = FindCustomerNameFromID;

            f1 = new CustomerSearchForm(this);


            r = f1.ShowDialog();
            //CustomerIDBox.Text = newForm.label1.Text;
            if (r == DialogResult.OK)
            {
                CIDTextBox.Text = f1.CIDValue;
                CustomerNameTextBox.Text = f1.CIDValue2;
            }

        }
        DialogResult r2;
        private void VideoLookupButtonClicked(object sender, EventArgs e)
        {
            MovieTitleTextBox.Text = FindVideoNameFromCode;
            totalStockBox.Text = FindTotalStock;
            NumberRentedBox.Text = FindNumRented;

            f2 = new VideoSearchForm(this);
            r2 = f2.ShowDialog();
            if (r2 == DialogResult.OK)
            {
                VideoCodeTextBox.Text = f2.VIDValue;
                MovieTitleTextBox.Text = f2.VIDValue2;
                totalStockBox.Text = f2.VIDValue3;
                NumberRentedBox.Text = f2.VIDValue4;
            }

        }
    }
}

