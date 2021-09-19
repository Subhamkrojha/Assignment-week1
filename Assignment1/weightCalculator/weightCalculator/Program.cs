using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weightCalculator
{

    class extraWeightCalculator{
         string type;
         double weight;
       

        public extraWeightCalculator(string type, double weight)
        {
            this.type = type;
            this.weight = weight;
            
        }

        public double calculate() {
            if (type == "first" && weight > 50)
            {
                return  2 * (weight - 50);
            }
            else if (type == "business" && weight > 40)
            {
                return 2 * (weight - 40);
            }
            else
            {
                return 2 * (weight - 20);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        
        
        {
            string classType = Console.ReadLine();
            double weight = Convert.ToDouble(Console.ReadLine());

            extraWeightCalculator obj = new extraWeightCalculator(classType, weight);
            Console.WriteLine(obj.calculate());
            Console.ReadLine();
           
        }
    }
}
