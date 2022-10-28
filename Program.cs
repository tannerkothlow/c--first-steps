// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

// string? great = Console.ReadLine(); 

// int myNum;
// myNum = 5;

// double mcDouble = 4.99;

bool isGreat = false;

// Console.WriteLine($"This is the {myNum} {great}");

// great = Console.ReadLine();

// Console.WriteLine($"This is still the {great} McDouble {mcDouble}");

Console.WriteLine("Is it great? (y/n)");
string? isItGreat = Console.ReadLine();
// This fixes that annoying warning I kept getting.
if (isItGreat == null) {
    isItGreat = "n";
}

// I was a fool for making isGreat and isItGreat different variables

if (isItGreat.Length == 1) {
    if (Convert.ToChar(isItGreat) == 'y' || Convert.ToChar(isItGreat) == 'Y') {
        isGreat = true;
    }
} else if (isItGreat.Length >= 2) {
    Console.WriteLine("Just enter y/n, do not type the answer out fully");
}

if (isGreat) {
    Console.WriteLine("It's Great!");
} else {
    Console.WriteLine("Aw man :(");
}