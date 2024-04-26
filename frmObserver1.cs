using ObserverPatternDemo;
using System;
using System.Windows.Forms;

namespace ObserverPatternDemo
{
    public partial class frmObserver1 : Form, IObserver
    {
        private Subject subject;
        public frmObserver1()
        {
            InitializeComponent();

        }

        public void Update(string data)
        {
            // Update the label with the received data
            lblData.Text = data;
        }





        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            Subject.GetInstance().Subscribe(this);
        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            Subject.GetInstance().Unsubscribe(this);
        }

        private void frmObserver1_Load(object sender, EventArgs e)
        {

        }
    }
}
