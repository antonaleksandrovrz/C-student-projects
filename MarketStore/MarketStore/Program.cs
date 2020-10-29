using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int number = 0;

            //Type of card
            do
            {
                Console.WriteLine("What kind of car do you have?");
                Console.WriteLine("1.Bronze , 2.Silver, 3.Gold");
                Console.Write("Enter card type:");
                try
                {
                    number = int.Parse(Console.ReadLine());

                    if(!(1 <= number && number <= 3)) {
                        Console.WriteLine("Try with correct value!");
                    }
                }

                catch
                {
                    Console.WriteLine("Incorrect format!");
                }

            } while (!(1 <= number && number <=3));

            //Turnover
            float mockData = -1;
            do
            {
                Console.Write("Enter mock data: $");

                try
                {
                    mockData = float.Parse(Console.ReadLine());

                    if (mockData < 0)
                    {
                        Console.WriteLine("The value cannot be negative!");
                    }
                }

                catch
                {
                    Console.WriteLine("Incorrect format!");
                }

            } while (!(mockData > 0));

            float purchValue = -1;

            //Purchase value
            do
            {
                Console.Write("Enter purchase value: $");

                try
                {
                    purchValue = float.Parse(Console.ReadLine());

                    if (purchValue < 0)
                    {
                        Console.WriteLine("The value cannot be negative!");
                    }
                }

                catch
                {
                    Console.WriteLine("Incorrect format!");
                }

            } while (!(mockData > 0));

            //Create object 1.Bronze , 2.Silver, 3.Gold
            switch (number)
            {
                case 1:
                    {
                        Bronze bronzeCard = new Bronze(mockData, purchValue);
                        bronzeCard.PrintReceipt();
                        break;
                    }
                case 2:
                    {
                        Silver silverCard = new Silver(mockData, purchValue);
                        silverCard.PrintReceipt();
                        break;
                    }
                case 3:
                    {
                        Gold goldCard = new Gold(mockData, purchValue);
                        goldCard.PrintReceipt();
                        break;
                    }

            }

        }
    }
}