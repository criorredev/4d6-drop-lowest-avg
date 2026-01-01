// this code produces "psuedorandom" numbers, meaning it simulates randomness via definite mathematics

using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

Random d6 = new Random();

int roll1 = d6.Next(1, 7); // minimum is included, maximum is not included. this outputs 1-6  (as 7 is omitted)
int roll2 = d6.Next(1, 7);
int roll3 = d6.Next(1, 7);
int roll4 = d6.Next(1, 7);

int fourd6 = roll1 + roll2 + roll3 + roll4;

Console.WriteLine($"{roll1}, {roll2}, {roll3}, {roll4} = {fourd6}");

