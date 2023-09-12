// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> games = new List<string>
{
    "Fallout: New Vegas",
    "FarCry 5",
    "Watchdogs: Legion",
    "Tom Clancy's: The Divsion",
    "Cyberpunk 2077"
};

string[] otherGames = new string[]
{
    "Lego DC supervillains",
    "Detriot Become Human"
};

foreach (string game in games)
{
    Console.WriteLine(game);
}

Console.WriteLine($"\nGames in List: {games.Count}");

games.AddRange(otherGames);

Console.WriteLine($"\nGames in list: {games.Count}");

if (games.Contains("Fallout"))
{
    Console.WriteLine("\nTHE COURIER IS LOCK AND LOADED!!");
}
else
{
    games.Add("Fallout");
}

int myInt = 6;

if(myInt < games.Count)
{
    games.RemoveAt(myInt);
}
else
{
    Console.WriteLine("\nGame not found!");
}

Console.WriteLine("\nAll games in the list:");
foreach (string game in games)
{
    Console.WriteLine(game);
}

games.Sort();

Console.WriteLine("\nSorted games list:");
foreach (string game in games)
{
    Console.WriteLine(game);
}

string[] newList = new string[games.Count];

games.CopyTo(newList);

games.Clear();

Console.WriteLine("\nNew List:");
foreach(string game in newList)
{
    Console.WriteLine(game);
}