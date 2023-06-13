namespace ConsoleClassLibrary
{
    public class Quality
    {
        public static double Q; // Переменная для расчёта качества потомка
        public double Weidth { get; set; } // Ширина дороги (м)
        public double  Length { get; set; } // Длина (м)
        public double Mass { get; set; } // Масса дорожного покрытия на 1 кв.м (кг)

        //Конструтор класса Quality
        public Quality (double weidth, double lenght, double mass)
        {
            Weidth = weidth;
            Length = lenght;
            Mass = mass;
        }

        // Метод расчёта качества объекта
        // Расчитывается по формуле, ширина * длина * масса / 100

        public virtual double qCalculation()
        {
            Q = Weidth * Length * Mass / 100; // Расчёт
            return Q;
        }

        // Метод вывода информации
        public void CheckInfo()
        {
            Console.WriteLine($"Ширина дороги: {Weidth}");
            Console.WriteLine($"Длина: {Length}");
            Console.WriteLine($"Масса дорожного покрытия: {Mass}");
            Console.WriteLine($"Качество: {Q}");
        }
    }
}