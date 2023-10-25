using SDF.Stuff.Items.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

using Rectangle = SDF.Stuff.Items.Concrete.Rectangle;

namespace SDF.Stuff.Extensions
{
    public static class FigureCreator
    {
        private static string[] RemoveBlank(this string input)
        {
             return Regex.Replace(input, @"\s+", " ").Trim().Split(' ');
        }
        public static Circle CreateCircle(this string input)
        {


            string [] inputs = input.RemoveBlank();

            string? color=null;
            bool? isFilled=null;
            double? radius=null;

            int size = inputs.Length;

                if (size == 3)
                {
                    color = inputs[0];
                    radius = Convert.ToDouble(inputs[2]);

                    if (inputs[1] == "yes") isFilled = true;
                    if (inputs[1] == "no") isFilled = false;
                }

                else if (size == 2)
                {
                    if (inputs[1] == "yes" || inputs[1] == "no")
                    {
                        color = inputs[0];

                        if (inputs[1] == "yes") isFilled = true;
                        if (inputs[1] == "no") isFilled = false;

                    }

                    else if (inputs[0] == "yes" || inputs[0] == "no")
                    {
                        if (inputs[0] == "yes") isFilled = true;
                        if (inputs[0] == "no") isFilled = false;

                        radius = Convert.ToDouble(inputs[1]);
                    }

                    else
                    {
                        color = inputs[0];
                        radius = Convert.ToDouble(inputs[1]);
                    }
                }

                else if (size == 1)
                {
                    if (inputs[0] == "yes" || inputs[0] == "no")
                    {
                        if (inputs[0] == "yes") isFilled = true;
                        if (inputs[0] == "no") isFilled = false;
                    }

                    else if (double.TryParse(inputs[0], out double value)) radius = value;
                    else if (inputs[0] != "") color = inputs[0];
                }

                else throw new Exception();

             return new Circle(color, isFilled, radius);
        }
        public static Rectangle CreateRectangle(this string input)
        {

            string[] inputs = input.RemoveBlank();
            int size = inputs.Length;

            string? color = null;
            bool? isFilled = null;
            double? width = null;
            double? height = null;

                if (size == 4)
                {
                    color = inputs[0];

                    if (inputs[1] == "yes") isFilled = true;
                    if (inputs[1] == "no") isFilled = false;

                    width = Convert.ToDouble(inputs[2]);
                    height = Convert.ToDouble(inputs[3]);
                }

                else if (size == 3)
                {
                    if (inputs[0] == "yes" || inputs[0] == "no")
                    {
                        if (inputs[0] == "yes") isFilled = true;
                        else isFilled = false;

                        width = Convert.ToDouble(inputs[1]);
                        height = Convert.ToDouble(inputs[2]);
                    }

                    else if (inputs[1] == "yes" || inputs[1] == "no")
                    {
                        if (inputs[1] == "yes") isFilled = true;
                        else isFilled = false;

                        color = inputs[0];
                        width = Convert.ToDouble(inputs[2]);
                    }
                }

                else if (size == 2)
                {
                    if (inputs[0] == "yes" || inputs[0] == "no")
                    {
                        if (inputs[0] == "yes") isFilled = true;
                        else isFilled = false;

                        width = Convert.ToDouble(inputs[1]);
                    }

                    else if (inputs[1] == "yes" || inputs[1] == "no")
                    {
                        if (inputs[1] == "yes") isFilled = true;
                        else isFilled = false;

                        color = inputs[0];
                    }

                    else if (double.TryParse(inputs[0], out double value))
                    {
                        width = Convert.ToDouble(value);
                        height = Convert.ToDouble(inputs[1]);
                    }

                    else
                    {
                        color = inputs[0];
                        width = Convert.ToDouble(inputs[1]);
                    }
                }

                else if (size == 1)
                {
                    if (inputs[0] == "yes" || inputs[0] == "no")
                    {
                        if (inputs[0] == "yes") isFilled = true;
                        else isFilled = false;
                    }

                    else if (double.TryParse(inputs[0], out double value)) width = Convert.ToDouble(value);
                    else if (inputs[0] != "") color = inputs[0];
                }

                else throw new Exception();

                return new Rectangle(color, isFilled, width, height);
          
        }
    }
}
