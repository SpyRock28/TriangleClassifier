using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[] minToMax;
        private int[] values = { 0, 0, 0};

        private bool isTriangle = false;
        private bool isIsosceles = false;
        private bool isEquilateral = false;
        private bool isRight = false;

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sideA_ValueChanged(object sender, EventArgs e)
        {
            if (sideA.Value < 0)
            {
                sideA.Value = sideA.Value * -1;
            }

            hasValues();
        }

        private void sideB_ValueChanged(object sender, EventArgs e)
        {
            if (sideB.Value < 0)
            {
                sideB.Value = sideB.Value * -1;
            }

            hasValues();
        }

        private void sideC_ValueChanged(object sender, EventArgs e)
        {
            if (sideC.Value < 0)
            {
                sideC.Value = sideC.Value * -1;
            }

            hasValues();
        }

        private void hasValues()
        {
            isTriangle = false;
            isIsosceles = false;
            isEquilateral = false;
            isRight = false;

            runChecks();
        }

        private void runChecks()
        {
            values[0] = (int)sideA.Value;
            values[1] = (int)sideB.Value;
            values[2] = (int)sideC.Value;

            minToMax = values.OrderBy(i => i).ToArray();

            checkTriangle();

            if (isTriangle)
            {
                checkEquilateral();
                checkIsosceles();
                checkRight();
            }

            //display the triangle results.
            displayResults();
        }

        private void displayResults()
        {
            String result;
            if (isTriangle)
            {
                if (isEquilateral)
                {
                    result = "These side lengths produce a valid equilateral triangle.";
                }
                else if (isIsosceles)
                {
                    result = "These side lengths produce a valid Isosceles triangle.";
                }
                else if (isRight)
                {
                    result = "These side lenghts produce a valid right triangle.";
                }
                else
                {
                    result = "These side lenghts produce a triangle.";
                }
            }
            else
            {
                result = "These side lenghts do not produce a triangle.";
            }

            results.Text = result;
        }

        private void checkTriangle()
        {
            if (minToMax[0] + minToMax[1] > minToMax[2])
            {
                isTriangle = true;
            }
        }

        private void checkEquilateral()
        {
            if (minToMax[0] == minToMax[1] &&
                minToMax[1] == minToMax[2])
            {
                isEquilateral = true;
            }
        }

        private void checkIsosceles()
        {
            if (minToMax[0] == minToMax[1] ||
                minToMax[1] == minToMax[2])
            {
                isIsosceles = true;
            }
        }

        private void checkRight()
        {
            if ((minToMax[0] * minToMax[0]) + (minToMax[1] * minToMax[1]) ==
                (minToMax[2] * minToMax[2]))
            {
                isRight = true;
            }
        }
    }
}
