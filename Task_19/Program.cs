// Написать программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом

Console.WriteLine("Введите значение:");
string value = Console.ReadLine();
char [] arr = value.ToCharArray();
Array.Reverse(arr);
string endValue = new string(arr);
if(value == endValue)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}