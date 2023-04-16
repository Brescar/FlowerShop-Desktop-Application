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
    public partial class FormFlowerShop : Form
    {
        private Dictionary<int, Flower> flowers = new Dictionary<int, Flower>();
        public FormFlowerShop()
        {
            InitializeComponent();

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFlower form = new FormFlower(null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ListViewItem listViewItem = new ListViewItem(form.flower.Name);
                //aici am ramas
            }
        }
    }
}
