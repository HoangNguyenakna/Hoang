using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace element1
{
    class Program
    {
        static void Main(string[] args)
        {
            element<int> a = new element<int>(4);
            element<int> b = new element<int>(5);
            element<int> c = new element<int>(4);
            List<int> List=new List<int >();
            List.addfirst(a);
            List.addfirst(b);
            List.addfirst(c);
            List.Printlist();
            Console.ReadKey();
            
        }
    }
}
