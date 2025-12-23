using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Varehusadministrasjon
{
    internal class ConsoleApp
    {
        Warehouse warehouse = new Warehouse();
        public ConsoleApp(Warehouse warehouse) {
            this.warehouse = warehouse;
        }

        public void Start()
        {
            while (true)
            {
            Console.WriteLine("Hei og velkommen til varehuset");
            Console.WriteLine("legg til, endre antall på lager eller vise lagerstatus");
            string input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("Ingen input");
                }
                else if (input.ToLower() == "legg til")
                {
                    Console.Clear();
                    Console.WriteLine("Navn først");
                    string name = Console.ReadLine();
                    Console.WriteLine("Så pris");
                    string stringPrice = Console.ReadLine();
                    int price = Convert.ToInt32(stringPrice);
                    Console.WriteLine("Antall i lageret");
                    string stringNumberOf = Console.ReadLine();
                    int numberOf = Convert.ToInt32(stringNumberOf);
                    Random r = new Random();
                    int randomNum = r.Next(10000);
                    string id = randomNum.ToString();
                    Product p = new Product(id, name, price);
                    StockItem stock = new StockItem(p, numberOf);
                    warehouse.AddToStock(stock);

                }
                else if (input.ToLower() == "endre antall")
                {
                    Console.Clear();
                    Console.WriteLine("Hvem skal endres antall på");
                    string which = Console.ReadLine();
                    Console.WriteLine("Opp eller ned");
                    string upOrDown = Console.ReadLine();
                    if (upOrDown.ToLower() == "opp")
                    {
                        Console.WriteLine("Hvor mye opp");
                        string numUpString = Console.ReadLine();
                        int numUp = Convert.ToInt32(numUpString);
                        warehouse.ChangeItem(which, numUp);
                    }
                    else if (upOrDown.ToLower() == "ned")
                    {
                        Console.WriteLine("Hvor mye ned");
                        string numDownString = "-" + Console.ReadLine();
                        int numDown = Convert.ToInt32(numDownString);
                        warehouse.ChangeItem(which, numDown);
                    }
                }
                else if (input.ToLower() == "lagerstatus")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------------");
                    foreach (StockItem item in warehouse.StockItems)
                    {
                        Console.WriteLine(item.product.name + " koster " + item.product.price + " og det er " + item.stockNumber + " igjen");

                    }
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine();

                }
                else if (input.ToLower() == "avslutt")
                {
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Feil input må skrive enten (legg til), (endre antall) eller (lagerstatus)");
                }
            }
        }
    }
}
