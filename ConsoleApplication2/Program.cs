
using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.Clear();
                
                Figure f1, f2, f3;
                    Console.WriteLine("Вы можете рассчитать площади трёх фигур: 1 - Треугольник; 2 - Квадрат; 3 - Круг.");
                    Console.WriteLine("Выберите фигуру для рассчёта площади:");
                    var Fig = (Console.ReadLine());
                    switch (Fig)
                    {
                        case ("1"):
                            Console.WriteLine("Треугольник");
                            Console.Write("Введите длину стороны А = ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Bведите длину стороны B = ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Bведите длину стороны C = ");
                            int c = Convert.ToInt32(Console.ReadLine());
                            f1 = new Figure.Triangle(a, b, c);
                            Console.Write("Площадь треугольника = " + f1.Ploshad() + "мм^2");
                            break;

                        case ("2"):
                            Console.WriteLine("Квадрат");
                            Console.Write("Введите длину стороны А = ");
                            int d = Convert.ToInt32(Console.ReadLine());
                            f2 = new Figure.Square(d);
                            Console.WriteLine("Площадь квадрата = " + f2.Ploshad()+"мм^2");
                            break;
                        
                        case ("3"):
                            Console.WriteLine("Круг");
                            Console.Write("Введите радиус R = ");
                            int r = Convert.ToInt32(Console.ReadLine());
                            f3 = new Figure.Circle(r);
                            Console.WriteLine("Площадь круга = " + f3.Ploshad()+"мм^2");
                            break;
                        default:
                            Console.WriteLine("Введены некорректные данные!!");
                            break;
                    }
                    
                Console.ReadLine();

            }
        }
    }
}
