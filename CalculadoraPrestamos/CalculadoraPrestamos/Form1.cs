using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace CalculadoraPrestamos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CalcularPrestamo LogicaPrestamo;
        private void Form1_Load(object sender, EventArgs e)
        {
            LogicaPrestamo = new CalcularPrestamo();
            cmbMesesPago.SelectedIndex = 0;
            cmbTipoPrestamo.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogicaPrestamo.TipoPrestamo = cmbTipoPrestamo.SelectedIndex;
            txtTasaInteres.Text = LogicaPrestamo.ObtenerTasaInteres().ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtMontoPrestamo.Text) > 0)
            {
                LogicaPrestamo.Monto = Convert.ToDouble(txtMontoPrestamo.Text);
                LogicaPrestamo.CantidadMeses = Convert.ToInt32(cmbMesesPago.SelectedItem.ToString());

                txtCuotaMensual.Text = LogicaPrestamo.ObtenerCuotas().ToString(".00");
            }
            else
            {
                MessageBox.Show("Algunos de los valores se encuentran vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMontoPrestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back
                    || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator);
        }
    }
}
