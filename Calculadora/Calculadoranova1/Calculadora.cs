using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoranova1
{
    public partial class Calculadora : MetroFramework.Forms.MetroForm
    {
        double x, y, result, variavel;
        int op;
        bool res = false;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (res)
                txtresul.Text = "";
            res = false;
            if (res == false)
            {
                txtresul.Text += Convert.ToString(1);
                if (x != 0)
                    y = 1;
                else
                    x = 1;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (res)
                txtresul.Text = "";
            res = false;
            if (res == false)
            {
                txtresul.Text += Convert.ToString(2);
                if (x != 0)
                    y = 2;
                else
                    x = 2;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (res)
                txtresul.Text = "";
            res = false;
            if (res == false)
            {
                txtresul.Text += Convert.ToString(3);
                if (x != 0)
                    y = 3;
                else
                    x = 3;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (res)
                txtresul.Text = "";
            res = false;
            if (res == false)
            {
                txtresul.Text += Convert.ToString(4);
                if (x != 0)
                    y = 4;
                else
                    x = 4;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (res)
                txtresul.Text = "";
            res = false;
            if (res == false)
            {
                txtresul.Text += Convert.ToString(5);
                if (x != 0)
                    y = 5;
                else
                    x = 5;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (res)
                txtresul.Text = "";
            res = false;
            if (res == false)
            {
                txtresul.Text += Convert.ToString(6);
                if (x != 0)
                    y = 6;
                else
                    x = 6;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (res)
                txtresul.Text = "";
            res = false;
            if (res == false)
            {
                txtresul.Text += Convert.ToString(7);
                if (x != 0)
                    y = 7;
                else
                    x = 7;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (res)
                txtresul.Text = "";
            res = false;
            if (res == false)
            {
                txtresul.Text += Convert.ToString(8);
                if (x != 0)
                    y = 8;
                else
                    x = 8;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (res)
                txtresul.Text = "";
            res = false;
            if (res == false)
            {
                txtresul.Text += Convert.ToString(9);
                if (x != 0)
                    y = 9;
                else
                    x = 9;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (res)
                txtresul.Text = "";
            res = false;
            if (res == false)
            {
                txtresul.Text += Convert.ToString(0);
                if (x != 0)
                    y = 0;
                else
                    x = 0;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                y = Convert.ToDouble(txtresul.Text);
                if (op == 1)
                    result = variavel + y;
                if (op == 2)
                    result = variavel - y;
                if (op == 3)
                    result = variavel * y;
                if (op == 4)
                    result = variavel / y;
                txtresul.Text = Convert.ToString(result);
                variavel = Convert.ToDouble(txtresul.Text);
                res = true;
             }
            catch (Exception ex)
            {
                MessageBoxShow(ex.Message);
            }
        }
        
        private void btnc_Click(object sender, EventArgs e)
        {
            txtresul.Text = "";
            x = 0;
            variavel = 0;
            y = 0;
        }
        
        private void btnSomar_Click(object sender, EventArgs e)
        {
            op = 1;
            variavel = Convert.ToDouble(txtresul.Text);
            txtresul.Text = "";
        }
        
        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            op = 2;
            variavel = Convert.ToDouble(txtresul.Text);
            txtresul.Text = "";
        }

        

        private void btnMult_Click(object sender, EventArgs e)
        {
            op = 3;
            variavel = Convert.ToDouble(txtresul.Text);
            txtresul.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            op = 4;
            variavel = Convert.ToDouble(txtresul.Text);
            txtresul.Text = "";

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void MessageBoxShow(string message)
        {
            throw new NotImplementedException();
        }        
    }
}   
       

            

         