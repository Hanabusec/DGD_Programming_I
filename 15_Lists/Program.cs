// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

List<string> names = new List<string>();

//List<char> word = new List<char>() 
//{ 
//    'a', 'b', 'c'
//};

//foreach (char item in word)
//{
//    Console.WriteLine(item);
//}

names.Add("Miray");
names.Add("Mustafa");
names.Add("Ali");
names.Add("Kerem Miraç");

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

//names.Remove(names[2]);
//names.Remove("Kerem Miraç");

//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}

//names.RemoveAt(0);
//names.Clear();

names.IndexOf("Ali");
names.AddRange(new string[] { "a", "b", "c" });

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

if(names.Contains("Aliii"))
{
    Console.WriteLine("Ali is here");
}

Console.ReadKey();