﻿
Console.WriteLine("Enter a word");
string userInput = Console.ReadLine();

PrintAnyWord(userInput);

static void PrintAnyWord(string anyString) // Anystring on parameeter
{
    anyString = anyString.ToUpper();
    for(int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}