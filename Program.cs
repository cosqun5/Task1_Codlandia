int[] list =  { 1, 2, 3, 4, 5 ,20};
float orta = 0;
for (int i = 0; i < list.Length; i++)
{
	orta += list[i];
	
}
orta = orta / list.Length;
Console.WriteLine(	orta);
