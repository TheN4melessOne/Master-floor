using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_floor
{
    public partial class Partners
    {
        public int discount { get; set; } = 0;
        public void Discount()
        {
            int amount = 0;

            foreach (Sales sale in Sales)
            {
                amount += (int)sale.amount;
            }

            if (amount < 10000)
            {
                discount = 0;
            }
            else 
            {
                if(amount < 50000)
                {
                    discount = 5;
                }
                else
                {
                    if (amount < 300000)
                    {
                        discount = 10;
                    }
                    else 
                    {
                        discount = 15;
                    }
                }
            }
        }
    }
}
