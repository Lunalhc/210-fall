using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.WriteLine("Enter number:");

        string input = Console.ReadLine();
        int input1 = int.Parse(input);
        numbers.Add(input1);

        while (input1 != 0){

            Console.WriteLine("Enter number:");
            input = Console.ReadLine();
            input1 = int.Parse(input);
            numbers.Add(input1);
        }

        Console.WriteLine("finished");
        numbers.Remove(0);

        foreach(int number in numbers){

            Console.WriteLine(number);

        }

        int sum = 0;
        int amount = 0;

        for (int i = 0; i<numbers.Count; i++){
            
            sum += numbers[i];
            amount = i+1;
        }

        int maxium = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is {sum/amount}");
        Console.WriteLine($"The largest number is : {maxium}");


    




       




    }
}