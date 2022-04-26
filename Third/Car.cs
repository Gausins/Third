using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    public class Car
    {
        public string speed;

        public string? Brand { get; set; }
        public string? NumberPlate { get; set; }
        public string? Speed { get; set; }

        public void StartToDrive()
        {
            Speed = "20";
            Console.WriteLine("Sākam braukšanu");
        }

        public string? GetSpeed()
        {
            return Speed;
        }

        public string GetSpeed(string speed) => speed;

        public string GoFaster()
        {
            Speed += "10";
            Console.WriteLine("Ātrums - " + Speed);
            return speed;
        }

        public void Beep()
        {
            Console.WriteLine("BEEP");
        }

        public string SlowDown()
        {
            Speed = "10";
            Console.WriteLine("Ātrums - " + Speed);
            return Speed;
        }

        public void Stop()
        {
            Speed = "0";
            Console.WriteLine("Apstāšanās");
        }

    }
}
