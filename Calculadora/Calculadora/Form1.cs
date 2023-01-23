using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        static int verificar = 0;

        string soma()
        {
            double result = Convert.ToDouble(lblResult.Text);
            double num = Convert.ToDouble(txtCalculo.Text);
            num = result + num;
            txtCalculo.Clear();
            return lblResult.Text = num.ToString("F");
        }

        string subtracao()
        {
            double result = Convert.ToDouble(lblResult.Text);
            double num = Convert.ToDouble(txtCalculo.Text);

            if (result !=0)
                num = result - num;
            else
                num = num - result;

            txtCalculo.Clear();
            return lblResult.Text = num.ToString("F");
        }

        string divisao()
        {
            double result = Convert.ToDouble(lblResult.Text);
            double num = Convert.ToDouble(txtCalculo.Text);
            num = result / num;
            txtCalculo.Clear();
            return lblResult.Text = num.ToString("F");
        }

        string multiplicacao()
        {
            double result = Convert.ToDouble(lblResult.Text);
            double num = Convert.ToDouble(txtCalculo.Text);
            num = result * num;
            txtCalculo.Clear();
            return lblResult.Text = num.ToString("F");
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "9";
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "0";
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += ",";
        }

        

        private void btnSoma_Click(object sender, EventArgs e)
        {
            soma();
            verificar = 1;
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            subtracao();
            verificar = 2;
        }        

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            divisao();
            verificar = 3;
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            multiplicacao();
            verificar = 4;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCalculo.Clear();
            lblResult.Text = "0";
            lblResult.Visible = false;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (verificar == 1)
            {
                soma();
            }
            else if(verificar == 2)
            {
                subtracao();
            }
            else if (verificar == 3)
            {
                divisao();
            }
            else if (verificar == 4)
            {
                multiplicacao();
            }

            lblResult.Visible = true;
        }
    }
}
