Console.Write("Ededi daxil edin:");
int eded = int.Parse(Console.ReadLine());

if (90 < eded && eded <= 100)
{
	Console.WriteLine("A");
}
else if (80 < eded && eded <= 90)
{
	Console.WriteLine("B");
}
else if (70 < eded && eded <= 80)
{
	Console.WriteLine("C");
}
else if (60 < eded && eded <= 70)
{
	Console.WriteLine("D");
}
else if (50 < eded && eded <= 60)
{
	Console.WriteLine("E");
}
else if (0 < eded && eded <= 50)
{
	Console.WriteLine("F");
}

