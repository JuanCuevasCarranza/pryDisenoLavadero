using System;
using System.Windows.Forms;

namespace pryDisenoLavadero
{
    public partial class frmLavados : Form
    {
        public frmLavados()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmLavados_Load(object sender, EventArgs e)
        {
            btnCalcular.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MostrarError("Ingrese el nombre del cliente.", txtCliente);
                return;
            }

            if (txtPatente.Text.Length != 6 && txtPatente.Text.Length != 7)
            {
                MostrarError("La patente debe tener 6 o 7 caracteres.", txtPatente);
                return;
            }

            if (cmbServicio.SelectedIndex == -1)
            {
                MostrarError("Seleccione un servicio.", cmbServicio);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtVehiculos.Text) ||
                !int.TryParse(txtVehiculos.Text, out int cantidad) || cantidad < 1 || cantidad > 5)
            {
                MostrarError("Ingrese una cantidad de vehículos entre 1 y 5.", txtVehiculos);
                return;
            }

            if (!rdbNormal.Checked && !rdbExpress.Checked)
            {
                MostrarError("Seleccione el tipo de entrega.", grbEntrega);
                return;
            }

            decimal precioPorVehiculo = cmbServicio.SelectedIndex switch
            {
                0 => 8000m,
                1 => 14000m,
                2 => 20000m,
                _ => 0m
            };
            decimal subtotal = precioPorVehiculo * cantidad;
            decimal porcentajeRecargo = 0m;
            if (rdbExpress.Checked)
            {
                porcentajeRecargo = 25m;
            }
            decimal recargo = subtotal * porcentajeRecargo / 100m;
            decimal porcentajeDescuento = 0m;
            if (cantidad >= 2 && cantidad <= 3)
            {
                porcentajeDescuento = 10m;
            }
            else if (cantidad >= 4 && cantidad <= 5)
            {
                porcentajeDescuento = 15m;
            }
            if (chkClienteFrecuente.Checked)
            {
                porcentajeDescuento += 5m;
            }
            decimal descuento = subtotal * porcentajeDescuento / 100m;
            decimal total = subtotal + recargo - descuento;
            lblSubtotal.Text = $"Subtotal: $ {subtotal.ToString("N2")}";
            lblRecargo.Text = $"Recargo: $ {recargo.ToString("N2")}";
            lblDescuento.Text = $"Descuento: {porcentajeDescuento:N0} % ($ {descuento.ToString("N2")})";
            lblTotal.Text = $"Total a pagar: $ {total.ToString("N2")}";
        }

        private void txtPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtVehiculos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtPatente.Clear();
            txtVehiculos.Clear();
            cmbServicio.SelectedIndex = -1;
            rdbNormal.Checked = false;
            rdbExpress.Checked = false;
            chkClienteFrecuente.Checked = false;
            lblSubtotal.Text = "Subtotal: $ 0.00";
            lblRecargo.Text = "Recargo: $ 0.00";
            lblDescuento.Text = "Descuento: 0 % ($ 0.00)";
            lblTotal.Text = "Total a pagar: $ 0.00";
            txtCliente.Focus();
        }

        private static void MostrarError(string mensaje, Control control)
        {
            MessageBox.Show(mensaje, "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }
    }
}
