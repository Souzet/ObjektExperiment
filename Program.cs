using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektExperiment
{
    class Program
    {
       class Bil
        {
            private string bilmärke, årsmodell;
            private int antalMil;
            public Bil(string B, string Å, int M)
            {
                bilmärke = B;
                årsmodell = Å;
                antalMil = M;
            }
            public int AntalMil()
            {
                return antalMil;
            }
            public bool UppdateraMil( int nyttAntalMil)
            {
                if(nyttAntalMil < antalMil)
                {
                    return false;
                }
                antalMil = nyttAntalMil;
                return true;
            }
        }
        static void Main(string[] args)
        {
            Bil B = new Bil("Lada", "1990", 137672);
            Console.WriteLine("Antal mil = {0}", B.AntalMil());
            if (B.UppdateraMil(137670))
            {
                Console.WriteLine("Miltalet uppdaterades!");
            }
            else
            {
                Console.WriteLine("Miltalet var fel, uppdaterades inte!" );
            }
            Console.WriteLine("Antal mil = {0}", B.AntalMil());
            if (B.UppdateraMil(137674))
            {
                Console.WriteLine("Miltalet uppdaterades!");
            }
            else
            {
                Console.WriteLine("Miltalet var fel, uppdaterades inte!");
            }
            Console.WriteLine("Antal mil = {0}", B.AntalMil());
        }
    }
}
