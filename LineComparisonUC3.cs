using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LineComparisonUC3
    {
		public static void UC3()
		{


			//Taking Co-ordinates as a variables for Line 1
			int x1, y1, x2, y2;

			//Taking Inputs from users for line 1
			Console.WriteLine("**Computation for line 1**");

			Console.WriteLine("Enter the value of x1: ");
			x1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the value of x2: ");
			x2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the value of y1: ");
			y1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the value of y2: ");
			y2 = Convert.ToInt32(Console.ReadLine());

			//Defining the Length of line
			double length1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);

			Console.WriteLine("The length of line1 is: " + length1);

			//Taking Co-ordinates as a variables for Line 2
			int x3, y3, x4, y4;

			//Taking Inputs from users for line 2
			Console.WriteLine("**Computation for line 2**");

			Console.WriteLine("Enter the value of x3: ");
			x3 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the value of x4: ");
			x4 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the value of y3: ");
			y3 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the value of y4: ");
			y4 = Convert.ToInt32(Console.ReadLine());

			//Defining the Length of line
			double length2 = Math.Sqrt((x4 - x3) ^ 2 + (y4 - y3) ^ 2);

			Console.WriteLine("The length of line2 is: " + length2);

			//comparing the lengths of lines 1 & 2
			if (length1 == length2) {
				Console.WriteLine("The given lines are equal");
			} else {
				Console.WriteLine("The given lines are not equal");
			}
			if (length1 < length2)
			{
				Console.WriteLine("Line1 is less than Line2");
			}
			else if (length1 > length2)
			{
				Console.WriteLine("Line1 is greater than Line2");
			}
		}
    }
}
