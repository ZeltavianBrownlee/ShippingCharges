using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCharges
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and intitalize variables
            double weight = 0.0;
            double shippingCharge = 0.0;
            string formatted_shippingCharge = "";

            //Prompt user for weight of package
            Console.WriteLine("Please enter the weight of your packages");
            weight = Convert.ToDouble(Console.ReadLine());


            if (weight <= 2)
            {
                shippingCharge = 1.10;

                //format the discount price to have two decimal places
                formatted_shippingCharge = string.Format("{0:0.00}", shippingCharge);

                //display the shipping charge
                Console.WriteLine("Your shipping charge is ${0}.", formatted_shippingCharge);
            }

            if (weight > 2 && weight <= 6)
            {
                shippingCharge = 2.20;

                //format the discount price to have two decimal places
                formatted_shippingCharge = string.Format("{0:0.00}", shippingCharge);

                //display the shipping charge
                Console.WriteLine("Your shipping charge is ${0}.", formatted_shippingCharge);
            }

            if (weight > 6 && weight <= 10)
            {
                shippingCharge = 3.70;

                //format the discount price to have two decimal places
                formatted_shippingCharge = string.Format("{0:0.00}", shippingCharge);

                //display the shipping charge
                Console.WriteLine("Your shipping charge is ${0}.", formatted_shippingCharge);
            }

            if (weight > 10)
            {
                shippingCharge = 3.80;

                //format the discount price to have two decimal places
                formatted_shippingCharge = string.Format("{0:0.00}", shippingCharge);

                //display the shipping charge
                Console.WriteLine("Your shipping charge is ${0}.", formatted_shippingCharge);
            }

            Console.ReadKey();
        }
    }
}
