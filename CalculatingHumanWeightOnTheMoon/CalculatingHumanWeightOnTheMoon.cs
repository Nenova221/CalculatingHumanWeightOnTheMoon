using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingHumanWeightOnTheMoon
{
    public class CalculatingHumanWeightOnTheMoon
    {
        public static double HumanWeightOnTheMoon(double input)
        {
            Console.Write("Enter number: ");
            double weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The weight of the person on the Moon will be:", weight * 0.17);
            return weight;
        }
    }
}
