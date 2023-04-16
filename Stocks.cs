using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    public class Stocks
    {
        private Dictionary<int, Flower> flowers = new Dictionary<int, Flower>();
        private static int index = -1;
        public Stocks() { }
        public Stocks(List<Flower> listFlowers)
        {
            if (listFlowers == null) { throw new ArgumentNullException("List of flowers is null"); }
            foreach (Flower f in listFlowers)
            {
                if (f != null)
                {
                    ++index;
                    flowers.Add(index, (Flower)f.Clone());
                }
            }
        }
        public Stocks(Dictionary<int, Flower> flowers)
        {
            if (flowers == null) { throw new ArgumentNullException("Dictionary of flowers is null"); }
            foreach (Flower f in flowers.Values)
            {
                if (f != null)
                {
                    ++index;
                    flowers.Add(index, (Flower)f.Clone());
                }
            }
        }
        public void addFlower(Flower f)
        {
            this.flowers.Add(++index, (Flower)f.Clone());
        }
        public void removeFlower(int key)
        {
            this.flowers.Remove(key);
        }

        public Dictionary<int, Flower> Flowers
        {
            get { return flowers; }
            set 
            {
                if (value == null) throw new ArgumentNullException("value is null");
                foreach(Flower f in value.Values)
                {
                    if (f != null)
                    {
                        ++index;
                        flowers.Add(index, (Flower)f.Clone());
                    }
                }
            }
        }

    }
}
