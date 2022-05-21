// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3х-мерном пространстве.

Console.WriteLine("Введите X-координату точки A:");
double Xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y-координату точки A:");
double Ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Z-координату точки A:");
double Za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите X-координату точки B:");
double Xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y-координату точки B:");
double Yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Z-координату точки B:");
double Zb = Convert.ToDouble(Console.ReadLine());

double sum = (Xa - Xb) * (Xa - Xb) + (Ya - Yb) * (Ya - Yb) + (Za - Zb) * (Za - Zb);
double res = Math.Sqrt(sum);
double roundRes = Math.Round(res, 2);
Console.WriteLine(roundRes);