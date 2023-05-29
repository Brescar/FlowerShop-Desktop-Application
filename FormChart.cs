using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace FlowerShop
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }
        public void AddDataPoint(string productName, double totalValue)
        {
            chart1.Series["TotalValue"].Points.AddXY(productName, totalValue);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            Size chartSize = chart1.Size;

            int desiredWidth = chartSize.Width * 2;
            int desiredHeight = chartSize.Height * 2;

            int x = (e.PageBounds.Width - desiredWidth) / 2;
            int y = (e.PageBounds.Height - desiredHeight) / 2;

            using (Bitmap chartImage = new Bitmap(desiredWidth, desiredHeight))
            {
                chart1.DrawToBitmap(chartImage, new Rectangle(Point.Empty, chartSize));

                g.DrawImage(chartImage, new Rectangle(x, y, desiredWidth, desiredHeight));
            }
        }
    }
}
