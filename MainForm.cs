using ObserverPatternDemo;
using System;
using System.Windows.Forms;

namespace ObserverPatternDemo
{
    public partial class MainForm : Form
    {
        private Subject subject;

        public MainForm()
        {
            InitializeComponent();
            subject = Subject.GetInstance(); // Get the shared Subject instance
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            // Update the subject with new data and notify observers
            subject.NotifyObservers(txtDataToUpdate.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
