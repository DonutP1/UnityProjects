using System;
using System.Net.Cache;

namespace Method
{

    internal class Program
    {

        private static double GetDiscountRate(object client)
        {
            switch (client)
            {
                case ValueTuple<string, int>("학생", int age) when age < 18:
                    return 0.2;
                case ValueTuple<string, object>("학생", _):
                    return 0.1;
                case ValueTuple<string, int>("일반", int age) when age < 18:
                    return 0.1;
                case ValueTuple<string, object>("일반",_):
                    return 0.05;
                default:
                    return 0;
            }
        }
        public static void Main(string[] args)
        {
            var allice = (Job: "학생",17);
            var bob = (Job: "학생",19);
            var charlie = (Job: "일반",15);
            var dave = (Job: "일반", (object)null!);

            Console.WriteLine($"aliice: {GetDiscountRate(allice)}");
            Console.WriteLine($"bob: {GetDiscountRate(bob)}");
            Console.WriteLine($"charlie: {GetDiscountRate(charlie)}");
            Console.WriteLine($"dave: {GetDiscountRate(dave)}");
            
        }
    }
}
