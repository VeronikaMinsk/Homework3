//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int x;
Console.WriteLine("введите число: ");
x = Convert.ToInt32(Console.ReadLine());
kub(x);

void kub(int x)
{
    int index = 1;
    int kub = 0;
    
    while (index <= x)
    {
        kub = index*index*index;
        Console.Write(kub + " ");
        index++;
    }
}