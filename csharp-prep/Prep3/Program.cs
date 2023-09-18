using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);
        Console.WriteLine(magic_number);

        Console.WriteLine("What's your guess?");
        string input = Console.ReadLine();
        float guess = float.Parse(input); // store the guess number

        while( guess != magic_number ){

           if(guess > magic_number){

            Console.WriteLine("lower");
            input = Console.ReadLine();
            guess = float.Parse(input);

           }

           else if (guess < magic_number){

              Console.WriteLine("higher");
              input = Console.ReadLine();
              guess = float.Parse(input);
           }

           else{
              
              input = Console.ReadLine();
              guess = float.Parse(input);
           }

           Console.WriteLine("You guessed it!");
        }
        
        

        

    }
}