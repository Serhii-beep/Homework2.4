using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HM_Geometry
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblSide1_Click(object sender, EventArgs e)
        {

        }

        private void Check(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException();
            }
            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                throw new ArgumentException();
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            
            double side1 = 0.0;
            double side2 = 0.0;
            double side3 = 0.0;
            try
            {
                side1 = double.Parse(tbSide1.Text);
                side2 = double.Parse(tbSide2.Text);
                side3 = double.Parse(tbSide3.Text);
                Check(side1, side2, side3);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Неправильно введена сторона {0}", ex.Message);
                return;
            }
            if(side1 == side2 && side1 == side3 && side2 == side3)
            {
                EquilateralTriangle etr = new EquilateralTriangle(side1);
                tbAngle1.Text = etr.Angle1.ToString();
                tbAngle2.Text = etr.Angle2.ToString();
                tbAngle3.Text = etr.Angle3.ToString();
                tbPerimeter.Text = etr.Perimeter.ToString();
                tbArea.Text = etr.Area.ToString();
            }
            else
            {
                Triangle tr = new Triangle(side1, side2, side3);
                tbAngle1.Text = tr.Angle1.ToString();
                tbAngle2.Text = tr.Angle2.ToString();
                tbAngle3.Text = tr.Angle3.ToString();
                tbPerimeter.Text = tr.Perimeter.ToString();
                tbArea.Text = tr.Area.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbSide1.Clear();
            tbSide2.Clear();
            tbSide3.Clear();
            tbAngle1.Clear();
            tbAngle2.Clear();
            tbAngle3.Clear();
            tbPerimeter.Clear();
            tbArea.Clear();
        }
    }
}
