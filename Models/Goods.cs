using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectBugrina.Models
{
    public class Goods
    {
        public int IdGoods { get; set; }
        public string GoodsName { get; set; }
        public int IdDepart { get; set; }
        public string Manufacturer { get; set; }
        public string Storage { get; set; }
        public int Price { get; set; }
        public Goods() { }
        public Goods(int IdGoods, string GoodsName, int IdDepart, string Manufacturer,
            string Storage, int Price)
        {
            this.IdGoods = IdGoods;
            this.GoodsName = GoodsName;
            this.IdDepart = IdDepart;
            this.Manufacturer = Manufacturer;
            this.Storage = Storage;
            this.Price = Price;
        }
    }
}
