// Показать числа Фибоначчи меньшие заданного числа N
//int n = 10946;
//int fibo1 = 0;
//int fibo2 = 1;
//Console.Write("0 1" + " ");
//while (fibo2 <= n-fibo1)
//{
    //int temp = fibo2;
    //fibo2 = fibo2 + fibo1;
    //fibo1 = temp;
  //  Console.Write(fibo2 + " ");
//}

int[] fibonacci = new int[1000];
fibonacci[0] = 1;
fibonacci[1] = 1;
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write($"{fibonacci[0]} {fibonacci[1]} ");
int index = 1;
while(fibonacci[index]<n)
{
index++;
fibonacci[index]=fibonacci[index-1]+fibonacci[index-2];
if(fibonacci[index]<n)
Console.Write($"{fibonacci[index]} ");
}