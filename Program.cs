// this code produces "psuedorandom" numbers, meaning it simulates randomness via definite mathematics

using System.Diagnostics.CodeAnalysis;

Random d6 = new Random();
int[] counts = new int[19];

for (int i = 0; i < 1000000; i++) // ++ = +1
{
int roll1 = d6.Next(1, 7); // minimum is included, maximum is not included. this outputs 1-6  (as 7 is omitted)
int roll2 = d6.Next(1, 7);
int roll3 = d6.Next(1, 7);
int roll4 = d6.Next(1, 7);

int fourd6 = roll1 + roll2 + roll3 + roll4;

/* 
Console.WriteLine($@"Roll 1: {roll1},
Roll 2: {roll2},
Roll 3: {roll3},
Roll 4: {roll4}
= 4d6: {fourd6}");
*/

int lowest = roll1;

if (roll2 < lowest)
{
    lowest = roll2;
}
if (roll3 < lowest)
{
    lowest = roll3;
}
if (roll4 < lowest)
{
    lowest = roll4;
}

int fourd6drop1 = fourd6 - lowest;

counts[fourd6drop1]++;

/* 
Console.WriteLine($@"
4d6 drop 1: {fourd6drop1}");
*/
}

for (int i = 0; i < counts.Length; i++)
{
    if (counts[i] > 0)
    {
        Console.WriteLine($"Roll {i}: {counts[i]} times");
    }
}

int totalSum = 0;

for (int i = 0; i < counts.Length; i++)
{
    totalSum += i*counts[i];
}

double average = totalSum / 1000000.0;
Console.WriteLine($@"
    Average: {average}");