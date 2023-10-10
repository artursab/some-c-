

namespace Stat
{

    class MyClass
    {
        private static int b;

        public void SetB(int b)
        {
            MyClass.b = b;
        }

        public void GetB()
        {
            Console.WriteLine(b);
        }

    }



    class Program
    { 
        static void Main(string[] args) 
        { 
            MyClass myClass1 = new MyClass();
            myClass1.SetB(1);

            MyClass myClass2 = new MyClass();
            myClass2.GetB();
        }
    }
}
