using System;

namespace QuadraticLib
{
    public class QuadraticSolver
    {
        public static (int, double?, double?) Solve(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
                return (0, null, null);
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                return (1, root, null);
            }
            else
            {
                double sqrtDisc = Math.Sqrt(discriminant);
                double root1 = (-b + sqrtDisc) / (2 * a);
                double root2 = (-b - sqrtDisc) / (2 * a);
                return (2, root1, root2);
            }
        }
    }
}

