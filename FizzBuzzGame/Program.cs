using System;

namespace _5_OperatorsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;

            for(i=1; i<=1000; i++){
                if(i % 3 == 0 && i % 5 != 0){
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0 && i % 3 != 0){
                    Console.WriteLine("Buzz");
                }
                else if (i % 5 == 0 && i % 3 == 0){
                    Console.WriteLine("Fizz-Buzz");
                }
                else {
                    Console.WriteLine(i);
                }
            }

        }
    }
}