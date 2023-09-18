using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("What is your letter percentage?");
       
       string input = Console.ReadLine();
       float percentage = float.Parse(input);
       string letter;


       if (percentage > 90 || percentage == 90){

          letter = "A";
          Console.WriteLine($"Your grade is {letter}.");
       }
       else if (percentage > 80 || percentage == 80){

          letter = "B";
          Console.WriteLine($"Your grade is {letter}.");
       }

       else if (percentage > 70 || percentage == 70){

          letter = "C";
        Console.WriteLine($"Your grade is {letter}");
       }

       else if (percentage >60 || percentage == 60){

            letter = "D";
            Console.WriteLine($"Your grade is {letter}");
       }

       else {
            letter = "F";
        Console.WriteLine("Your grade is F.");
       }

       
       if (letter == "A" || letter == "B" || letter == "C"){

          Console.WriteLine("You passed the class!");
       }
       
       else{

           Console.WriteLine("You didn't pass the class");
       }



    }
}