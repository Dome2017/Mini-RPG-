using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Item
    {
        public string Name { get; set; }
        public Image Picture { get; set; }
        public int Value { get; set; }
        public int Cost { get; set; }
        public Item(string name, int value, int cost, Image picture)
        {
            Name = name;
            Value = value;
            Cost = cost;
            Picture = picture;
        }
    }
}
