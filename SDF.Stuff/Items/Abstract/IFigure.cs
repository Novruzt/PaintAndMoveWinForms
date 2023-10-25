using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDF.Stuff.Items.Abstract
{
    public interface IFigure
    {
        public string? Color { get; set; }
        public bool? IsFilled { get; set; }
        public double Area { get; }
        public double Perimeter { get; }
        public double[] CalculateSize();
    }
}
