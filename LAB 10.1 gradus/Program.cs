using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_10._1_gradus
{
    class Program
    {
        static void Main(string[] args)
        {
            Angular angular = new Angular();
            angular.setValues(50, 0, 0, 0);
            angular.printValues();
            Console.ReadKey();
        }

        class Angular
        {

            public double gradus;
            public double min;
            public double sec;
            private double Radians;
            public void setValues(double _gradus, double _min, double _sec, double _Radians)
            {
                gradus = _gradus;
                min = _min;
                sec = _sec;
                Radians = _Radians = (gradus + min / 60 + sec / 3600) * (Math.PI) / 180;

                if (gradus < 0)
                    Radians = -Radians;

            }

            public void printValues()
            {
                System.Console.Write(gradus + "-gradus." + min + "-min." + sec + "-sec." + Radians + "-Radians");
                System.Console.WriteLine();
            }
        }    
    }
}
