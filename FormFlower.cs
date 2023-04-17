using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class FormFlower : Form
    {
        public Flower flower;
        public FormFlower(Flower f)
        {
            InitializeComponent();

            if (f == null)
            {
                flower = new Flower();
            }
            else
            {
                //to add what we do in case of editing a flower product
            }
        }

        private void buttonFlowerAdd_Click(object sender, EventArgs e)
        {
            flower.Name = textBoxFlowerName.Text;
            flower.Color = textBoxFlowerColor.Text;
            flower.Price = double.Parse(textBoxFlowerPrice.Text);
            flower.Quantity = int.Parse(textBoxFlowerStock.Text);
        }
    }
}
