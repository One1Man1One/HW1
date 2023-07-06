//задание номер 4
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=n;i++)
{
if (i % 2 == 0)
System.Console.Write(i + ", ");
}
//задание номер 3
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
System.Console.WriteLine("Число: " + a + " четное");
else 
System.Console.WriteLine($"Число: {a} нечетное");
