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
            public string förnamn, efternamn; 
            public void Print()
            {
                Console.WriteLine($"{förnamn} {efternamn}");
            }

        }
        static void Main(string[] args)
        {
            //string förnamn, efternamn;
            Person P = new Person()
            {
                förnamn = "Kalle",
                efternamn = "Anka"
            };
            P.Print();
            Person Q = new Person()
            {            
                förnamn = "Kajsa",
                efternamn = "Anka"
            };
            Q.Print();
            

            


        }
    }
}
