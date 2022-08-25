using System;
using System.Transactions;
using CodeFirst.Model;

namespace CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InsertDb();
            InsertDbI();
            UpdateDb();
        }

        static void InsertDb()
        {
            try
            {
                var db = new MyDbContext();  
                var buyer = new Buyers();
                buyer.BuyerId = 1;  
                buyer.UserName = "John001";
                buyer.Location = "Abuja";
                buyer.EmailAddress = "john@yahoo.com";
                buyer.PhoneNumber = "081636738474";
                db.Buyer.Add(buyer);

                var noOfInsertRows = db.SaveChanges();
                Console.WriteLine($"{noOfInsertRows} row(s) was inserted successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();

            }
        }

        static void UpdateDb()
        {
            try
            {
                var db = new MyDbContext();
                var wantedBuy = db.Buyer.Where(x => x.BuyerId == 12).FirstOrDefault();
                wantedBuy.UserName = "John";
                wantedBuy.Location = "Abuja";

                db.Update(wantedBuy);
                var updatedRows = db.SaveChanges();
                Console.WriteLine($"{updatedRows} row(s) was updated successfully");

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }


        }


        static void InsertDbI()
        {
            try
            {

                var db = new MyDbContext();
                var inv = new Invoice();
             //   inv.InvoiceId = 1;
                inv.PaymentDate = new DateTime(2022, 12, 01);
                inv.PymntType = PaymentType.Transfer;
                inv.BuyerId = 1;
                inv.Amount = 30000;

                db.Invoices.Add(inv);

                var noOfRows = db.SaveChanges();
                Console.WriteLine($"{noOfRows} row(s) was inserted");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();

            }
        }

    }
}