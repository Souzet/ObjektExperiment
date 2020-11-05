using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektExperiment
{
    class Program
    {
        class Land
        {
            string namn;
            public Stad huvudstad;
            int invånarantal;
        }
        class Stad
        {
            public string namn;
            int invånarantal;

        }
        static void Main(string[] args)
        {
            // string land;-> string Land.namn
            // string huvudstad;-> Stad Land.huvudstad
            // string stad;-> Stad.namn
            // int invånarantal;-> int Land.invånarantal,
            //int Stad.invånarantal,
            Stad Stockholm = new Stad();
            Stockholm.namn = "Stockholm";
            Land Sverige = new Land();
            Sverige.huvudstad = Stockholm;
            

        }
    }
}
