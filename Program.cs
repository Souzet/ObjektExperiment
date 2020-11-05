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
        }
        static void Main(string[] args)
        {
            Bil B = new Bil("Lada", "1990", 137672);
            
        }
    }
}
