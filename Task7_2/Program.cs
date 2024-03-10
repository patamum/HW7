namespace Task7_2
{
    internal class Program
    {
        static void CalcCube(double a, out double s, out double v)
        {
            s = 6 * a * a;
            v = a * a * a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            double a = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            CalcCube(a, out s, out v);
            Console.WriteLine("площадь поверхности куба {0:.00} объем {1:.00}", s, v);
        }
    }
}