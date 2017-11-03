using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dom mujDom = new Dom("Aktiv 1","aktivni","nie", 4, 74.8f, 30.9f);
            mujDom.PoskytniInformacie();

            Console.WriteLine("Percento zastavane plochy je (0)", mujDom.zistivyuzitelnostPlochy());
            Console.ReadLine();
        }

        Chata Chata = new Chata 
    }
}
