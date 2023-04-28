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
             * 1) To add the condition where adding or editing a product where 2 instances
             * of the same item appear, somehow the stock is combined into only one item
             * 2) to add implementation of the statusStrip 
             * 3) started implementing forms and such for orders
             * 4) to add implementation for StockOrder, StockDelivery and adapt Stock
             * to StockFlower;
             * 5) to adapt the code when addingor editing happens, entrys in StockName
             * needs to be updated accordingly
             * 6) to implement clear (total delete) and restore (per item and per all items)
             * as in Undo
             * 7) to implement shortcuts
             * 
             * !!! ) immediate to do:  left to add for delivery : menustrip for delivery, 
             * contextstrip for delivery, and implementations for buttons and veryfying 
             * and code in form1
             */
        }
    }
}
