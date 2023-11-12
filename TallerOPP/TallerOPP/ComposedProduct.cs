using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerOPP
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product> Products { get; set; }

        public override decimal ValueToPay()
        {
            decimal acumulate = 0;

            foreach (var product in Products)
            {
                acumulate += product.ValueToPay();
            }

            return acumulate - ((decimal)Discount * acumulate);
        }

        public override string ToString()
        {
            string descriptions = "";

            for (int i = 0; i < Products.Count; i++)
            {
                if (i == Products.Count - 1)
                {
                    descriptions += $"{Products[i].Description}";
                }
                else
                {
                    descriptions += $"{Products[i].Description}, ";
                }
            }

            return $"{base.ToString()}" +
                $"\n\tProducts..................: {$"{descriptions}",18}" +
                $"\n\tDiscount..................: {$"{Discount:P2}",18}" +
                $"\n\tValue.....................: {$"{ValueToPay():C2}",18}";
        }
    }
}
