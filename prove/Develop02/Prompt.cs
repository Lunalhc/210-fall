using System;
using System.Collections.Generic;

public class Prompt{

public List<string> list_of_prompts = new List<string>();


public void DisplayRandomPrompt(){

    list_of_prompts.Add("What was the best part of my day?");
    list_of_prompts.Add("What was the strongest emotion I felt today?");
    list_of_prompts.Add("If I had one thing I could do over today, what would it be?");
    
    Random random = new Random();
    int randomIndex = random.Next(0, list_of_prompts.Count);
    string randomPrompt = list_of_prompts[randomIndex];

    Console.WriteLine(randomPrompt);


}









}