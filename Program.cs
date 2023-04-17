using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormFlowerShop());

            /*THINGS THAT NEED ADDING / MODIFYING
             * 1) To add verifying and verified to the button for adding a flower
             * 2) To add the condition where adding or editing a product where 2 instances
             * of the same item appear, somehow the stock is combined into only one item
             * 3) to add implementation for menu strip products edit
             * 4) to add implementation of the statusStrip
             */
        }
    }
}
