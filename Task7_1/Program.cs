namespace Task7_1
{
    internal class Program
    {
        static bool IsTriangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && c + b > a)
                return true;
            return false;
        }
        static double GetSquare(double a, double b, double c)
        {
            double pp = (a + b + c) / 2; ;
            return Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Convert.ToDouble(Console.ReadLine());
            if (!IsTriangle(x1, x2, x3))
            {
                Console.WriteLine("Треугольник со сторонами {0}, {1}, {2} не существует", x1, x2, x3);
                return;
            }
            double s1 = GetSquare(x1, x2, x3);
            
            Console.WriteLine("Введите длины сторон второго треугольника");
            double y1 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            if (!IsTriangle(y1, y2, y3))
            {
                Console.WriteLine("Треугольник со сторонами {0}, {1}, {2} не существует", y1, y2, y3);
                return;
            }
            double s2 = GetSquare(y1, y2, y3);
            Console.WriteLine("{0:.00}, {1:.00}", s1, s2);                                              
            if (s1 > s2)
                Console.WriteLine("Площадь первого треугольника больше");
            else if (s1 < s2)
                Console.WriteLine("Площадь второго треугольника больше");
            else 
                Console.WriteLine("Площади равны");
        }
    }
}