using System;
using System.Collections.Generic;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            //SUPERCLASSE GENERICA 
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 350.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 150.0, 400));
            list.Add(new SavingsAccount(1003, "Bob", 950.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 250.0, 500));
            

            double sum = 0;

            foreach (Account acc in list) {

                sum += acc.Balance;
            }

            Console.WriteLine(sum);
        }
    }
}
