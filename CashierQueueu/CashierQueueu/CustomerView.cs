using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace CashierQueueu
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
        }

        private void NewUpdate(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                lblServing.Text = CashierClass.CashierQueue.Peek();
            }
            else
            {
                lblServing.Text = "_ _ _ _ _";
            }
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(NewUpdate);
            timer.Start();
        }
    }
}
