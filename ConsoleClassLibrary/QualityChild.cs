using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassLibrary
{
    internal class QualityChild : Quality
    {

        public double P { get; set; } // Переменная для условий погоды

        public static double Qp; // Переменная качество потомка

       
        // Конструктор класса потомка
        public QualityChild(double p, double weidth, double lenght, double mass) : base(weidth, lenght, mass)
        {
            P = p;
        }

        // Метод расчёта качества потомка
        // Если P от 5 до 8, то Q * 1.1
        // Если P = 3,4,9,10 то Q * 1.6
        // Иначе 1.9 * Q
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

        // Метод вывода информации

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
