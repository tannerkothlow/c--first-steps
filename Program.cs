// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

// string? great = Console.ReadLine(); 

// int myNum;
// myNum = 5;

// double mcDouble = 4.99;

// bool isGreat = false;

// Console.WriteLine($"This is the {myNum} {great}");

// great = Console.ReadLine();

// Console.WriteLine($"This is still the {great} McDouble {mcDouble}");

//=================================================================================================

// Console.WriteLine("Is it great? (y/n)");
// string? isItGreat = Console.ReadLine();
// // This fixes that annoying warning I kept getting.
// if (isItGreat == null) {
//     isItGreat = "n";
// }


// I was a fool for making isGreat and isItGreat different variables

// if (isItGreat.Length == 1) {
//     if (Convert.ToChar(isItGreat) == 'y' || Convert.ToChar(isItGreat) == 'Y') {
//         isGreat = true;
//     }
// } else if (isItGreat.Length >= 2) {
//     Console.WriteLine("Just enter y/n, do not type the answer out fully");
// }

// if (isGreat) {
//     Console.WriteLine("It's Great!");
// } else {
//     Console.WriteLine("Aw man :(");
// }

// Below is much better than what's above. This can parse string inputs into just the first letter, no need for any type errors.

// Console.WriteLine("I think we could also do this, enter a string.");
// string? firstLetterInput = Console.ReadLine();
// if (firstLetterInput == null) {
//     firstLetterInput = "nope";
// }
// char firstLetter = firstLetterInput[0];
// Console.WriteLine(firstLetter);

// Special character escapes
// Console.WriteLine("\"An A Press is an A press, you can't say it's a half!\"\nWell, TJ \"Henry\" Yoshi, you drooling bafoon.");

//==================================================================================================

// C# also has if else shorthand thank god
string myCoolString = "Great";
string greatString = myCoolString == "Great" ? "Great" : "Not great";
Console.WriteLine(greatString);

// This works too! :D
Console.WriteLine(myCoolString == "Great" ? "Great" : "Not great");

// C# switch expressions are the exact same as Javascript
// Likewise with while expressions

// Do loops are new

int i = 0;
do {
    Console.WriteLine(i);
    i++;
} while (i < 5);

// Not the syntax they had on W3, but I think this best shows the do loop condition.

//==================================================================================================