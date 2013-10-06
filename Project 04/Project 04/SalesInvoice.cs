using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_04
{
    class SalesInvoice
    {
        private int quantity;
        private double price;
        private double netPrice;
        private double total;
        private double stateTax;
        private double localTax;
        private const double STATE_SALES_TAX = 7.45;
        private const double LOCAL_SALES_TAX = 2.5;
        private const double PERCENT = 100;
        //the Clear method
        //purpose: clear text in textboxes.
        //Parameters: none
        //Returns: an empty string value.
        public string Clear()
        {
            return string.Empty;
        }
        //the SetPrice method.
        //purpose: setter for price.
        //Parameters: a double newPrice
        //Returns: none
        public void SetPrice(double newPrice)
        {
            price = newPrice;
        }
        //the GetPrice method.
        //purpose: getter for price.
        //Parameters: none
        //Returns: the price as a double
        public double GetPrice()
        {
            return price;
        }
        //The SetQuantity method
        //purpose: setter for the quantity.
        //Parameters: an int newQuantity
        //Returns: none
        public void SetQuantity(int newQuantity)
        {
            quantity = newQuantity;
        }
        //The GetQuantity method
        //purpose: getter for quantity.
        //Parameters: none
        //Returns: the quantity as an int.
        public int GetQuantity()
        {
            return quantity;
        }
        //The Calculate method
        //purpose: Calculate the net price, state and local taxes, and total.
        //Parameters: none
        //Returns: none
        public void Calculate()
        {
            netPrice = quantity * price;
            stateTax = netPrice * STATE_SALES_TAX / PERCENT;
            localTax = netPrice * LOCAL_SALES_TAX / PERCENT;
            total = netPrice + stateTax + localTax;
        }
        //The GetNetPrice method
        //purpose: getter for netPrice.
        //Parameters: none
        //Rerutns: netPrice as a double.
        public double GetNetPrice()
        {
            return netPrice;
        }
        //The GetStateTax method
        //purpose: getter for stateTax.
        //Parameters: none
        //Rerutns: stateTax as a double.
        public double GetStateTax()
        {
            return stateTax;
        }
        //The GetLocalTax method
        //purpose: getter for localTax.
        //Parameters: none
        //Rerutns: localTax as a double.
        public double GetLocalTax()
        {
            return localTax;
        }
        //The GetTotal method
        //purpose: getter for total.
        //Parameters: none
        //Rerutns: total as a double.
        public double GetTotal()
        {
            return total;
        }
        //The Invoice method
        //purpose: Return back the calculations in a string.
        //Parameters: none
        //Rerutns: a formated string.
        public string Invoice()
        {
            return string.Format("Sales Ticket...\nQuantity: {0} units\nUnit Price: {1:C} each\n-----------------------\nNet Price: {2:C}\nState Sales Tax: {3:C}\nLocal Sales Tax: {4:C}\nPlease pay: {5:C}", quantity, price, netPrice, stateTax, localTax, total);
        }
    }
}
