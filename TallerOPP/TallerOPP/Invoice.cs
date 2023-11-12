using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerOPP
{
    public class Invoice : IPay
    {
        private List<Product> _products = new List<Product>();

        public Invoice() { }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public override string ToString()
        {
            string productsToPay = "";

           foreach (Product product in _products)
            {
                productsToPay += product.ToString() + "\n";
            }

            return $"RECEIPT" +
                $"\n-------------------------------------------------------" +
                $"\n{productsToPay}" +
                $"                                   ===================" +
                $"\nTotal.............................: {$"{ValueToPay():C2}",18}";
        }

        public decimal ValueToPay()
        {
            decimal total = 0;

            foreach (Product product in _products)
            {
                total += product.ValueToPay();
            }

            return total;
        }




    }
}
