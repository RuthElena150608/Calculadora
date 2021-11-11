using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace CalculadoraSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMostrar.Text = "0";
        }


        private void btn0_Click(object sender, EventArgs e)
        {

            if (primerElemento('0')) return;

            txtMostrar.Text += "0";

        }


        private void btn1_Click(object sender, EventArgs e)
        {
            EliminarPrimerElementoSiEs0();
            txtMostrar.Text += "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            EliminarPrimerElementoSiEs0();
            txtMostrar.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            EliminarPrimerElementoSiEs0();
            txtMostrar.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            EliminarPrimerElementoSiEs0();
            txtMostrar.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            EliminarPrimerElementoSiEs0();
            txtMostrar.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            EliminarPrimerElementoSiEs0();
            txtMostrar.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            EliminarPrimerElementoSiEs0();
            txtMostrar.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            EliminarPrimerElementoSiEs0();
            txtMostrar.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            EliminarPrimerElementoSiEs0();
            txtMostrar.Text += "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtMostrar.Text += ",";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int ultimoIndice = txtMostrar.TextLength - 1;
            if (ultimoIndice >= 0) txtMostrar.Text = txtMostrar.Text.Remove(ultimoIndice).Trim();

            if (txtMostrar.TextLength - 1 < 0)
            {
                txtMostrar.Text = "0";
            }
        }

        public bool primerElemento(char elementoABucar)
        {
            char primerElemento = txtMostrar.Text[0];
            if (primerElemento == elementoABucar && txtMostrar.TextLength == 1) return true;
            return false;
        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (primerElemento('0'))
            {
                return;
            }
            txtMostrar.Text += " + ";

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (primerElemento('0'))
            {
                return;
            }
            txtMostrar.Text += " - ";
        }

        private void btnMutiplicar_Click(object sender, EventArgs e)
        {
            if (primerElemento('0'))
            {
                return;
            }
            txtMostrar.Text += " * ";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (primerElemento('0'))
            {
                return;
            }
            txtMostrar.Text += " / ";
        }

        public void EliminarPrimerElementoSiEs0()
        {
            if (primerElemento('0'))
            {
                txtMostrar.Text = txtMostrar.Text.Remove(0, 1);
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            var Operacion = txtMostrar.Text.Split(' ');
            double uno, dos;

            try
            {

            double.TryParse(Operacion[0], out uno);
                string op = Operacion[1];
            double.TryParse(Operacion[2], out dos);

                Operaciones operacion = new Operaciones(uno, dos, op);
                var result = operacion.Calcular();
                if(result.Item2 == true)
                {
                    MessageBox.Show("NO SE PUEDE DIVIDIR ENTRE 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMostrar.Text = result.Item1.ToString();
                }
                txtMostrar.Text = result.Item1.ToString();

            }
            catch
            {
                return;
            }

        }
    }
}
