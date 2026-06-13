using GrocceryStoreApp.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocceryStoreApp.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shopping shopping  = new Shopping();
            System.Console.WriteLine("Symulacja logiki sklepu....");
            while (true)
            {
                System.Console.WriteLine("1.Dodaj produkt.....");
                System.Console.WriteLine("2.Usuń produkt......");
                System.Console.WriteLine("3.Wyświetl listę produktów...");
                System.Console.WriteLine("4.Wyjdź....");
                var choise  = System.Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        System.Console.WriteLine("Dodaj Produkt: ");
                        var product = System.Console.ReadLine();
                        product = product.Trim(' ');
                        shopping.addProduct(product);
                        break;
                    case "2":
                        System.Console.WriteLine("Wpisz produkt który chcesz usunąć");
                        var productToRemove = System.Console.ReadLine();
                        shopping.removeOneProduct(productToRemove);
                        break; 
                    case "3":
                        shopping.showProduct();
                        break; 
                    case "4":
                        System.Console.WriteLine("Wyjście z programu....");
                        return;
                        break;
                }

            }
        }
    }
}
