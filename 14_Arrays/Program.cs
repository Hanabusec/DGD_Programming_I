// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Collections - Koleksiyonlar

//ARRAYS - Static - Fixed Size


//LİSTS - Dynamic - Dynamic Size

//Creating An array of player names

string[] players = new string[4];
players[0] = "Mustafa";
players[1] = "Ali";
players[2] = "Miray";
players[3] = "Kerem Miraç";

//players[4] = "Sinem";

//for (int i = 0; i < players.Length; i++)
//{
//    Console.WriteLine(players[i]);
//}

//string[] playerClasses = new string[] { "Warrior", "Paladin", "Rogue", "Wizard" };

//for (int i = 0; i < playerClasses.Length; i++)
//{
//    Console.WriteLine(playerClasses[i]);
//}

//Console.WriteLine("Please enter the size of aaray");
//string[] names = new string[int.Parse(Console.ReadLine())];

//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine("Enter the names for index: " + i);
//    names[i] = Console.ReadLine();
//    Console.WriteLine(names[i]);
//}

char[] word = new char[] { 'H', 'e', 'l', 'l', 'o' };

foreach (char harf in word)
{
    Console.Write(harf);
}

//do
//{
    
//}
//while (true);

Console.ReadKey();



