// S1.1. 
double a = 1.87789;
Console.WriteLine(Math.Round(a, 2));

// S1.2. 
double a2 = 1.68994;
Console.WriteLine(Math.Round(a2, 1));

// S1.3. 
Console.Write($"Введите число: ");
int a3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели число {a3}");

// S1.4. 
Console.Write($"Введите число: ");
int a4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a4} - вот какое число Вы  ввели");
Console.WriteLine();

// S1.5. 
int a5 = 1;
int b5 = 13;
int c5 = 49;
Console.WriteLine($"{a5} {b5} {c5}");
Console.WriteLine();

// S1.6. 
int a6 = 7;
int b6 = 15;
int c6 = 100;
Console.WriteLine($"{a6}  {b6}  {c6}");
Console.WriteLine();

// S1.7. 
Random rnd7 = new Random();
int a7 = rnd7.Next(100);
int b7 = rnd7.Next(200);
int c7 = rnd7.Next(300);
Console.WriteLine($"{a7}  {b7}  {c7}");
Console.WriteLine();

// S1.8. 
Random rnd8 = new Random();
int a8 = rnd8.Next(100);
int b8 = rnd8.Next(200);
int c8 = rnd8.Next(300);
int d8 = rnd8.Next(400);
Console.WriteLine($"{a8} {b8} {c8} {d8}");
Console.WriteLine();

// S1.9. 
int a9 = 50;
int b9 = 10;
Console.WriteLine($"{a9}\n{b9}");
Console.WriteLine();

// S1.10. 
int a10 = 5;
int b10 = 10;
int c10 = 21;
Console.WriteLine($"{a10}\n{b10}\n{c10}");
Console.WriteLine();

// S1.11. 
Random rnd11 = new Random();
int a11 = rnd11.Next(100);
int b11 = rnd11.Next(200);
int c11 = rnd11.Next(300);
int d11 = rnd11.Next(400);
Console.WriteLine($"{a11}\n{b11}\n{c11}\n{d11}");
Console.WriteLine();

// S1.12. 
int a12 = 5;
int b12 = 10;
string c12 = ("7 см");
Console.WriteLine($"{a12} {b12}");
Console.WriteLine($"{c12}");
Console.WriteLine();

// S1.13. 
int a13 = 2;
int b13 = 13;
int c13 = 17;
string d13 = ("кг");
Console.WriteLine($"{a13} {d13}\n{b13} {c13}");