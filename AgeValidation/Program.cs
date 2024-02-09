// See https://aka.ms/new-console-template for more information

// Rakendus küsib kasutaja vanust
// Kui on väiksem kui 13, siis konsool ütleb:
// Too young to use
// Muul juhul konsool ütleb "Welcome"

Console.WriteLine("Enter your age: ");

string userAge = Console.ReadLine();

int userAgeNum = 0;

// Boolean - true & false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

// int userAge = Int32.Parse(Console.ReadLine()); // "Kolmteist" - heap, 13 - stack

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber == true)
{
    if(userAgeNum >= 13)
    {
        Console.WriteLine("Welcome!");
    }
    else
    {
        Console.WriteLine("Too young to use.");
    }
}