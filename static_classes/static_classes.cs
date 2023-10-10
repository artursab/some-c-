

using System.Diagnostics.Metrics;

namespace statcla
{


    class MyClass
    {
        public MyClass() 
        {
            Counter++;
        }

        private static int counter;

        public static int Counter { get; private set; }

        public static int GetCounter() 
        {
            return counter;
        }

        public int GetObjectsCount()
        {
            return counter;
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();
            MyClass myClass2 = new MyClass();
            MyClass myClass3 = new MyClass();

            Console.WriteLine(myClass1.GetObjectsCount());

            MyClass myClass4 = new MyClass();

            Console.WriteLine(MyClass.Counter);

            Console.WriteLine(MyClass.GetCounter());
        }
    }

}
