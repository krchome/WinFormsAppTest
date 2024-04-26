using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using ObserverPatternDemo;
using System.Xml.Linq;

namespace ObserverPatternDemo
{
    public partial class frmObserver2 : Form, IObserver
    {
        private Subject subject;
        public frmObserver2()
        {
            InitializeComponent();
            
        }

        public void Update(string data)
        {
            // Update the textbox with the received data
            txtData.Text = data;
        }

      

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            Subject.GetInstance().Subscribe(this);
        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            Subject.GetInstance().Unsubscribe(this);
        }
    }
}

