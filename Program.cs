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
//задание 2
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;   
if (max < b) max = b;
if (max < c) max = c;
System.Console.WriteLine("максимальное из этих чисел="+ max);
//задание 1
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
System.Console.WriteLine("Большее число: " + a + ", меньшее число: " + b);
else 
System.Console.WriteLine($"Большее число: {a}, меньшее число: {b}");