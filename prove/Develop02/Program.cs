using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console. WriteLine("Please select a number to continue");
        Console. WriteLine("1.start writing \n2.load history ");

        int choice = int.Parse(Console.ReadLine());

        Prompt RandomPrompt = new Prompt();

        Journal journal = new Journal(); 
        string filePath = @"C:\Users\10759\Desktop\Programming with classes\CSE210-FALL\fall\prove\Develop02\myjournal.txt"; 
        
        if (choice == 1){

            Console.WriteLine("what's your name?");
            string name = Console.ReadLine();

            RandomPrompt.DisplayRandomPrompt();
            string response = Console.ReadLine();
            Entry entry = new Entry();
            entry._date = DateTime.Now.ToShortDateString();
            entry._name = name;
            entry._prompt = ""; // You need to specify the prompt here
            entry._response = response;
            journal.list_of_entries.Add(entry);
            journal.Save(filePath);

            }

        else{

            Console. WriteLine("What day do you want to see?");
            string select_date = Console.ReadLine();
            journal.Load(filePath);
            journal.Display();

        }

        Console.WriteLine($"File path: {filePath}");



    }

    
}