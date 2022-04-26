using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    public class Product
    {
        public Product(double height, double width, double weight)
        {
            Height = 20;
            Width = 30;
            Weight = 60;
        }
        public double Height { get; }
        public double Width { get; }
        public double Weight { get; }
    }
}
