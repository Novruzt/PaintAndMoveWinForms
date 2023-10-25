using SDF.Stuff.Items.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDF.Stuff.Items.Concrete
{
    public class Rectangle:IFigure
    {
        public string? Color { get; set; } = "Red";
        public bool? IsFilled { get; set; } = true;
        public double? Width { get; set; } = 50;
        public double? Height { get; set; } = 50;
        public double Area { get; private set; }
        public double Perimeter { get; private set; }

        public Rectangle()
        {
            Perimeter = 2 * (double)(Width + Height);
            Area = (double)(Width * Height);
        }

        public Rectangle(string? color, bool? isFilled, double? width, double? height)
        {
            if(color!=null) Color = color;
            if (isFilled != null) IsFilled = isFilled;

            if(width!=null) Width = width;
             
            if(height!=null)  Height = height;
            else Height = Width;

            Perimeter = 2 * (double) (Width + Height);
            Area = (double)( Width * Height);
        }

        public double[] CalculateSize()
        {

            Perimeter = 2 * (double)(Width + Height);
            Area = (double)(Width * Height);

            return new[] { Area, Perimeter };
        }
    }
}
