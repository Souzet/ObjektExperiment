using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektExperiment
{
    class Program
    {
        class Person
        {
            private string förnamn, efternamn, hemtelefon, jobbtelefon;
            public Person(string S, string E, string H, string J)
            {
                förnamn= S; 
                efternamn= E; 
                hemtelefon= H; 
                jobbtelefon= J;
            }
            public void Print()
            {
                Console.WriteLine("{0} {1}    {2}    {3}", förnamn, efternamn, hemtelefon, jobbtelefon);
            }
        }
        static void Main(string[] args)
        {
            Person Arne = new Person("Arne", "Saknusem", "012-13 13 13", "073- 747 57 67");
            Arne.Print();
            
        }
    }
}
