using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesOrnek1
{
    class PrimeNumber
    {
         int myNumber;

        public int InputNumberFromTheKeyBoard()
        {
            
            myNumber = Convert.ToInt32(Console.ReadLine());
            return myNumber;
        }
        bool crateNumber = false;

        public void isPrime(int number)
        {
            bool isprime = true;

            for(int i=2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isprime = false;
                    break;
                }
            }

            if (isprime)
            {
              Console.WriteLine("The Number You entered is a prime number");
                crateNumber = false;
                Console.WriteLine("-----------------------------------------------");
            }
            else
            {
                crateNumber = true;
                Console.WriteLine("The Number You entered is not a prime number");
            }
        }
        public PrimeNumber() {

        }

  

        public void closestPrimeNumber(int number)
        {
            if (crateNumber)
            {
                bool isprime = false;
                int NextPrime = number;

                while (!isprime)
                {
                    NextPrime++;
                    isprime = true;
                    for (int i = 2; i < NextPrime; i++)
                    {
                        if (NextPrime % i == 0)
                        {
                            isprime = false;
                            break;
                        }
                    }
                }

                Console.WriteLine("{0} is not prime , the system create : {1}", number, NextPrime);


            }

        }

    }
}
