using System;

namespace PA1_Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            Console.WriteLine("Welcome to the Garage.\n\n");

            while (choice != 5)
            {
                Console.WriteLine("How can I help ya?\n" +
                                  "1. Store a vehicle.\n" +
                                  "2. Check a vehicle's price.\n" +
                                  "3. Inspect a vehicle.\n" +
                                  "4. Take one for a spin.\n" +
                                  "5. Exit the Garage.\n");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {

                }
                else if (choice == 2)
                {

                }
                else if (choice == 3)
                {

                }
                else if (choice == 4)
                {

                }
                else if (choice == 5)
                    Console.WriteLine("");
            }
        }
    }

    abstract class Vehicle
    {
        private string Make { get; set; }
        private string Model { get; set; }
        private int Year { get; set; }
        private float Price { get; set; }

        public virtual float checkPrice()
        {
            return Price;
        }
        public virtual void printInfo()
        {
            Console.WriteLine("Model: " + Year + Make + Model);
        }
        public virtual void testDrive()
        {
            Console.WriteLine("Brrrrrrr.");
        }
    }

    class Minivan : Vehicle
    {
        public override float checkPrice()
        {

        }
        public override void printInfo()
        {

        }
    }
}
