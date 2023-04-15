using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    public class Flower : ICloneable
    {
        private string name;
        private string color;
        private double price;

        public Flower(string name, string color, double price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
