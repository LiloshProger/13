using System.Text;

string path = @"Input.txt";
double R = 0, d = 0, P = 0; 
try
{
    Console.Write("введите R=");
    R = double.Parse(Console.ReadLine());
    Console.Write("введите d=");
    d = double.Parse(Console.ReadLine());
    Console.Write("введите P=");
    P = double.Parse(Console.ReadLine());
    InputData(path, R, d, P);
    ReadData(path);
}
catch (Exception ex)
{
    Console.WriteLine($"Исключение: {ex.Message}");
}
             
            static void InputData(string p, double RR, double dd, double PP)
{
    StreamWriter sw = new StreamWriter(p, false, Encoding.Default);
    sw.WriteLine(RR);
    sw.WriteLine(dd);
    sw.WriteLine(PP);
    sw.Close();
}

static void ReadData(string p)
{
    StreamReader sr = new StreamReader(p, Encoding.Default);
    double RR = double.Parse(sr.ReadLine());
    double dd = double.Parse(sr.ReadLine());
    double PP = double.Parse(sr.ReadLine());
    double LL = Solve(RR, dd, PP);
    Console.WriteLine($"Результат L = {LL}");
    InputData(@"Rezult.txt", LL, 0, 0);
}
static double Solve(double RR, double dd, double PP)
{
    return (RR * Math.PI * Math.Pow(dd, 2)) / (4 * PP);
}
Console.ReadKey();