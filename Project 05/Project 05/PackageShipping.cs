using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_05
{
    class PackageShipping
    {
        private const double STANDARD_A = 3.00;
        private const double STANDARD_B = 1.45;
        private const double STANDARD_LOCATION = 2.50;
        private const double EXPRESS_A = 4.00;
        private const double EXPRESS_B = 2.50;
        private const double EXPRESS_LOCATION = 5.00;
        private const double SAME_DAY_A = 5.50;
        private const double SAME_DAY_B = 3.00;
        private const double SAME_DAY_LOCATION = 8.00;
        private const int standardShipping = 1;
        private const int expressShipping = 2;
        private const int sameDayShipping = 3;
        private double price;
        private int shipment;
        private int shippingMethod;
        private string category;
        private string location;
        public void SetShipping()
        {
            Console.Write("Please enter shipping method:\nEnter 1 - for standard shipping.\nEnter 2 - for express shipping.\nEnter 3 for same day shipping.\nType your choice (1, 2, or 3): ");// Ask user what shipping method to use.
            shippingMethod = int.Parse(Console.ReadLine());//Save user input.
            Console.Write("\nThank you.\nAre the items to be shipped in category A or category B?\nType your Choice (A or B): ");//Ask user if items to be shipped are in category A or category B
            category = Console.ReadLine();//Save user input.
            if (category == "A" || category == "a")//If user input is category A ask for item quantity.
            {
                Console.Write("\nThank you.\nHow many items are in the shipment? ");
            }
            else if (category == "B" || category == "b")//If user input is category B ask for weight.
            {
                Console.Write("\nThank you.\nWhat is the total weight for the shipment? ");
            }
            shipment = int.Parse(Console.ReadLine());//Save user input.
            Console.Write("\nThank you.\nIs the shipment going to Alaska or Hawaii (y or n)? ");//Ask user if item is going to be shipped to Alaska or Hawaii.
            location = Console.ReadLine();//Save user input.
        }
        
        public int GetShipping()
        {
            return shippingMethod;
        }
        
        public string GetCategory()
        {
            return category;
        }
        
        public int GetShipment()
        {
            return shipment;
        }

        public string GetLocation()
        {
            return location;
        }

        public void CalculateShipping()
        {
            Console.WriteLine("\nThank you ... calculating shipping costs...\n");//Determine shipping method, category, if shipping will be going to Alaska or Hawaii, then calculate the price and print out total cost of shipping and other details.
            if (shippingMethod == standardShipping)
            {
                Console.WriteLine("Standard Shipping");
                if (category == "A" || category == "a" && location == "n")
                {
                    price = shipment * STANDARD_A;
                    Console.WriteLine("{0} items\nTotal shipping cost: {1:C}", shipment, price);
                    Console.WriteLine("");
                }
                else if (category == "A" || category == "a" && location == "y")
                {
                    price = shipment * STANDARD_A + STANDARD_LOCATION;
                    Console.WriteLine("{0} items\nSurcharge: {1:C}\nTotal shipping cost: {2:C}", shipment, STANDARD_LOCATION, price);
                }
                else if (category == "B" || category == "b" && location == "n")
                {
                    price = shipment * STANDARD_B;
                    Console.WriteLine("{0} pounds\nTotal shipping cost: {1:C}", shipment, price);
                }
                else
                {
                    price = shipment * STANDARD_B + STANDARD_LOCATION;
                    Console.WriteLine("{0} pounds\nSurcharge: {1:C}\nTotal shipping cost: {2:C}", shipment, STANDARD_LOCATION, price);
                }
            }
            else if (shippingMethod == expressShipping)
            {
                Console.WriteLine("Express Shipping");
                if (category == "A" || category == "a" && location == "n")
                {
                    price = shipment * EXPRESS_A;
                    Console.WriteLine("{0} items\nTotal shipping cost: {1:C}", shipment, price);
                }
                else if (category == "A" || category == "a" && location == "y")
                {
                    price = shipment * EXPRESS_A + EXPRESS_LOCATION;
                    Console.WriteLine("{0} items\nSurcharge: {1:C}\nTotal shipping cost: {2:C}", shipment, EXPRESS_LOCATION, price);
                }
                else if (category == "B" || category == "b" && location == "n")
                {
                    price = shipment * EXPRESS_B;
                    Console.WriteLine("{0} pounds\nTotal shipping cost: {1:C}", shipment, price);
                }
                else
                {
                    price = shipment * EXPRESS_B + EXPRESS_LOCATION;
                    Console.WriteLine("{0} pounds\nSurcharge: {1:C}\nTotal shipping cost: {2:C}", shipment, EXPRESS_LOCATION, price);
                }
            }
            else
            {
                Console.WriteLine("Same Day Shipping");
                if (category == "A" || category == "a" && location == "n")
                {
                    price = shipment * SAME_DAY_A;
                    Console.WriteLine("{0} items\nTotal shipping cost: {1:C}", shipment, price);
                }
                else if (category == "A" || category == "a" && location == "y")
                {
                    price = shipment * SAME_DAY_A + SAME_DAY_LOCATION;
                    Console.WriteLine("{0} items\nSurcharge: {1:C}\nTotal shipping cost: {2:C}", shipment, SAME_DAY_LOCATION, price);
                }
                else if (category == "B" || category == "b" && location == "n")
                {
                    price = shipment * SAME_DAY_B;
                    Console.WriteLine("{0} pounds\nTotal shipping cost: {1:C}", shipment, price);

                }
                else
                {
                    price = shipment * SAME_DAY_B + SAME_DAY_LOCATION;
                    Console.WriteLine("{0} pounds\nSurcharge: {1:C}\nTotal shipping cost: {2:C}", shipment, SAME_DAY_LOCATION, price);
                }
            }
        }

    }
}
