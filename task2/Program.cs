// Написать программу преобразования десятичного числа в двоичное
Console.Write("Введите число: ");
int tenNumber = int.Parse(Console.ReadLine() ?? "0");
int binar = 0;
int i = 0;
while (tenNumber >= 1) 
{
    binar = binar + tenNumber%2*(int)Math.Pow(10,i);
    tenNumber = tenNumber/2;
    i++;
}
Console.WriteLine(binar);