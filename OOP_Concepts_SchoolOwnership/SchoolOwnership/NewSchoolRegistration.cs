using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOwnership

{
    public class NewSchoolRegistration

    {
        public int YearsOfExperience { get; set; }
        public double Account { get; set; }
   
        // This is to know if the intending school owner has enough experience to run a school
        public string CheckExperience()
        {

            if (YearsOfExperience < 10)
            {
                return "Lack of adequate experience";
            }

            else
            {
                return "Qualified to own a school";
            }

        }
        // This is know if the intending owner has enough money to manage a school
        public string CheckFinances()

        {
            if (Account < 5000000)
            {
                return "You cannot own a school due to inadequate finances";
            }

            else
            {
                return "You can proceed with other verification processes";
            }

        }
        


    }

    // This class shows a specific amount of money a school owner will remit to the government every month
    public class Returns
    {
        public double monthlyPercentage { get; } = 0.05d;
        
        public double MonthlyReturn()
        {
            double profit;

            Console.WriteLine("Enter your monthly profit");
            profit = Convert.ToDouble(Console.ReadLine());

            double moneyReturned = monthlyPercentage * profit;

            Console.WriteLine("This is the amount you will pay: " + moneyReturned);

            return moneyReturned;   

        }

         
         
    }



}
