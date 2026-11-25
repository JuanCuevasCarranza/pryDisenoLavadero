namespace pryDisenoLavadero
{
    partial class frmLavados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbDatosDeLavado = new GroupBox();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            chkClienteFrecuente = new CheckBox();
            grbEntrega = new GroupBox();
            rdbExpress = new RadioButton();
            rdbNormal = new RadioButton();
            txtVehiculos = new TextBox();
            lblVehiculos = new Label();
            cmbServicio = new ComboBox();
            lblServicio = new Label();
            lblPatente = new Label();
            txtPatente = new TextBox();
            txtCliente = new TextBox();
            lblCliente = new Label();
            grbImporte = new GroupBox();
            lblTotal = new Label();
            lblDescuento = new Label();
            lblRecargo = new Label();
            lblSubtotal = new Label();
            grbDatosDeLavado.SuspendLayout();
            grbEntrega.SuspendLayout();
            grbImporte.SuspendLayout();
            SuspendLayout();
            // 
            // grbDatosDeLavado
            // 
            grbDatosDeLavado.Controls.Add(btnLimpiar);
            grbDatosDeLavado.Controls.Add(btnCalcular);
            grbDatosDeLavado.Controls.Add(chkClienteFrecuente);
            grbDatosDeLavado.Controls.Add(grbEntrega);
            grbDatosDeLavado.Controls.Add(txtVehiculos);
            grbDatosDeLavado.Controls.Add(lblVehiculos);
            grbDatosDeLavado.Controls.Add(cmbServicio);
            grbDatosDeLavado.Controls.Add(lblServicio);
            grbDatosDeLavado.Controls.Add(lblPatente);
            grbDatosDeLavado.Controls.Add(txtPatente);
            grbDatosDeLavado.Controls.Add(txtCliente);
            grbDatosDeLavado.Controls.Add(lblCliente);
            grbDatosDeLavado.Location = new Point(12, 12);
            grbDatosDeLavado.Name = "grbDatosDeLavado";
            grbDatosDeLavado.Size = new Size(336, 410);
            grbDatosDeLavado.TabIndex = 0;
            grbDatosDeLavado.TabStop = false;
            grbDatosDeLavado.Text = "Datos de Lavado";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(231, 364);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(99, 35);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Enabled = false;
            btnCalcular.Location = new Point(6, 364);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(98, 35);
            btnCalcular.TabIndex = 15;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // chkClienteFrecuente
            // 
            chkClienteFrecuente.AutoSize = true;
            chkClienteFrecuente.Location = new Point(23, 325);
            chkClienteFrecuente.Name = "chkClienteFrecuente";
            chkClienteFrecuente.Size = new Size(173, 19);
            chkClienteFrecuente.TabIndex = 1;
            chkClienteFrecuente.Text = "Cliente Frecuente (5% extra)";
            chkClienteFrecuente.UseVisualStyleBackColor = true;
            // 
            // grbEntrega
            // 
            grbEntrega.Controls.Add(rdbExpress);
            grbEntrega.Controls.Add(rdbNormal);
            grbEntrega.Location = new Point(52, 204);
            grbEntrega.Name = "grbEntrega";
            grbEntrega.Size = new Size(229, 100);
            grbEntrega.TabIndex = 12;
            grbEntrega.TabStop = false;
            grbEntrega.Text = "Entrega";
            // 
            // rdbExpress
            // 
            rdbExpress.AutoSize = true;
            rdbExpress.Location = new Point(110, 39);
            rdbExpress.Name = "rdbExpress";
            rdbExpress.Size = new Size(104, 19);
            rdbExpress.TabIndex = 12;
            rdbExpress.TabStop = true;
            rdbExpress.Text = "Express (+25%)";
            rdbExpress.UseVisualStyleBackColor = true;
            // 
            // rdbNormal
            // 
            rdbNormal.AutoSize = true;
            rdbNormal.Location = new Point(27, 39);
            rdbNormal.Name = "rdbNormal";
            rdbNormal.Size = new Size(65, 19);
            rdbNormal.TabIndex = 11;
            rdbNormal.TabStop = true;
            rdbNormal.Text = "Normal";
            rdbNormal.UseVisualStyleBackColor = true;
            rdbNormal.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // txtVehiculos
            // 
            txtVehiculos.Location = new Point(121, 165);
            txtVehiculos.MaxLength = 5;
            txtVehiculos.Name = "txtVehiculos";
            txtVehiculos.Size = new Size(44, 23);
            txtVehiculos.TabIndex = 10;
            txtVehiculos.KeyPress += txtVehiculos_KeyPress;
            // 
            // lblVehiculos
            // 
            lblVehiculos.AutoSize = true;
            lblVehiculos.Location = new Point(23, 168);
            lblVehiculos.Name = "lblVehiculos";
            lblVehiculos.Size = new Size(92, 15);
            lblVehiculos.TabIndex = 9;
            lblVehiculos.Text = "Vehículos (1 a 5)";
            lblVehiculos.Click += label1_Click_1;
            // 
            // cmbServicio
            // 
            cmbServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Items.AddRange(new object[] { "Lavado Exterior", "Lavado Completo ", "Lavado Con Encerado" });
            cmbServicio.Location = new Point(107, 119);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(193, 23);
            cmbServicio.TabIndex = 8;
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(23, 119);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(48, 15);
            lblServicio.TabIndex = 5;
            lblServicio.Text = "Servicio";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(23, 75);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(47, 15);
            lblPatente.TabIndex = 4;
            lblPatente.Text = "Patente";
            lblPatente.Click += label1_Click;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(107, 75);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(103, 23);
            txtPatente.TabIndex = 2;
            txtPatente.KeyPress += txtPatente_KeyPress;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(107, 30);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(193, 23);
            txtCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(23, 33);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // grbImporte
            // 
            grbImporte.Controls.Add(lblTotal);
            grbImporte.Controls.Add(lblDescuento);
            grbImporte.Controls.Add(lblRecargo);
            grbImporte.Controls.Add(lblSubtotal);
            grbImporte.Location = new Point(12, 428);
            grbImporte.Name = "grbImporte";
            grbImporte.Size = new Size(336, 177);
            grbImporte.TabIndex = 18;
            grbImporte.TabStop = false;
            grbImporte.Text = "Importe";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotal.Location = new Point(20, 130);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(117, 15);
            lblTotal.TabIndex = 20;
            lblTotal.Text = "Total a pagar: $ 0.00";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(20, 95);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(96, 15);
            lblDescuento.TabIndex = 19;
            lblDescuento.Text = "Descuento: $0.00";
            // 
            // lblRecargo
            // 
            lblRecargo.AutoSize = true;
            lblRecargo.Location = new Point(20, 65);
            lblRecargo.Name = "lblRecargo";
            lblRecargo.Size = new Size(83, 15);
            lblRecargo.TabIndex = 18;
            lblRecargo.Text = "Recargo: $0.00";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(20, 35);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(84, 15);
            lblSubtotal.TabIndex = 17;
            lblSubtotal.Text = "Subtotal: $0.00";
            // 
            // frmLavados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(359, 609);
            Controls.Add(grbImporte);
            Controls.Add(grbDatosDeLavado);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmLavados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lavadero de los Andes - Calculo de Servicio";
            Load += frmLavados_Load;
            grbDatosDeLavado.ResumeLayout(false);
            grbDatosDeLavado.PerformLayout();
            grbEntrega.ResumeLayout(false);
            grbEntrega.PerformLayout();
            grbImporte.ResumeLayout(false);
            grbImporte.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbDatosDeLavado;
        private Label lblCliente;
        private Label lblServicio;
        private Label lblPatente;
        private TextBox txtPatente;
        private TextBox txtCliente;
        private ComboBox cmbServicio;
        private Label lblVehiculos;
        private TextBox txtVehiculos;
        private GroupBox grbEntrega;
        private RadioButton rdbNormal;
        private RadioButton rdbExpress;
        private CheckBox chkClienteFrecuente;
        private Button btnLimpiar;
        private Button btnCalcular;
        private GroupBox grbImporte;
        private Label lblSubtotal;
        private Label lblRecargo;
        private Label lblDescuento;
        private Label lblTotal;
    }
}