using ConsoleClassLibrary;

Console.WriteLine("Введите ширину дороги");
double Weidth = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите длину дороги");
double Lenght = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите массу дорожного покрытия");
double Mass = Convert.ToDouble(Console.ReadLine());

Quality q = new Quality(Weidth, Lenght, Mass);
q.qCalculation();
q.CheckInfo();