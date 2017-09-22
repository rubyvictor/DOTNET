using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new Mapping.DafestyEntities();
          Producer p =  context.Producers.Where(x => x.ProducerID == "Columbia").First();
            label1.Text = p.ProducerName;
            label2.Text = p.Website;

            Producer pp = new Producer();
            pp.ProducerID = "Singa";
            pp.ProducerName = "Singapore Movies";
            pp.Website = "www.singmovies.com.sg";

            context.Producers.Add(pp);
            context.SaveChanges();

        }
    }
}
