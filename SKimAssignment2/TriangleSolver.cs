using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKimAssignment2
{
    public static class TriangleSolver
    {

        public static string Analyze(ref List<int> sides)
        {
            int maxSide = sides.Max();
            sides.Remove(maxSide);

            int minSide = sides.Min();
            sides.Remove(minSide);

            int mediumSide = sides[0];
            sides.Remove(mediumSide);

            string output = "The sides isn't form a triangle! Please choose the right one";

            if ((minSide + mediumSide) - maxSide > 0)
            {
                if (minSide == maxSide)
                {
                    output = "The sides form = equilateral triangle!";
                }
                else if (minSide == mediumSide || minSide == maxSide || mediumSide == maxSide)
                {
                    output = "The sides form = isosceles triangle!";
                }
                else
                {
                    output = "The sides form = scalene triangle!";
                }
            }

            return output;
        }

    }
}
