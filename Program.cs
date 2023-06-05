int[] arr1;
arr1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

string[] arr2;
arr2 = new string[] { "Tim", "Martin", "Nikki", "Sara" };



bool[] arr3 = new bool[10];
bool alternate = true;
for (int i = 0; i < arr3.Length; i++)
{
  if (alternate == true)
  {
    alternate = false;
    arr3[i] = true;
  }
  else
  {
    alternate = true;
    arr3[i] = false;
  }
}

List<string> flavors = new List<string>();
flavors.Add("Vanilla");
flavors.Add("Chocolate");
flavors.Add("Strawberry");
flavors.Add("Cookie Dough");
flavors.Add("Rocky Road");
Console.WriteLine(flavors.Count);
Console.WriteLine(flavors[2]);
flavors.RemoveAt(2);
Console.WriteLine(flavors.Count);

Dictionary<string, string> strDict = new Dictionary<string, string>();
Random rand = new Random();
foreach (var name in arr2)
{
  strDict.Add(name, flavors[rand.Next(4)]);
}
foreach (KeyValuePair<string, string> entry in strDict)
{
  Console.WriteLine($"{entry.Key} - {entry.Value}");
}
