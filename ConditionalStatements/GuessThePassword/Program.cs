﻿namespace GuessThePassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String password = Console.ReadLine();
            if (password == "s3cr3t!")
            {
                Console.WriteLine("Welcome");

            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}