using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagrange
{
    class Lagrange
    {
        private double l(int index, double[] X, double x)
        {
            double l = 1;
            for (int i = 0; i < X.Length; i++)
            {
                if (i != index)
                {
                    l *= (x - X[i]) / (X[index] - X[i]);
                }
            }
            return l;
        }

        public double GetValue(double[] X, double[] Y, double x)
        {
            double y = 0;
            for (int i = 0; i < X.Length; i++)
            {
                y += Y[i] * l(i, X, x);
            }

            return y;
        }

        private double l(int index, double[] X, double h, double x)
        {
            double l = 1;
            for (int i = 0; i < X.Length; i++)
            {
                if (i != index)
                {
                    l *= (x - X[0] - i * h) / (index - i);
                }
            }
            return l / Math.Pow(h, X.Length - 1);
        }

        public double GetValue(double[] X, double h, double[] Y, double x)
        {
            double y = 0;
            for (int i = 0; i < X.Length; i++)
            {
                y += Y[i] * l(i, X, h, x);
            }

            return y;
        }
    }
}
