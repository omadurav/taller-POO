using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerOPP
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }
        public override decimal ValueToPay()
        {
            decimal taxTotal = Price * (decimal)Quantity * (decimal)Tax;
            return Price * (decimal)Quantity + taxTotal ;
        }

        public override string ToString()
        {
            return $"{base.ToString()} " +
                $"\n\tMeasurement...............: {$"{Measurement:C2}",18}" +
                $"\n\tQuantity..................: {$"{Quantity:F}",18}" +
                $"\n\tPrice.....................: {$"{Price:C2}",18}" +
                $"\n\tTax.......................: {$"{Tax:P2}",18}" +
                $"\n\tValue.....................: {$"{ValueToPay():C2}",18}";
        }
    }
}
