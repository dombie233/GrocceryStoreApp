using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocceryStoreApp.Console
{
    public class Shopping
    {
        private Dictionary<string, int> shoopingCart; 
        public Shopping()
        {
            shoopingCart  = new Dictionary<string, int>();
        }
        public void addProduct(string productName)
        {
            if (shoopingCart.ContainsKey(productName))
                shoopingCart[productName]++;
            else
                shoopingCart[productName] = 1; 
        }
        public void removeOneProduct(string productName)
        {
            if (!shoopingCart.ContainsKey(productName))
            {
                System.Console.WriteLine("Nie ma takiego produku w koszyku");
                return; 
            }
            shoopingCart[productName]--;
            if (shoopingCart[productName] == 0)
                shoopingCart.Remove(productName);
        }
        public void showProduct()
        {
            foreach (var item in shoopingCart)
            {
                System.Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

    }
}
