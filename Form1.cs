using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo18B
{
    public partial class Form1 : Form
    {
        Triangulo myTriangle;

        public Form1()
        {
            InitializeComponent();
            myTriangle = new Triangulo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myTriangle = new Triangulo(
                Convert.ToDouble(textBox1.Text), 
                Convert.ToDouble(textBox2.Text),
                Convert.ToDouble(textBox3.Text));
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if  (myTriangle.EsEquilatero(
                Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text),
                Convert.ToDouble(textBox3.Text)))
            {
                MessageBox.Show("Si es equilatero");
            }
            else
            {
                MessageBox.Show("No es equilatero");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            myTriangle.LadoMayor(
                Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text),
                Convert.ToDouble(textBox3.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El area del triángulo es: " +
            myTriangle.Area(
                Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text)));
        }
    }
}
