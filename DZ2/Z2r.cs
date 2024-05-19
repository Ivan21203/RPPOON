using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    public class Z2r
    {
        class Average
        {
            public List<double> Averages(List<double[]> arraysList)
            {
                List<double> avgs = new List<double>(); //resulting list
                foreach (double[] a in arraysList)
                {

                    avgs.Add(CalculateAverage(a));
                }
                return avgs;
            }
            public double CalculateAverage(double[] Array
                ) 
            {
                double sum = 0;
                for (int i=0; i<Array.Length; i++) 
                {
                    sum+= Array[i];
                }
                return sum/Array.Length;
            }
        }
       
    }
}
