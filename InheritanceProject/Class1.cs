namespace InheritanceProject
{
    class Class1
    {
        public Class1(int i)
        {
            System.Console.WriteLine("Constructor from Class1: "+i);
        }
       public void Test1()
        {
           System.Console.WriteLine("Method1 from Class1");
        }
      public void Test2()
        {
           System.Console.WriteLine("Method2 from Class1");
        }

        static void Main(string[] args)
        {
            Class1 p;    // p is a variable of Class1(no new memory allocation)
            Class2 c = new Class2(); // c is a instance of Class2(new memory allocation)
            p = c;      // p is a reference of parent class(Class1) created by using child class(Class2) instance
            p.Test1();
            p.Test2();
            //Class1 p2 = new Class1();
            //Console.WriteLine(p2.GetType());
        }

    }
}