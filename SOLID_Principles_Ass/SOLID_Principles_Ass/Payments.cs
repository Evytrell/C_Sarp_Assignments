using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Ass
{
    public abstract class Payments
    {
        public abstract double Remmitances();

    }

    public class MerchantAccounts
    {
        public double TotalMerchantPayments(List<Payments> payments)
        {
            double total = 0;

            try
            {
                foreach (var money in payments)
                {
                    total += money.Remmitances();
                }
            }
            catch (Exception e)

            {
                var error = e.Message;
                
            }

            return total;
            
        }
              
    }

    public class SalesCommission : Payments
    {

        /// <summary>
        /// Merchants are to remit 5% of their profit on sales to the host platform
        /// </summary>
        public double MonthlySalesCommission { get; } = 0.03d;

        public double ProfitOnSales { get; set; }

        /// <summary>
        /// overriding the abstract method
        /// </summary>
        /// <returns></returns>

        public override double Remmitances()

        {
            return ProfitOnSales * MonthlySalesCommission;

        }
    }

    public class StoreRent : Payments
    {

        /// <summary>
        /// Merchants are to pay 2% of their monthy sales as rent to the host platform
        /// </summary>
        public double MonthlyStoreRent { get; } = 0.02d;

        public double MonthlySales { get; set;}

        public override double Remmitances()
        {
            return MonthlySales * MonthlyStoreRent;
        }
    }
          
    
}
