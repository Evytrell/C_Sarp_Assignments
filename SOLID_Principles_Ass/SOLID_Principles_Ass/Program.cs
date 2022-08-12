namespace SOLID_Principles_Ass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input your monthly sales profit");
            double profitOnSales = double.Parse(Console.ReadLine());

            Console.WriteLine("Input your monthly sales amount");
            double monthlySales = double.Parse(Console.ReadLine());

            var payments = new List<Payments>();
            var merchantAccount = new MerchantAccounts();    

            payments.Add(new SalesCommission() { ProfitOnSales = profitOnSales});
            payments.Add(new StoreRent() { MonthlySales = monthlySales });

            double merchantAmount = merchantAccount.TotalMerchantPayments(payments);

            Console.WriteLine("This is the total money you will be paying for the month: " + merchantAmount);


        }


    }
}