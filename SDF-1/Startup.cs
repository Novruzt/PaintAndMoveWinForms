using SDF.Stuff.Enums;
using SDF.Stuff.Extensions;
using SDF.Stuff.Items.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Rectangle = SDF.Stuff.Items.Concrete.Rectangle;

namespace SDF_1
{
    public partial class Startup : Form
    {


        private Circle _circle;
        private Rectangle _rectangle;
        private int _speed = 5;

        public Startup()
        {
            InitializeComponent();

        }

        private void Startup_Load(object sender, EventArgs e)
        {
            comboBoxItemType.InitalizeComboBox();
            comboBoxItemType.SelectedIndex = 0;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            bool IsDone;
            FigureType FigureType;

            try
            {
                if (int.TryParse(textBoxSpeed.Text, out int value))
                    if (value > 0) _speed = value;
                    else _speed = Math.Abs(value);
                else _speed = 5;

                if (comboBoxItemType.SelectedIndex == 0) _circle = textBoxInput.Text.CreateCircle();
                if (comboBoxItemType.SelectedIndex == 1) _rectangle = textBoxInput.Text.CreateRectangle();

                IsDone = true;

            }
            catch
            {


                if (comboBoxItemType.SelectedIndex == 0) _circle = new Circle();
                if (comboBoxItemType.SelectedIndex == 1) _rectangle = new Rectangle();

                IsDone = false;
            }

            finally
            {

                if (comboBoxItemType.SelectedIndex == 0)
                {
                    FigureType = FigureType.Circle;

                    textBoxSize.Text = $"You created circle successfully. Here are the parameters: \n"
                                       + $"Color: {_circle.Color},  Filling Inside: {_circle.IsFilled}. \n Radius: {_circle.Radius} \n"
                                       + $"\nArea: {_circle.Area.ToString("N2")} \n Perimeter: {_circle.Perimeter.ToString("N2")}";
                }

                else
                {
                    FigureType = FigureType.Rectangle;

                    textBoxSize.Text = $"You created rectangle successfully. Here are the parameters: \n"
                    + $"Color: {_rectangle.Color},  Filling Inside: {_rectangle.IsFilled}. \n Width: {_rectangle.Width} \n Height: {_rectangle.Height}\n"
                    + $"\nArea: {_rectangle.Area} \n Perimeter: {_rectangle.Perimeter}";
                }
                textBoxSize.Text += $" \n speed: {_speed}";
            }

            if (IsDone)
            {
                DialogResult result = MessageBox.Show("Figure created with given inputs. Press OK to play!", "Do you want to play with these parameters?", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    PlayGround playGround = new PlayGround(_circle, _rectangle, _speed, FigureType);
                    playGround.Show();
                }
            }

            if (!IsDone)
            {
                DialogResult result = MessageBox.Show("Since something went wrong, figure created by default values. Press OK to play!", "Do you want to play with default parameters?", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    PlayGround playGround = new PlayGround(_circle, _rectangle, _speed, FigureType);
                    playGround.Show();
                }
            }

        }
    }
}
