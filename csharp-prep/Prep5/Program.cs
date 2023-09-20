using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome () {

           Console.WriteLine("Welcome to the Program!");

        }

        static string PromptUserName() {

            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            return name;
            
        }

        static int PromptUserNumber() {

            Console.WriteLine("What's your favorite number?");
            int number = int.Parse(Console.ReadLine());
            
            return number;

        }

        static int SquareNumber(int integer){

            int square = integer * integer;
            return square;

        }

        DisplayWelcome();
       

        static void DisplayResult(){

            string username =PromptUserName();

            int inputnumber =  PromptUserNumber();
            int resultnumber = SquareNumber(inputnumber); 
            Console.WriteLine($"{username} ,the square of your number is {resultnumber}"); 


        }

        
       
    
        DisplayResult();

        





    }
}