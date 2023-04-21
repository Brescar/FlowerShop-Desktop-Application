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
        private Stocks products = new Stocks();
        public FormFlowerShop()
        {
            InitializeComponent();
            editToolStripMenuItem.Enabled = false;

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFlower form = new FormFlower(null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem(form.flower.Name);
                item.SubItems.Add(form.flower.Color);
                item.SubItems.Add(form.flower.Price.ToString());
                item.SubItems.Add(form.flower.Quantity.ToString());

                item.Tag = form.flower;

                listViewProducts.Items.Add(item);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count > 0)
            {
                Flower f = listViewProducts.SelectedItems[0].Tag as Flower;
                FormFlower form = new FormFlower(f);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem item = listViewProducts.SelectedItems[0];
                    item.Text = form.flower.Name;
                    item.SubItems[1].Text = form.flower.Color;
                    item.SubItems[2].Text = form.flower.Price.ToString();
                    item.SubItems[3].Text = form.flower.Quantity.ToString();

                    
                }
            }
        }

        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count > 0)
            {
                editToolStripMenuItem.Enabled = true;
            }
            else
            {
                editToolStripMenuItem.Enabled = false;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listViewProducts.SelectedItems.Count == 0)
            {
                editProductToolStripMenuItem.Enabled = false;
            }
            else
            {
                editProductToolStripMenuItem.Enabled = true;
            }
        }
    }
}
