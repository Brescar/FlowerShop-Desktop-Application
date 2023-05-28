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
             * 1) pt drag and drop idee: putem da drag and drop unui produs intr-un 
             * imageBox si apare o imagine, poate culoare, poate floare pixelata ceva
             * 2) baza de date implementare : fie pe listView fie datagridView. proabil pe Products in tabela Products
             * 3) printare documente
             * 4) grafic : ar putea fi nr de coloane = nr de produse. fiecare coloana se duce pana la o valoare totala
             * egala cu quantity * price
             * 
             */
        }
    }
}
