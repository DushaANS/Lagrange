using System;

namespace Lagrange
{
    class Program
    {
        public static double F(double x)
        {
            return -2 * x + 6 + x * x;
        }
        static void Main()
        {
            double[] X = new double[] { 0, 1, 2, 3, 4, 5, 6 };
            double[] Y = new double[X.Length];
            double x = 4.5;
            for(int i = 0; i < X.Length; i++)
            {
                Y[i] = F(X[i]);
            }
            Lagrange lagrange = new Lagrange();
            double y = lagrange.GetValue(X,Y,x);
            Console.WriteLine($"Intepolation by Lagrage for X = {x}, Y = {y}");
            Console.WriteLine($"True value for X = {x}, Y = {F(x)} ");



        }

    }
}