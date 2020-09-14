using System;

namespace Roots_of_quadratics
{
    class Program
    {
        static void Main(string[] args)
        {
            double a , b, c;
            double disc;
            double[] roots = new double[1];
            double root;
            Console.WriteLine("Enter a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c");
            c = Convert.ToInt32(Console.ReadLine());
            disc = discriminant(a, b, c);

            if (disc > 0)
            {
                roots = formula(a, b, c);
                Console.WriteLine("x = " + roots[0]);
                Console.WriteLine("x = " + roots[1]);
            }
            else if (disc == 0)
            {
                root = formulaone(a, b);
                Console.WriteLine(root);
            }
            else
            {
                Console.WriteLine("No roots");
            }
        }

        static double discriminant(double a, double b, double c)
        {
            double x;
            x = (b * b) - 4 * a * c;
            return x;
        }

        static double formulaone (double a, double b)
        {
            double x;
            x = (-1 * b) / (2 * a);
            return x;
        }
        static double[] formula (double a, double b, double c)
        {
            double[] x = new double[2];            
            x[0] = (-1 * b) + Math.Sqrt((b * b) - (4 * a * c));
            x[0] = x[0] / (2 * a);

            x[1] = (-1 * b) - Math.Sqrt((b * b) - (4 * a * c));
            x[1] = x[1] / (2 * a);

            return x;
        }
    }
}
