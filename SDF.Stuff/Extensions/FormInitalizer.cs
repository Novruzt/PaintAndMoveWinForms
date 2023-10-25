using SDF.Stuff.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDF.Stuff.Extensions
{
    public static class FormInitalizer
    {
        public static void InitalizeComboBox(this ComboBox comboBox)
        {
            comboBox.Items.Add(FigureType.Circle);
            comboBox.Items.Add(FigureType.Rectangle);
        }


    }
}
