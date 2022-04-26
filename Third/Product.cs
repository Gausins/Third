using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    public class Product
    {
        public double h;
        public double w;
        public double m;

        public Product(double height, double width, double weight)
        {
            Height = h;
            Width = w;
            Weight = m;
        }
        public double Height { get; }
        public double Width { get; }
        public double Weight { get; }
    }
}
