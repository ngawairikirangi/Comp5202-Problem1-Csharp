using System;

namespace Comp5202_Problem1_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for a number input (for loop)//
        int j,n;

        Console.WriteLine("Please type in 1st number");
        Console.ReadLine();
        Console.WriteLine("Please type in 2nd number");
        Console.ReadLine();

        Console.Write("Number ";
        n=Convert.ToInt32(Console.ReadLine());

        for(j=1<=10;j++)
        {
            Console.Write("{0}x{1}={2}\n",n,j,n*j);
            
        }
        }
    }
}
