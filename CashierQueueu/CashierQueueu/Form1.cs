using System.Drawing.Text;

namespace CashierQueueu
{
    public partial class Form1 : Form
    {
        private CashierClass cashier;
        public Form1()
        {
            InitializeComponent();
            cashier = new CashierClass();
            new CashierWindowQueueForm().Show();
            new CustomerView().Show();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}