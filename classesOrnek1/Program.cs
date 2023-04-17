using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumber primeNumber = new PrimeNumber();
            Console.Write("Enter a number  :");
            int number=   primeNumber.InputNumberFromTheKeyBoard();
            primeNumber.isPrime(number);
            primeNumber.closestPrimeNumber(number);
    
            Console.ReadKey();
        }
    }
}
