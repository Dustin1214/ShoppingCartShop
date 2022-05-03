using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ShoppingCartShop
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Xbox = 0;
                int Ps4 = 0;
                int XboxCountAfterOffer = 0;
                int Ps4CountAfterOffer = 0;
                double XboxPrice = 3950.99;
                double Ps4Price = 5999.49;
                double TotalAmount = 0;
                string SelectedOption;
                decimal VAT = 20;
                ArrayList ItemCollection = new ArrayList();
                string[] ItemList = new string[] { "" };
                ItemCount itemCount = new ItemCount();
                Calculate calculate = new Calculate();
                Offer offer = new Offer();
                Console.WriteLine("Select Option");
            option:
                Console.WriteLine("1. Non-Offer 2. Offer");
                SelectedOption = Console.ReadLine();

                if (SelectedOption == "1" || SelectedOption == "2")
                {
                    Console.WriteLine("Enter Items with comma seperation");
                    string item = Console.ReadLine();
                    ItemList = item.ToLower().Split(',');
                    object p = ItemCount.Item(ItemList, ref Xbox, ref Ps4);

                    switch (SelectedOption)
                    {
                        case "1":
                            Console.WriteLine("\n *******************************************************\n");
                            Console.WriteLine(" Number of Xboxs  : {0}\n Number of Ps4s  : {1}", Xbox, Ps4);
                            TotalAmount = calculate.CalculateTotal(Xbox, Ps4, XboxPrice, Ps4Price);
                            Console.WriteLine("\n *******************************************************\n");
                            Console.WriteLine(" Total Amount: {0}", TotalAmount);
                            break;

                        default:
                            Console.WriteLine("\n *******************************************************\n");
                            Console.WriteLine(" Number of Xboxs  : {0}\n Number of Ps4s  : {1}", Xbox, Ps4);
                            TotalAmount = calculate.CalculateTotal(Xbox, Ps4, XboxPrice, Ps4Price);
                            Console.WriteLine("\n *******************************************************\n");
                            Console.WriteLine(" Total Amount: {0}", TotalAmount);
                            break;




                    }

                }
                else
                {
                    Console.WriteLine("Select Valid Option");
                    goto option;
                }
                Console.ReadKey();

            }
            catch
            {
                Console.WriteLine("Unable to process your request, Please try again");
            }
        }
    }

    internal class Offer
    {
    }

    internal class Calculate
    {
        internal double CalculateTotal(int xbox, int ps4, double xboxPrice, double ps4Price)
        {
            throw new NotImplementedException();
        }
    }
}
