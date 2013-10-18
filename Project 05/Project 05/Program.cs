// File Prolog
// Name: charles
// CS 1400 Section 601
// Project: Project 05
// Date: 10/15/2013 8:09:18 AM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
using System;

namespace Project_05
{
    static class Program
    {
        
        static void Main()
        {
            
            PackageShipping ship = new PackageShipping();
            ship.SetShipping();//Runs the SetShipping method.
            ship.CalculateShipping();//Runs CalculateShipping method.
            Console.ReadLine();
        }//End Main()
    }//End class Program
}
