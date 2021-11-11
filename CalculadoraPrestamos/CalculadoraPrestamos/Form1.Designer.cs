
namespace CalculadoraPrestamos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.cmbTipoPrestamo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMesesPago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCuotaMensual = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto del Prestamo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tasa de Interes %:";
            // 
            // txtMontoPrestamo
            // 
            this.txtMontoPrestamo.Location = new System.Drawing.Point(211, 80);
            this.txtMontoPrestamo.Name = "txtMontoPrestamo";
            this.txtMontoPrestamo.Size = new System.Drawing.Size(121, 20);
            this.txtMontoPrestamo.TabIndex = 4;
            this.txtMontoPrestamo.Text = "0";
            this.txtMontoPrestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontoPrestamo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoPrestamo_KeyPress);
            // 
            // cmbTipoPrestamo
            // 
            this.cmbTipoPrestamo.FormattingEnabled = true;
            this.cmbTipoPrestamo.Items.AddRange(new object[] {
            "Personal",
            "Automovil",
            "Hipotecario"});
            this.cmbTipoPrestamo.Location = new System.Drawing.Point(211, 118);
            this.cmbTipoPrestamo.Name = "cmbTipoPrestamo";
            this.cmbTipoPrestamo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPrestamo.TabIndex = 5;
            this.cmbTipoPrestamo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPrestamo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipo de Prestamo:";
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.Enabled = false;
            this.txtTasaInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTasaInteres.Location = new System.Drawing.Point(211, 157);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(121, 20);
            this.txtTasaInteres.TabIndex = 7;
            this.txtTasaInteres.Text = "0%";
            this.txtTasaInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Meses para Pagar:";
            // 
            // cmbMesesPago
            // 
            this.cmbMesesPago.FormattingEnabled = true;
            this.cmbMesesPago.Items.AddRange(new object[] {
            "12",
            "18",
            "24",
            "30",
            "36",
            "42",
            "48",
            "54",
            "66",
            "72",
            "78",
            "84",
            "90",
            "96",
            "102",
            "108",
            "116",
            "120"});
            this.cmbMesesPago.Location = new System.Drawing.Point(211, 195);
            this.cmbMesesPago.Name = "cmbMesesPago";
            this.cmbMesesPago.Size = new System.Drawing.Size(121, 21);
            this.cmbMesesPago.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Calculadora de Prestamos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cuota Mensual:";
            // 
            // txtCuotaMensual
            // 
            this.txtCuotaMensual.Enabled = false;
            this.txtCuotaMensual.Location = new System.Drawing.Point(211, 282);
            this.txtCuotaMensual.Name = "txtCuotaMensual";
            this.txtCuotaMensual.Size = new System.Drawing.Size(121, 20);
            this.txtCuotaMensual.TabIndex = 12;
            this.txtCuotaMensual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.Location = new System.Drawing.Point(49, 228);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(283, 36);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 334);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCuotaMensual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMesesPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTasaInteres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoPrestamo);
            this.Controls.Add(this.txtMontoPrestamo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontoPrestamo;
        private System.Windows.Forms.ComboBox cmbTipoPrestamo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMesesPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCuotaMensual;
        private System.Windows.Forms.Button btnCalcular;
    }
}

