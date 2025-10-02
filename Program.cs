string name = "Codelandia";
string name1 = "";
for (int i = name.Length - 1; i >= 0; i--)
{
	name1 = name1+name[i];
}
Console.WriteLine(name1);
