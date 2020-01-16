using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter 5 numbers");
            int[] userArray = new int[5];
            for (int i = 0; i < userArray.Length; i++)
            {
                userArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array edited by user: " + string.Join(" ", userArray));
            Console.ReadLine();
            Console.WriteLine("The Biggest number in Array: " + userArray.Max());
            Console.ReadLine();
            Console.WriteLine("The Smallest number in Array: " + userArray.Min());
            Console.ReadLine();
            Console.WriteLine("Sum of all numbers in Array: " + userArray.Sum());
            Console.ReadLine();
            Array.Reverse(userArray);
            Console.WriteLine("Reversed Array edited by user: ");
            foreach (var i in userArray)
            {
                Console.Write( i + " ");
            }
            Console.ReadLine();
        }

    }
}
