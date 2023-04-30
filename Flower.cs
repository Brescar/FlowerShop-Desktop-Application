using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    [Serializable]
    public class Flower : ICloneable
    {
        private string name;
        private string color;
        private double price;
        private int quantity;

        public Flower() { }

        public Flower(string name, string color, double price, int quantity)
        {
            this.name = name;
            this.color = color;
            this.price = price;
            this.quantity = quantity;
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
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
