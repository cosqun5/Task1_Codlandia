
#region Task1
//Console.Write("Ededi daxil edin:");
//int eded = int.Parse(Console.ReadLine());
//int cem = 0;

//for (int i = 0; i <=eded; i++)
//{
//	cem=cem + i;
//}
//Console.WriteLine(cem);
#endregion



#region Task2
Console.Write("Peşəni daxil edin:");
string peşə = Console.ReadLine();

Console.Write("Maaşı daxil edin:");
int maaş = int.Parse(Console.ReadLine());

switch (peşə)
{
	case "Menecer":
		maaş = maaş * 3;
		Console.WriteLine($"Menecer = {maaş}AZN");
		break;
	case "Proqramci":
		maaş = maaş * 2;
		Console.WriteLine($"Proqramci = {maaş}AZN");
		break;
	case "Dizayner":
		maaş = maaş + 500;
		Console.WriteLine($"Dizayner = {maaş} AZN");
		break;
	case "Temirci":
		maaş = maaş - 200;
		Console.WriteLine($"Təmirci = {maaş} AZN");
		break;

	default:
		Console.WriteLine("Belə bir peşə tapılmadı.");
		break;
}

#endregion


