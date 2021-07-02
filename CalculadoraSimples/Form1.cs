using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string calcular;

        #region SetNumbers
        private void n1_Click(object sender, EventArgs e)
        {
            tela.Text += n1.Text;
            
        }

        private void n2_Click(object sender, EventArgs e)
        {
            tela.Text += n2.Text;
            
        }

        private void n3_Click(object sender, EventArgs e)
        {
            tela.Text += n3.Text;
            
        }

        private void n4_Click(object sender, EventArgs e)
        {
            tela.Text += n4.Text;
            
        }

        private void n5_Click(object sender, EventArgs e)
        {
            tela.Text += n5.Text;
            
        }

        private void n6_Click(object sender, EventArgs e)
        {
            tela.Text += n6.Text;
           
        }

        private void n7_Click(object sender, EventArgs e)
        {
            tela.Text += n7.Text;
            
        }

        private void n8_Click(object sender, EventArgs e)
        {
            tela.Text += n8.Text;
        }

        private void n9_Click(object sender, EventArgs e)
        {
            tela.Text += n9.Text;
           
        }

        private void n0_Click(object sender, EventArgs e)
        {
            tela.Text += n0.Text;
            
        }

        private void soma_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text.Split('+', '-', 'x', '/')[0];
            tela.Text += soma.Text;
            calcular = "+";
        }

        private void subtrai_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text.Split('+', '-', 'x', '/')[0];
            tela.Text += subtrai.Text;
            calcular = "-";
        }

        private void multiplica_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text.Split('+', '-', 'x', '/')[0];
            tela.Text += multiplica.Text;
            calcular = "x";
        }

        private void dividi_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text.Split('+', '-', 'x', '/')[0];
            tela.Text += dividi.Text;
            calcular = "/";
        }
        #endregion

        private void igual_Click(object sender, EventArgs e)
        {
            var result = "";
            string[] numbers = tela.Text.Split('+','-','x','/');
            switch (calcular)
            {
                case "+":
                    result = (double.Parse(numbers[0]) + double.Parse(numbers[1])).ToString();
                    limpar_Click(limpar, EventArgs.Empty);
                    tela.Text = result;
                    break;
                case "-":
                    result = (double.Parse(numbers[0]) - double.Parse(numbers[1])).ToString();
                    limpar_Click(limpar, EventArgs.Empty);
                    tela.Text = result;
                    break;
                case "x":
                    result = (double.Parse(numbers[0]) * double.Parse(numbers[1])).ToString();
                    limpar_Click(limpar, EventArgs.Empty);
                    tela.Text = result;
                    break;
                case "/":
                    result = (double.Parse(numbers[0]) / double.Parse(numbers[1])).ToString();
                    limpar_Click(limpar, EventArgs.Empty);
                    tela.Text = result;
                    break;
                default:
                    break;
            }
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            tela.Text = "";
            calcular = null;
        }
    }
}
