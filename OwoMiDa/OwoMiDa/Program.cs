using System;

namespace OwoMiDa
{
    public class Program
        {
            private double keke;
            private double okada;
            private double smallBus;
            private double danfo;

            public double Keke
            {
                get { return keke; }
                set { keke = value; }
            }
            public double Okada
            {
                get { return okada; }
                set { okada = value; }
            }
            public double SmallBus
            {
                get { return smallBus; }
                set { smallBus = value; }
            }
            public double Danfo
            {
                get { return danfo; }
                set { danfo = value; }
            }
        }
        public class Driver

        //The driver should input his vehicle Id

        {
            public bool CheckRegistration() 
            {
                string userId;
                string idNum;
                Console.WriteLine("Please Enter your ID: ");
                userId = Console.ReadLine();
                if (userId == null || userId == " ")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public class Calculator
        {
            public double TollCalculator()
            {
                int numOfTrips;
                Driver thisDriver = new Driver();
                Console.WriteLine("How many trips have driver taken?: ");
                numOfTrips = Convert.ToInt32(Console.ReadLine());
                bool regStatus;
                double tollFee;
                double discount;
                double discountedTollFee;
                double charge;
                regStatus = thisDriver.CheckRegistration();
                Console.WriteLine("Enter vehicle type:");

                //   VehicleDescription newDriver = new VehicleDescription();

                string newVehicle = Console.ReadLine();
                if (newVehicle == "Keke" || newVehicle == "keke")
                {
                    charge = 80;
                }
                else if (newVehicle == "Okada" || newVehicle == "okada")
                {
                    charge = 50;
                }
                else if (newVehicle == "SmallBus" || newVehicle == "smallbus")
                {
                    charge = 100;
                }
                else if (newVehicle == "Danfo" || newVehicle == "Danfo" || newVehicle == "danfo")
                {
                    charge = 150;
                }
                else
                {
                    Console.WriteLine("Enter valid vehicle type");
                    charge = 0;
                }


                tollFee = numOfTrips * charge;
                if (regStatus == true)
                {
                    discount = 0.3 * tollFee;
                }
                else
                {
                    discount = 0;
                }
                discountedTollFee = (numOfTrips * charge) - discount;
                return discountedTollFee;
            }
        }

        internal class MoneyCollected
        {
            static void Main(string[] args)
            {
                for (int i = 0; i < 10; i++)
                {
                    Calculator newFee = new Calculator();
                    double myFee = newFee.TollCalculator();
                    Console.WriteLine("Your toll fee is " + myFee);
                }


            }

        }

    }
    