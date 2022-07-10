
List<string> list = new List<string>();

list.Add("Maria");
list.Add("Alex");
list.Add("Bob");
list.Add("Anna");
list.Insert(2, "Marco");

foreach(var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine("List count: " + list.Count);

string s1 = list.Find(x => x[0] == 'A');
Console.WriteLine("First 'A': " + s1);

string s2 = list.FindLast(x => x[0] == 'A');
Console.WriteLine("First 'A': " + s2);

int pos1 = list.FindIndex(x => x[0] == 'A');
Console.WriteLine("First position 'A': " + pos1);

int pos2 = list.FindLastIndex(x => x[0] == 'A');
Console.WriteLine("First position 'A': " + pos2);

List<string> list2 = list.FindAll(x => x.Length == 5);
Console.WriteLine("-------------------------");
foreach(string item in list2)
{
    Console.WriteLine(item);
}

list.Remove("Alex");
Console.WriteLine("-------------------------");
foreach(string item in list)
{
    Console.WriteLine(item);
}

//list.RemoveAt(3);
//Console.WriteLine("-------------------------");
//foreach (string item in list)
//{
//    Console.WriteLine(item);
//}

list.RemoveAll(x => x[0] == 'M');
Console.WriteLine("-------------------------");
foreach (string item in list)
{
    Console.WriteLine(item);
}