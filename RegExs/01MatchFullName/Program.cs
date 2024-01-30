﻿using System.Text.RegularExpressions;

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

Regex regex = new Regex(pattern);
string input = Console.ReadLine();

MatchCollection matches = regex.Matches(input);

Console.WriteLine(string.Join(" ", matches));