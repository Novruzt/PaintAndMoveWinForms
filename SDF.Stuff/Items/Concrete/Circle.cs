using SDF.Stuff.Items.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDF.Stuff.Items.Concrete
{
    public class Circle:IFigure
    {
        public string? Color { get; set; } = "Red";
        public bool? IsFilled { get; set; } = true;
        public double? Radius { get; set; } = 10;
        public double Area { get; private set; }
        public double Perimeter { get; private set; }

        public Circle()
        {
            Area = Math.PI * Math.Pow((double)this.Radius, 2);
            Perimeter = 2 * Math.PI * (double)this.Radius;
        }

        public Circle(string? color, bool? isFilled, double? Radius)
        {
            if(color!=null) Color = color;
            if(isFilled!=null) IsFilled = isFilled;

            if(Radius!=null)
            this.Radius = Radius;

            Perimeter = 2 * Math.PI * (double)(this.Radius);
            Area = Math.PI * Math.Pow((double)(this.Radius), 2);

        }

        public double[] CalculateSize()
        {
            Perimeter = 2 * Math.PI * (double)Radius;
            Area = Math.PI * Math.Pow((double)Radius, 2);

            return new[] { Area, Perimeter };
        }
    }
}
