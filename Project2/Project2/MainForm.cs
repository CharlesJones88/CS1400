// File Prolog
// Name: charlesjones
// CS 1400 Section 601
// Project: Project2
// Date: 9/17/2013 5:51:23 AM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
using System.Windows.Forms;

namespace Project2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitMenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void aboutMenuItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Charles Jones\nCS1400 Section 601\nProject Two");
        }
        //The calculateNewTimeButton_Click method
        //Purpose: To calculate the new time it will take to arrive to a destination.
        //Parameters: The object generating event and the event arguments.
        //Returns: None.
        private void calculateNewTimeButton_Click(object sender, System.EventArgs e)
        {
            const int HUN_PART = 100; //Constant used for separating hours from minutes.
            int startTime = int.Parse(oldStartTimeTextBox.Text);//Takes the text from oldStartTimeTextBox and stores it in startTime variable.
            int endTime = int.Parse(oldEndTimeTextBox.Text);//Takes the text from oldEndTimeTextBox and stores it in the endTime variable.
            int hoursOne = startTime / HUN_PART;//Separates hours from minutes on both the startTime and endTime then converting hours to minutes and adding them together.
            hoursOne = hoursOne * 60;
            int minsOne = startTime % HUN_PART;
            startTime = hoursOne + minsOne; 
            int hoursTwo = endTime / HUN_PART;
            hoursTwo = hoursTwo * 60;
            int minsTwo = endTime % HUN_PART; 
            endTime = hoursTwo + minsTwo;
            int calcTime = endTime - startTime;//initializes calcTime variable and gets the difference for the 2 hours.
            int arrivalTime = (int)(calcTime * .25);//Calculates the 25% longer that it takes to arrive and stores it, then adding the amount to the end time and converting back to hhmm format.
            arrivalTime = arrivalTime + endTime;
            int arriveHours = (arrivalTime / 60) * 100;
            int arriveMins = arrivalTime % 60;
            arrivalTime = arriveHours + arriveMins;
            newArrivalTimeTextBox.Text = arrivalTime.ToString("D4");//Outputs data to newArrivalTimeTextBox displayed in hhmm format.
        }
    }
}
