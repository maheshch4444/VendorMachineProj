using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Immutable;

namespace VendorMachineProj
{
    public class VendingStartup
    {

      
        public static void Main(String[] args)
        {
            List<VendingItems> itemsList =
           new List<VendingItems>(){ new VendingItems() { itemId = 1, itemName = "Cola", itemPrice = 1.00},
          new VendingItems() { itemId = 2, itemName = "Chips", itemPrice = 0.50},
          new VendingItems() { itemId = 3, itemName = "Candy", itemPrice = 0.65}, };

            string selectedval = string.Empty;
            string[] values = new string[3] { "1", "2", "3" };
            string[] coins = new string[3] { "1", "0.50", "0.65" };
            int val = 0;
            double price = 0;
            string priceVal = "";
            Console.WriteLine("   -- Welcome to Vending Machine --- ");
            Console.WriteLine(" Available Items Please choose the one option to select item ");
            for (int i = 0; i < itemsList.Count; i++)
            {
                Console.WriteLine("{0} -- {1} -- {2}", itemsList[i].itemId, itemsList[i].itemName, itemsList[i].itemPrice);
            }
            try 
            {
                selectedval = Console.ReadLine();
                if (!string.IsNullOrEmpty(selectedval) && values.Contains(selectedval))
                {
                    val = Convert.ToInt32(selectedval) - 1;
                    Console.WriteLine("{0} -- {1} -- {2}", itemsList[val].itemId, itemsList[val].itemName, itemsList[val].itemPrice);
                    Console.WriteLine("Please insert the required amount");
                    priceVal = Console.ReadLine();
                    if (!string.IsNullOrEmpty(priceVal) && coins.Contains(priceVal))
                    {
                        price = Convert.ToDouble(priceVal);
                        if (price == itemsList[val].itemPrice)
                        {
                            Console.WriteLine("Thank you for your intrest. Your Item is dispatching");
                        }
                        else if (price < itemsList[val].itemPrice)
                        {
                            Console.WriteLine("Inserted amount is less than the item price, try again");
                        }
                        else if (price > itemsList[val].itemPrice)
                        {
                            Console.WriteLine("Thank you for your intrest. Your Item is dispatching");
                            Console.WriteLine("Wait for the left amount dispatch {0}", price - itemsList[val].itemPrice);

                        }

                    }
                    else
                    {
                        Console.WriteLine("Please insert the corresponding item coins");
                    }
                }
                else
                {
                    Console.WriteLine("Please select proper item number");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error in system " + ex.ToString());
            }

           
        }
    }
}