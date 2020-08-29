using Microsoft.VisualBasic;
using System;

namespace PA1_Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage gar = new Garage();
            Console.WriteLine("Welcome to the Garage.\n");
            gar.peruse();
        }
    }

    class Garage
    {
        private Vehicle[] cars;
        public void peruse()
        {
            int choice = 0;
            while (choice != 5)
            {
                options();
                choice = choose(Convert.ToInt32(Console.ReadLine()));
            }
        }
        private void options()
        {
            Console.WriteLine("How can I help ya?\n" +
                              "1. See what's in store.\n" +
                              "2. Store a vehicle.\n" +
                              "3. Check a vehicle's price.\n" +
                              "4. Take one for a spin.\n" +
                              "5. Exit the Garage.\n");
        }

        private int choose(int choice)
        {
            if (choice == 1)
            {
                printStored();
            }
            else if (choice == 2)
            {
                addVehicle();
            }
            else if (choice == 3)
            {

            }
            else if (choice == 4)
            {

            }
            else if (choice == 5)
                Console.WriteLine("Have a nice day.");
            else
                Console.WriteLine("That wasn't an option!\n");

            return choice;
        }

        private void printStored()
        {
            if (cars == null)
                Console.WriteLine("The Garage is currently empty.\n");
            else
                foreach (Vehicle i in cars)
                    i.printInfo();
        }

        private void addVehicle()
        {
            Console.WriteLine("What sort of vehicle is it?\n" +
                              "1. Minivan\n" +
                              "2. SchoolBus\n" +
                              "3. Skateboard\n");

            int vehicle = Convert.ToInt32(Console.ReadLine());

            if (vehicle == 1)
            {
                Console.WriteLine("What's the year make model? (in that order)\n");
                string[] info = Console.ReadLine().Split(' ');
                Minivan van = new Minivan(Convert.ToInt32(info[0]), info[1], info[2]);
                cars = new Minivan[] { van };
            }
            else if (vehicle == 2)
            {

            }
        }
    }

    abstract class Vehicle
    {
        protected string Make { get { return Make; } set { Make = value; } }
        protected string Model { get { return Model; } set { Model = value; } }
        protected int Year { get { return Year; } set { Year = value; } }
        protected double Price { get { return Price; } set { Price = value; } }

        public Vehicle(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }
        public virtual double checkPrice()
        {
            return Price;
        }
        public virtual void printInfo()
        {
            Console.WriteLine("This vehicle is a " + Year + " " + Make + " " + Model + ".\n");
        }
        public virtual void testDrive()
        {
            Console.WriteLine("Brrrrrrr.");
        }
    }

    class Minivan : Vehicle
    {
        public Minivan(int Year, string Make, string Model) : base(Year, Make, Model) { }
        public override double checkPrice()
        {
            return 35000.00;
        }
        public override void printInfo()
        {
            Console.WriteLine("This minivan is a " + Year + " " + Make + " " + Model + ".\n");
        }
        public override void testDrive()
        {
            Console.WriteLine("Vrrrooom.. Reminds you of family vacations past...");
        }
    }
}
