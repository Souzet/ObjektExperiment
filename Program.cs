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
        }
        static void Main(string[] args)
        {
            //string förnamn, efternamn;
            Person P = new Person()
            {
                förnamn = "Kalle",
                efternamn = "Anka"
            };
            Person Q = new Person()
            {            
                förnamn = "Kajsa",
                efternamn = "Anka"
            };
            

            


        }
    }
}
