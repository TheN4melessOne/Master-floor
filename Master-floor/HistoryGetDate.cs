using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_floor
{
    public partial class Sales
    {
        public string strDate { get; set; }

        public void GetDate()
        {
            strDate = ((DateTime)saleDate).ToString("d");
        }
    }
}
