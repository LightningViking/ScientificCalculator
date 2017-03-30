using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)//Handle all number input
        {
            Button clickedButton = (Button)sender;
            if (clickedButton.Text == "." && txtDisplay.Text.Contains("."))// check if textbox already has a decimal point
            {
                return;
            }
            else
            {
                txtDisplay.Text += clickedButton.Text;
            }            
        }

        private void btnClear_Click(object sender, EventArgs e)// clear textbox and set variables back to 0
        {
            txtDisplay.Clear();
            A = B = Result = 0;
        }

        double A = 0;
        double B = 0;
        double Result = 0;
        bool addBtnClicked = false;
        bool subBtnClicked = false;
        bool divBtnClicked = false;
        bool multBtnClicked = false;
        //Arithmetic
        private void btnAdd_Click(object sender, EventArgs e)// set for addition
        {
            if (txtDisplay.Text != "")// check if the textbox is empty
            {
                A += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();

                addBtnClicked = true;
                subBtnClicked = false;
                divBtnClicked = false;
                multBtnClicked = false;
            }
            else
            {
                MessageBox.Show("Please input a number first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnMinus_Click(object sender, EventArgs e)// set for subtraction
        {
            if (txtDisplay.Text != "")// check if the textbox is empty
            {
                A += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();

                addBtnClicked = false;
                subBtnClicked = true;
                divBtnClicked = false;
                multBtnClicked = false;
            }
            else
            {
                MessageBox.Show("Please input a number first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnMultiply_Click(object sender, EventArgs e)// set for multiplication
        {
            if (txtDisplay.Text != "")// check if the textbox is empty
            {
                A += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();

                addBtnClicked = false;
                subBtnClicked = false;
                divBtnClicked = false;
                multBtnClicked = true;
            }
            else
            {
                MessageBox.Show("Please input a number first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)// set for division
        {
            if (txtDisplay.Text != "")// check if the textbox is empty
            {
                A = double.Parse(txtDisplay.Text);
                txtDisplay.Clear();

                addBtnClicked = false;
                subBtnClicked = false;
                divBtnClicked = true;
                multBtnClicked = false;
            }
            else
            {
                MessageBox.Show("Please input a number first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnEqu_Click(object sender, EventArgs e)// perform equation
        {
            if (txtDisplay.Text == "")// check if the textbox is empty, if so text equals A
            {
                txtDisplay.Text = A.ToString();
            }
            if (addBtnClicked == true)
            {
                B = double.Parse(txtDisplay.Text);
                Result = Maths.Class1.Arithmetic.Add(A, B);// use Add function from Maths library
            }
            else if (subBtnClicked == true)
            {
                B = double.Parse(txtDisplay.Text);
                Result = Maths.Class1.Arithmetic.Sub(A, B);// use Sub function from Maths library
            }
            else if (multBtnClicked == true)
            {
                B = double.Parse(txtDisplay.Text);
                Result = Maths.Class1.Arithmetic.Mult(A, B);// use Mult function from Maths library
            }
            else if (divBtnClicked == true)
            {
                B = double.Parse(txtDisplay.Text);
                Result = Maths.Class1.Arithmetic.Div(A, B);// use Div function from Maths library
            }
            txtDisplay.Text = Result.ToString();
            A = B = Result = 0;
        }
        //Algebraic
        private void btnSquRoot_Click(object sender, EventArgs e)// use SQRT function from Maths Library
        {
            if (txtDisplay.Text != "")// check if the textbox is empty
            {
                A = double.Parse(txtDisplay.Text);
                Result = Maths.Class1.Algebraic.SQRT(A);
                txtDisplay.Text = Result.ToString();
            }
            else
            {
                MessageBox.Show("Please input a number first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCubeRoot_Click(object sender, EventArgs e)// use CBRT function from Maths Library
        {
            if (txtDisplay.Text != "")// check if the textbox is empty
            {
                A = double.Parse(txtDisplay.Text);
                Result = Maths.Class1.Algebraic.CBRT(A);
                txtDisplay.Text = Result.ToString();
            }
            else
            {
                MessageBox.Show("Please input a number first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInvert_Click(object sender, EventArgs e)// use Invert function from Maths Library
        {
            if (txtDisplay.Text != "")// check if the textbox is empty
            {
                A = double.Parse(txtDisplay.Text);
                Result = Maths.Class1.Algebraic.Invert(A);
                txtDisplay.Text = Result.ToString();
            }
            else
            {
                MessageBox.Show("Please input a number first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Trigonometric
        private void btnSin_Click(object sender, EventArgs e)// use Sin function from Maths Library
        {
            if (txtDisplay.Text != "")// check if the textbox is empty
            {
                A = double.Parse(txtDisplay.Text);
                Result = Maths.Class1.Trigonometric.Sin(A);
                txtDisplay.Text = Result.ToString();
            }
            else
            {
                MessageBox.Show("Please input a number first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCos_Click(object sender, EventArgs e)// use Cos function from Maths Library
        {
            if (txtDisplay.Text != "")// check if the textbox is empty
            {
                A = double.Parse(txtDisplay.Text);
                Result = Maths.Class1.Trigonometric.Cos(A);
                txtDisplay.Text = Result.ToString();
            }
            else
            {
                MessageBox.Show("Please input a number first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTan_Click(object sender, EventArgs e)// use Tan function from Maths Library
        {
            if (txtDisplay.Text != "")// check if the textbox is empty
            {
                if (Convert.ToDouble(txtDisplay.Text) == 90)// check if input is 90, Tan(90) is invalid
                {
                    txtDisplay.Text = "Invalid";
                }
                else
                {
                    A = double.Parse(txtDisplay.Text);
                    Result = Maths.Class1.Trigonometric.Tan(A);
                    txtDisplay.Text = Result.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please input a number first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Menu strip
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)// Quit Application
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)// Ask if want to quit application
            {
                Application.Exit();
            }
        }
    }
}
