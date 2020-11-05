using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektExperiment
{
    class Program
    {
        class person
        {
            public string förnamn, efternamn, hemtelefon, jobbtelefon;
            public void Print()
            {
                Console.WriteLine("{0} {1}    {2}    {3}", förnamn, efternamn, hemtelefon, jobbtelefon);
            }
        }
        static void Main(string[] args)
        {
            person Arne = new person()
            {
                förnamn = "Arne",
                efternamn = "Saknusem",
                hemtelefon = "012-13 13 13",
                jobbtelefon = "073- 747 57 67"
            };
            Arne.Print();
        }
    }
}
