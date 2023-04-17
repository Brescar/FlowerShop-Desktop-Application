using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    public class FlowerEntry
    {
        private int key;
        private Flower flower;
        public FlowerEntry() { }
        public FlowerEntry(int key, Flower flower)
        {
            this.key = key;
            this.flower = flower;
        }
        public int Key
        {
            get { return key; }
            set { key = value; }
        }
        public Flower Flower
        {
            get { return flower; }
            set { flower = value; }
        }
    }
}
