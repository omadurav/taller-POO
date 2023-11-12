using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerOPP
{
    public class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            
            decimal taxTotal = Price * (decimal)Tax;
            return Price + taxTotal;
        }

        public override string ToString()
        {
            return $"{base.ToString()} " +
                $"\n\tPrice.....................: {$"{Price:C2}",18}" +
                $"\n\tTax.......................: {$"{Tax:P2}",18}" +
                $"\n\tValue.....................: {$"{ValueToPay():C2}",18}";               
        }
    }
}
