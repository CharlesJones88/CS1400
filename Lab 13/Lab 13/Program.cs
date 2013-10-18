// File Prolog
// Name: charles
// CS 1400 Section 601
// Project: Lab 13
// Date: 10/15/2013 6:04:33 AM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
using System;

namespace Lab_13
{
    static class Program
    {
        static void Main()
        {
            // declare some constants for saturday and sunday
            const string SAT = "Saturday";
            const string SUN = "Sunday";
            const int FREEZING = 32;
            // declare a variable to hold user's input
            string today;
            int temp;
            // prompt the user to enter a day and get the input
            Console.Write("Please enter a day of the week, e.g. Tuesday: ");
            today = Console.ReadLine();
           
            // see if it is a work day
            if ((today != SUN && today != SAT))
            {
                //Prompt user for the tempurature if it is not Sunday or Saturday
                Console.Write("Please enter the tempurature: ");
                temp = int.Parse(Console.ReadLine());
                //see if it is above freezing
                if (temp >= FREEZING)
                {
                    
                    // it is a workday, display the go to work message
                    Console.WriteLine("Go to work.");
                }
                else
                {
                    //It is below freezing, display dress warmly message
                    Console.WriteLine("Go to work and dress warmly");
                }
            }
            else
            {
                // its not a workday, display the weekend message
                Console.WriteLine("yeah! No work today!");
            }
            Console.ReadLine();
        }//End Main()
    }//End class Program
}
