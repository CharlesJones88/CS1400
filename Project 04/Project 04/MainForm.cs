// File Prolog
// Name: charles
// CS 1400 Section 601
// Project: Project 04
// Date: 10/3/2013 8:07:51 AM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
using System.Windows.Forms;

namespace Project_04
{
    public partial class MainForm : Form
    {
        private SalesInvoice invoice;
        private double price;
        private int quantity;
        public MainForm()
        {
            InitializeComponent();
            invoice = new SalesInvoice();
        }
        //The exitToolStripItem_Click method
        //purpose: Closes the window.
        //Parameters: The object generating event and the event arguments.
        //Rerutns: none
        private void exitToolStripItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        //The aboutToolStripItem_Click method
        //purpose: Display message box with owner info.
        //Parameters: The object generating event and the event arguments.
        //Rerutns: none
        private void aboutToolStripItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Charles Jones\nCS1400 Section 601\nProject #4");
        }
        //The buyButton_Click method
        //purpose: button calls methods from the SalesInvoice class.
        //Parameters: The object generating event and the event arguments.
        //Rerutns: none.
        private void buyButton_Click(object sender, System.EventArgs e)
        {
            
            price = double.Parse(unitPriceTextBox.Text);
            invoice.SetPrice(price);
            quantity = int.Parse(numItemsTextBox.Text);
            invoice.SetQuantity(quantity);
            invoice.Calculate();
            MessageBox.Show(invoice.Invoice());
        }
        //The clearButton_Click method
        //purpose: Button calls methods from the SalesInvoice class to clear textbox fields.
        //Parameters: The object generating event and the event arguments.
        //Rerutns: none.
        private void clearButton_Click(object sender, System.EventArgs e)
        {
            numItemsTextBox.Text = invoice.Clear();
            unitPriceTextBox.Text = invoice.Clear();
        }
    }
}
