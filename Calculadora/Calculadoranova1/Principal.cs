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
    public partial class Principal :MetroFramework.Forms.MetroForm
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculadora form1 = new Calculadora();
            form1.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Calculadora form1 = new Calculadora();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            integrantes form2 = new integrantes();
            form2.Show();
        }
    }
}
