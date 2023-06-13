using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassLibrary
{
    internal class QualityChild : Quality
    {

        public double P { get; set; } 

        public static double Qp; 

       
        
        public QualityChild(double p, double weidth, double lenght, double mass) : base(weidth, lenght, mass)
        {
            P = p;
        }

        
        public virtual double pCalculation()
        {
            if(P >= 5 && P <= 8)
            {
                Qp = Q * 1.1;
                return Qp;
            }
            else
            {
                if (P == 3 || P == 4 || P == 9 || P == 10)
                {
                    Qp = Q * 1.6;
                    return Qp;
                }
                else
                {
                    Qp = 1.9 * Q;
                    return Qp;
                }
            }
        }

        

        public void CheckInfo()
        {
            Console.WriteLine($"Условия погоды: {P}");
            Console.WriteLine($"Ширина дороги: {Weidth}");
            Console.WriteLine($"Длина: {Length}");
            Console.WriteLine($"Масса дорожного покрытия: {Mass}");
            Console.WriteLine($"Качество потомка: {Qp}");
        }
    }
}
