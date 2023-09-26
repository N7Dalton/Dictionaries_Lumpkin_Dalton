// See https://aka.ms/new-console-template for more information
using System.Collections;

static void Main(string[] args)
{
    Dictionary<int, string> bestGame = new Dictionary<int, string>();
    bestGame.Add(1, "Minecraft");
    bestGame.Add(2, "GTA 5");
    bestGame.Add(3, "Spider-Man VR");
    bestGame.Add(4, "Apex");
    bestGame.Add(5, "Red ded 2");
    bestGame.Add(6, "TitanFall 2");
    bestGame.Add(7, "Super Mario Bros. Wii");
    bestGame.Add(8, "Mario Galaxy");
    bestGame.Add(9, "Skate 3");
    bestGame.Add(10, "Black ops 3");

    foreach (KeyValuePair<int, string> kvp in bestGame)
    {
        Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
    }

    if (bestGame.ContainsKey(1))
    {
        Console.WriteLine($"My favorite game is: {bestGame[1]}");
    }

    string result = "";

    bestGame.TryGetValue(11, out result);

    if (result != "")
    {
        Console.WriteLine(result);

    }
    else
    {
        Console.WriteLine("aint no game here re re");
    }

    if (bestGame.ContainsKey(5))
    {
        bestGame[5] = "Rocket League";
    }

    Console.WriteLine(bestGame[5]);

    Hashtable hashTable = new Hashtable(bestGame);

    string favoriteGame = (string)hashTable[1];

    Console.WriteLine($"my fav game is {favoriteGame}");

    Hashtable capitals = new Hashtable()
            {
                { "Oklahoma", "Oklahoma City" },
                { "New York"," Albany" },
                { "Texas", "Austin" },
                { "Ohio", "Colombus" },
            };

    foreach (KeyValuePair<int, string> kvp in bestGame)
    {
        Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
    }
    capitals.Clear();
}

