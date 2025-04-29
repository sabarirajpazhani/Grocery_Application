using System;

namespace Assessments
{
    public class Mini_SuperMarket
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------ Grovery Bill Calculator ------------------");
            Console.WriteLine("||     ||    ||     ||    ||     ||     ||    ||     ||    ||");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();

            Console.WriteLine("              Choose the Items for purchasing                   ");
            Console.WriteLine("              101. Milk              - Rs.20.5                  ");
            Console.WriteLine("              102. Coconut Oil       - Rs.50.0                  ");
            Console.WriteLine("              103. Sugar             - Rs.15.5                  ");
            Console.WriteLine("              104. Salt              - Rs.20.7                  ");
            Console.WriteLine("              105. Rice              - Rs.50.0                  ");
            Console.WriteLine("              106. Butter            - Rs.30.5                  ");

            Console.WriteLine("                    For Billing Press '1'                  ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();

            Dictionary<int, double> itemsPrice = new Dictionary<int, double>();
            itemsPrice.Add(101, 20.5);
            itemsPrice.Add(102, 50.0);
            itemsPrice.Add(103, 15.5);
            itemsPrice.Add(104, 20.7);
            itemsPrice.Add(105, 50.0);
            itemsPrice.Add(106, 30.5);

            Dictionary<int, string> itemsName = new Dictionary<int, string>()
            {
                {101, "Milk" },
                {102, "Coconut Oil" },
                {103, "Sugar" },
                {104, "Salt" },
                {105, "Rice" },
                {106,"Butter" }
            };

            Dictionary<string, double> produts = new Dictionary<string, double>();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Here You can Enter the code of Items for purchasing");
            Console.ResetColor();

            int itemQuantity = 0;
            double total = 0;

            while (true)
            {
                //int code = int.Parse(Console.ReadLine());
                int code = 0;

                Start:
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Enter the Item Code / Proceed Bill Enter '1': ");
                    Console.ResetColor();

                    code = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input! Please enter a valid Code in Number digits only. \nAlphabets or symbols or Whitespace are not allowed.");
                    Console.ResetColor();
                    goto Start;
                }

                if (code == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Thank You For Purchasing");
                    Console.ResetColor();
                    break;
                }

                bool flag = false;
                int quantity = 0;
                double totalPrice = 0;


                switch (code)
                {
                    case 101:
                        
                        Console.Write($"Enter the Quantity of {itemsName[code]} : ");
                        quantity = int.Parse(Console.ReadLine());
                        totalPrice = itemsPrice[code] * quantity;
                        total += totalPrice;

                        if (produts.ContainsKey(itemsName[code]))
                        {
                            produts[itemsName[code]] += totalPrice;
                        }
                        else
                        {
                            produts.Add(itemsName[code], totalPrice);
                            flag = true;
                            
                        }

                        if (flag)
                        {
                            itemQuantity += 1;
                            flag = false;
                        }

                        quantity = 0;
                        totalPrice = 0;
                        break;

                    case 102:

                        Console.Write($"Enter the Quantity of {itemsName[code]} : ");
                        quantity = int.Parse(Console.ReadLine());
                        totalPrice = itemsPrice[code] * quantity;
                        total += totalPrice;

                        if (produts.ContainsKey(itemsName[code]))
                        {
                            produts[itemsName[code]] += totalPrice;
                        }
                        else
                        {
                            produts.Add(itemsName[code], totalPrice);
                            flag = true;
                        }

                        if (flag)
                        {
                            itemQuantity += 1;
                            flag = false;
                        }
                        break;

                    case 103:

                        Console.Write($"Enter the Quantity of {itemsName[code]} : ");
                        quantity = int.Parse(Console.ReadLine());
                        totalPrice = itemsPrice[code] * quantity;
                        total += totalPrice;

                        if (produts.ContainsKey(itemsName[code]))
                        {
                            produts[itemsName[code]] += totalPrice;
                        }
                        else
                        {
                            produts.Add(itemsName[code], totalPrice);
                            flag = true;
                        }

                        if (flag)
                        {
                            itemQuantity += 1;
                            flag = false;
                        }
                        break;

                    case 104:

                        Console.Write($"Enter the Quantity of {itemsName[code]} : ");
                        quantity = int.Parse(Console.ReadLine());
                        totalPrice = itemsPrice[code] * quantity;
                        total += totalPrice;
                        if (produts.ContainsKey(itemsName[code]))
                        {
                            produts[itemsName[code]] += totalPrice;
                        }
                        else
                        {
                            produts.Add(itemsName[code], totalPrice);
                            flag = true;
                        }

                        if (flag)
                        {
                            itemQuantity += 1;
                            flag = false;
                        }
                        break;

                    case 105:

                        Console.Write($"Enter the Quantity of {itemsName[code]} : ");
                        quantity = int.Parse(Console.ReadLine());
                        totalPrice = itemsPrice[code] * quantity;
                        total += totalPrice;
                        if (produts.ContainsKey(itemsName[code]))
                        {
                            produts[itemsName[code]] += totalPrice;
                        }
                        else
                        {
                            produts.Add(itemsName[code], totalPrice);
                            flag = true;
                        }
                        if (flag)
                        {
                            itemQuantity += 1;
                            flag = false;
                        }
                        break;

                    case 106:

                        Console.Write($"Enter the Quantity of {itemsName[code]} : ");
                        quantity = int.Parse(Console.ReadLine());
                        totalPrice = itemsPrice[code] * quantity;
                        total += totalPrice;
                        if (produts.ContainsKey(itemsName[code]))
                        {
                            produts[itemsName[code]] += totalPrice;
                        }
                        else
                        {
                            produts.Add(itemsName[code], totalPrice);
                            flag = true;
                        }
                        if (flag)
                        {
                            itemQuantity += 1;
                            flag = false;
                        }
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You Entered Worng Item Code");
                        Console.ResetColor();
                        break;
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine("Purchased Items");
            Console.WriteLine("       Items                             Quantity Cost       ");
            foreach (KeyValuePair<string, double> i in produts)
            {
                Console.WriteLine($"  {i.Key}                               {i.Value}");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------------- Total Quantity - " + itemQuantity + " ---------------------");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------- Total Amount - " + total + " -----------------------");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}