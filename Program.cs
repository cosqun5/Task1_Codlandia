Console.WriteLine("3 reqemli ededi daxil edin");
int eded = int.Parse(Console.ReadLine());
if (eded < 100 || eded>999)
{
	Console.WriteLine("3 reqemli eded daxil edin!");
	return;
}

int birincieded = eded / 100;
int ikincieded = eded % 10;

if (birincieded>ikincieded)
{
	Console.WriteLine("birinci eded boyukdur!");
}
else if (ikincieded > birincieded)
{
	Console.WriteLine("ikinci eded boyukdur!");
}
else
{
	Console.WriteLine("ededler bir birine beraberdir");
}
