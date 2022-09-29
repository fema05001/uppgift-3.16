using System;
namespace Uppgift_3_16
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange antal minuter i låten");
            string x=Console.ReadLine();
           int a=int.Parse(x);
            Console.WriteLine("ange antal sekunder i låten");
            string y=Console.ReadLine();   
            int b=int.Parse(y);
            if (a >= 4 && b > 20) 
            {
                Console.WriteLine("Din låt får inte spelas på radiostationen");
            }
            else if (a <= 2 && b < 45)
            {
                Console.WriteLine("Din låt får inte spelas på radiostationen");
            }
            else
            {
                Console.WriteLine("Din låt får spelas på radiostationen");
            }
        }
    }
}
