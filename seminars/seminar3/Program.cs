// int FindQuart (int x, int y)
// {
//     if(x > 0 && y > 0) return 1;
//     if(x < 0 && y > 0) return 2;
//     if(x < 0 && y < 0) return 3;
//     if(x > 0 && y < 0) return 4;
    
//     return 0;
// }

// Console.WriteLine("input x:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input Y:");
// int y = Convert.ToInt32(Console.ReadLine());
// int resault = FindQuart(x, y);
// Console.WriteLine($"Point with {x} && {y} coordinates located at {resault} quard");

// ЗАДАЧА 2

// double Find (double xa, double ya, double xb, double yb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)), 2);
// }

// Console.WriteLine("input coordinate X to A:");
// double xa = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input coordinate Y to A:");
// double ya = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input coordinate X to B:");
// double xb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input coordinate Y to B:");
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"{Find(xa, ya, xb, yb)}");