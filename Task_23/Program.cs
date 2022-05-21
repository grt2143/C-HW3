// Написать программу, которая принимает на вход число 
// и выдает таблицу кубов чисел от 1 до этого числа

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= number)
{
    Console.WriteLine($"Число{count, 10} -> Куб числа{Math.Pow(count, 3), 10}");
    count++;
}
