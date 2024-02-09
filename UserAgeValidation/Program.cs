// See https://aka.ms/new-console-template for more information
// Rakendus küsib kasutajal valida tema sugu (mees või naine)
// Rakendus küsib kasutal sisestada oma perekonnanimi
// Lähtudes kasutaja valikust, arvuti tervitab vastavalt

//"Hello, Mr. või Ms. [kasutaja perekonnanime].

Console.WriteLine("Please, select your gender (m/f):" );

char userGender = Char.Parse(Console.ReadLine()); // Loeb konsoolist maha andmeid string formaadis
Console.WriteLine("Please, enter your last name");

string lastName = Console.ReadLine();   


if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {lastName} !");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Mrs. {lastName} !");
}
else
{
    Console.WriteLine($"Welcome, {lastName} !");
}