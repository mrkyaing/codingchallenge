﻿namespace CodingChallenge;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello,Coding Chellengance!");
        Console.Write("Please Type Digit:");
        string inputDigits =Console.ReadLine(); 
        var result = EncodingUtility.OldPhonePad(inputDigits);
        Console.WriteLine($"Inputed Digits:{inputDigits}");
        Console.WriteLine("Output:");
        foreach (var word in result)
        {
            Console.Write(word);
        }
        Console.WriteLine();
        Console.WriteLine("Happy ending,program finished!!");
    }
}
