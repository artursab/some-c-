

namespace Extension_methods
{



    class Program
    {
    
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime.IsDayOfWeek(DayOfWeek.Friday));
        }

    }

}
