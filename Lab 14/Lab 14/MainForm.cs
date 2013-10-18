// File Prolog
// Name: charles
// CS 1400 Section 601
// Project: Lab 14
// Date: 10/15/2013 7:06:11 AM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
using System.Windows.Forms;

namespace Lab_14
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //The exitToolStripMenu_Click method
        //purpose: Closes the window.
        //Parameters: The object generating event and the event arguments.
        //Rerutns: none
        private void exitToolStripMenu_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        //The aboutToolStripMenuItem_Click method
        //purpose: Display message box with owner info.
        //Parameters: The object generating event and the event arguments.
        //Rerutns: none
        private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Charles Jones\nCS1400 Section 601\nLab #14");
        }
        //The standardShipping method
        //purpose: Checks to see which radio button is checked.
        //Parameters: The object generating event and the event arguments.
        //Rerutns: none
        private void standardShipping(object sender, System.EventArgs e)
        {
            
            if (expressShippingButton.Checked)
            {
                MessageBox.Show("Selected Express Shipping");
            }
            if (sameDayButton.Checked)
            {
                MessageBox.Show("Selected Same-Day Shipping");
            }
        }
        //The expressShipping method
        //purpose: Checks to see which radio button is checked.
        //Parameters: The object generating event and the event arguments.
        //Rerutns: none
        private void expressShipping(object sender, System.EventArgs e)
        {
            if (standardShippingButton.Checked)
            {
                MessageBox.Show("Selected Standard Shipping");
            }
            if (sameDayButton.Checked)
            {
                MessageBox.Show("Selected Same-Day Shipping");
            }
        }
        //The sameDayShipping method
        //purpose: Checks to see which radio button is checked.
        //Parameters: The object generating event and the event arguments.
        //Rerutns: none
        private void sameDayShipping(object sender, System.EventArgs e)
        {
            if (standardShippingButton.Checked)
            {
                MessageBox.Show("Selected Standard Shipping");
            }
            if (expressShippingButton.Checked)
            {
                MessageBox.Show("Selected Express Shipping");
            }
        }
    }
}
