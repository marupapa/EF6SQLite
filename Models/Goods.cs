using System;

namespace EF6SQLite.Models
{
    public class Goods
    {
        public int id { get; set; }
        public string goodsName { get; set; }
        public int price { get; set; } = 0;
        public int goodsType { get; set; } = 1;
    }
}

