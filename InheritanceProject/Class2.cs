using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    
     class Class2: Class1
    {
        public Class2():base(10)
        {
            System.Console.WriteLine("Constructor from Class2");
        }
        public void Test3()
        {
            System.Console.WriteLine("Method3 from Class2");
        }
        static void Main(string[] args)
        {
            Class2 obj = new Class2();
            obj.Test1();
            obj.Test2();
            obj.Test3();
        }
    }
}
