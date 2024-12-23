using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_floor
{
    public class Partner
    {
        public string typeName { get; set; } = "OOO";
        public int id {get; set;} = int.MaxValue;
        public string name {get; set;} = "Компания";
        public string director {get; set;} = "Иванов Иван Иванович";
        public string phone {get; set;} = "11 11 11";
        public string adress {get; set;} = "неизвестен";
        public int rating {get; set;} = 0;
        public string inn {get; set;} = "неизвестен";
        public string email {get; set;} = "Noname@mail.com";
        public Partner() { }
    }
}
