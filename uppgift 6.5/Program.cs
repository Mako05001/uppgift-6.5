using System;
namespace upggift6_._5
{
    class program
    {
        static string Lenght(string t1, string t2)
        {
            string stör = " ";
            if (t1.Length == t2.Length)
            {
                stör = t1;
            }
            else if (t1.Length < t2.Length)
            {
                stör = t2;
            }
            else if (t1.Length > t2.Length)
            {
                stör = t1;
            }
            return stör;
            
        }
        static void Main(string[]args)
        {
            Console.WriteLine("Skriv första texten");
            string t1 = Console.ReadLine();
            Console.WriteLine("Skriv andra texten");
            string t2 = Console.ReadLine();
            string stör = Lenght(t1,t2);
            Console.WriteLine("Den största är " + stör);
        }
    }
}