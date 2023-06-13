namespace ConsoleClassLibrary
{
    public class Quality
    {
        public static double Q; 
        public double Weidth { get; set; } 
        public double  Length { get; set; } 
        public double Mass { get; set; } 

        
        public Quality (double weidth, double lenght, double mass)
        {
            Weidth = weidth;
            Length = lenght;
            Mass = mass;
        }

        

        public virtual double qCalculation()
        {
            Q = Weidth * Length * Mass / 100; 
            return Q;
        }

        
        public void CheckInfo()
        {
            Console.WriteLine($"Ширина дороги: {Weidth}");
            Console.WriteLine($"Длина: {Length}");
            Console.WriteLine($"Масса дорожного покрытия: {Mass}");
            Console.WriteLine($"Качество: {Q}");
        }
    }
}
