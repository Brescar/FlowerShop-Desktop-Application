using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    public class ExperimentalStocks
    {
        private List<Flower> flowers = new List<Flower>();
        private Dictionary<Flower, int> Dflowers = new Dictionary<Flower, int>();

        public ExperimentalStocks() { }
        public ExperimentalStocks(List<Flower> flowers)
        {
            if (flowers == null)
            {
                return;
            }
            Flower auxFlower;

            foreach (Flower flower in flowers)
            {
                if (flower != null) {
                    auxFlower = (Flower)flower.Clone();
                    flowers.Add(auxFlower);
                    if (Dflowers.ContainsKey(flower) == false)
                    {
                        Dflowers.Add(flower, flowers.IndexOf(auxFlower));
                    }
                }
            }
        }
        public void addFlower(Flower flower)
        {
            if (flower != null && flowers.Contains(flower) == false)
            {
                this.flowers.Add(flower);
                Dflowers.Add(flower, flowers.IndexOf(flower));
            }
        }
        public void removeFlower(Flower flower)
        {
            //flowers.
            //Dflowers.re
        }
    }
}
