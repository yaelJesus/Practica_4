using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblOperacion.Text = "";
            lblResultado.Text = "0";
        }
        bool signo = false;
        String aux;
        string calculo;
        double op2 = 0;

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char digito = e.KeyChar;
            Button btn = null;

            switch (digito)
            {
                case (char)Keys.D0:
                    btn = btnCero;
                    break;
                case (char)Keys.D1:
                    btn = btnUno;
                    break;
                case (char)Keys.D2:
                    btn = btnDos;
                    break;
                case (char)Keys.D3:
                    btn = btnTres;
                    break;
                case (char)Keys.D4:
                    btn = btnCuatro;
                    break;
                case (char)Keys.D5:
                    btn = btnCinco;
                    break;
                case (char)Keys.D6:
                    btn = btnSeis;
                    break;
                case (char)Keys.D7:
                    btn = btnSiete;
                    break;
                case (char)Keys.D8:
                    btn = btnOcho;
                    break;
                case (char)Keys.D9:
                    btn = btnNueve;
                    break;
            }

            /*if (btn != null)
            {
                btn.Select();
                btn.PerformClick();
            }*/
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int key = (int)e.KeyCode;
            Button btn = null;

            switch (key)
            {
                case (int)Keys.Add:
                    btn = this.btnSuma;
                    break;
                case (int)Keys.Subtract:
                    btn = this.btnResta;
                    break;
                case (int)Keys.Multiply:
                    btn = this.btnProducto;
                    break;
                case (int)Keys.Divide:
                    btn = this.btnDivision;
                    break;
                case (int)Keys.Decimal:
                case (int)Keys.Separator:
                    btn = this.btnPunto;
                    break;
                case 8:
                    btn = this.btnBack;
                    break;
                case (int)Keys.Escape:
                    btn = this.btnCE;
                    break;
                case (int)Keys.Enter:
                    btn = this.btnCE;
                    break;
            }
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "0")
            {
                lblResultado.Text += 0;
            }
        }
        private void btnUno_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "0")
            {
                lblResultado.Text += 1;
            }
            else
            {
                lblResultado.Text = "1";
            }
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "0")
            {
                lblResultado.Text += 2;
            }
            else
            {
                lblResultado.Text = "2";
            }
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "0")
            {
                lblResultado.Text += 3;
            }
            else
            {
                lblResultado.Text = "3";
            }
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "0")
            {
                lblResultado.Text += 4;
            }
            else
            {
                lblResultado.Text = "4";
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "0")
            {
                lblResultado.Text += 5;
            }
            else
            {
                lblResultado.Text = "5";
            }
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "0")
            {
                lblResultado.Text += 6;
            }
            else
            {
                lblResultado.Text = "6";
            }
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "0")
            {
                lblResultado.Text += 7;
            }
            else
            {
                lblResultado.Text = "7";
            }
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "0")
            {
                lblResultado.Text += 8;
            }
            else
            {
                lblResultado.Text = "8";
            }
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "0")
            {
                lblResultado.Text += 9;
            }
            else
            {
                lblResultado.Text = "9";
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!lblResultado.Text.Contains("."))
            {
                lblResultado.Text += ".";
            }
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "0")
            {
                if (signo)
                {
                    lblResultado.Text = aux;
                    signo = false;
                }
                else
                {
                    aux = lblResultado.Text;
                    lblResultado.Text = "-" + aux;
                    signo = true;
                }
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblOperacion.Text = "";
            lblResultado.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "0";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            String aux;
            aux = lblResultado.Text;
            if (aux.Length > 0)
            {
                aux = aux.Remove(aux.Length - 1);
                lblResultado.Text = aux;
                if (aux.Length == 0)
                {
                    lblResultado.Text = "0";
                }
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double op = double.Parse(lblResultado.Text);
            double raiz = 0;
            if (lblResultado.Text != "0")
            {
                raiz = Math.Sqrt(op);
                lblOperacion.Text = "√" + lblResultado.Text + " =";
                lblResultado.Text = raiz.ToString();
            }
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            double op = double.Parse(lblResultado.Text);
            double cuadrado = 0;
            if (lblResultado.Text != "0")
            {
                cuadrado = Math.Pow(op, 2);
                lblOperacion.Text =lblResultado.Text + "² =";
                lblResultado.Text = cuadrado.ToString();
            }
        }

        private void btnPorciento_Click(object sender, EventArgs e)
        {
            double op = double.Parse(lblResultado.Text);
            if (lblResultado.Text != "0")
            {
                op2 = op;
                calculo = "porciento";
                lblOperacion.Text = lblResultado.Text;
                lblResultado.Text = "0";
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double op = double.Parse(lblResultado.Text);
            if (lblResultado.Text != "0")
            {
                op2 = op;
                calculo = "division";
                lblOperacion.Text = lblResultado.Text + " ÷ ";
                lblResultado.Text = "0";
            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            double op = double.Parse(lblResultado.Text);
            if (lblResultado.Text != "0")
            {
                op2 = op;
                calculo = "producto";
                lblOperacion.Text = lblResultado.Text + " x ";
                lblResultado.Text = "0";
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double op = double.Parse(lblResultado.Text);
            if (lblResultado.Text != "0")
            {
                op2 = op;
                calculo = "resta";
                lblOperacion.Text = lblResultado.Text + " - ";
                lblResultado.Text = "0";
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double op = double.Parse(lblResultado.Text);
            if (lblResultado.Text != "0")
            {
                op2 = op;
                calculo = "suma";
                lblOperacion.Text = lblResultado.Text + " + ";
                lblResultado.Text = "0";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double op = double.Parse(lblResultado.Text);
            switch (calculo)
            {
                case "porciento":
                    lblOperacion.Text = op2 + "(" + lblResultado.Text + "%)";
                    lblResultado.Text = (op * (op2 / 100)).ToString();
                    break;
                case "division":
                    lblOperacion.Text = op2 + " ÷ " + lblResultado.Text + " =";
                    lblResultado.Text = (op2 / op).ToString();
                    break;
                case "producto":
                    lblOperacion.Text = op2 + " x " + lblResultado.Text + " =";
                    lblResultado.Text = (op * op2).ToString();
                    break;
                case "resta":
                    lblOperacion.Text = op2 + " - " + lblResultado.Text + " =";
                    lblResultado.Text = (op2 - op).ToString();
                    break;
                case "suma":
                    lblOperacion.Text = op2 + " + " + lblResultado.Text + " =";
                    lblResultado.Text = (op2 + op).ToString();
                    break;
            }
        }
    }
}
