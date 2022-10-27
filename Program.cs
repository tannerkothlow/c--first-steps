// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

string? great = Console.ReadLine(); 

int myNum;
myNum = 5;

double mcDouble = 4.99;

bool isGreat = true;

Console.WriteLine($"This is the {myNum} {great}");

great = Console.ReadLine();

Console.WriteLine($"This is still the {great} McDouble {mcDouble}");

if (isGreat)
{
    Console.WriteLine("It's Great!");
} else
{
    Console.WriteLine("Aw man :(");
}