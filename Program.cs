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
             * 1) De implementat login pe form1
             * 2) de verificat username-ul si parola in baza de date, daca e ok enable la controale, daca nu e ok eroare si
             * incercare din nou
             * 3) de modificat si verificat eroarea care trebuie sa apara la login incorect
             * 
             */
        }
    }
}
