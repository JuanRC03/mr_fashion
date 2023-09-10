using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MR_Fashion
{
    public partial class MCliente : Form
    {
        int c = 0, fn = 0, gn = 0, es = 0, tl = 0, d = 0, n = 0, a = 0, deu=0;

        private void cbxestadocivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxestadocivil.Text == "Soltero" || cbxestadocivil.Text == "Casado" || cbxestadocivil.Text == "Divorciado" || cbxestadocivil.Text == "Viudo") es = 1;
            else es = 0;
        }

        private void txbdireccion_TextChanged(object sender, EventArgs e)
        {
            if (txbdireccion.Text == "") d = 0;
            else d = 1;
        }

        private void txbnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                txbapellido.Focus();

            }
        }

        private void txbapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                txbcedula.Focus();

            }
        }

        private void txbapellido_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txbced_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                cbxgenero.Focus();

            }
        }

        private void cbxgenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                cbxestadocivil.Focus();

            }
        }

        private void cbxestadocivil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                txbfechanacimiento.Focus();

            }
        }

        private void txbfechanacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                txbnumero.Focus();

            }
        }

        private void txbnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                txbdireccion.Focus();

            }
        }

        private void txbdeuda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float deuda = float.Parse(txbdeuda.Text);
                if (deuda > 0)
                {
                    deu = 1;
                }
                else
                {
                    deu = 0;
                }
            }
            catch
            {
                deu = 0;
            }
        }

        System.Data.DataRow[] dato;
        public MCliente()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            ValidarCedula oV = new ValidarCedula();
            if (oV.validar(txbcedula.Text) != true)
            {
                MessageBox.Show("Por favor ingrese un número de cedula correcto");
                txbnombre.Clear();
                txbapellido.Clear();
                txbced.Clear();
                cbxgenero.SelectedIndex = -1;
                cbxestadocivil.SelectedIndex = -1;
                txbfechanacimiento.Clear();
                txbnumero.Clear();
                txbdireccion.Clear();
                txbcedula.Clear();
            }
            else{
                dataSet11.ReadXml("D:\\Arch_Cliente.xml");
                dato = dataSet11.tblClientes.Select("cedula='" + txbcedula.Text + "'");
                if (dato.Length > 0)
                {

                    txbnombre.Text = dato[0]["nombre"].ToString();
                    txbapellido.Text = dato[0]["apellido"].ToString();
                    txbced.Text = dato[0]["cedula"].ToString();
                    cbxgenero.Text = dato[0]["genero"].ToString();
                    cbxestadocivil.Text = dato[0]["estado_civil"].ToString();
                    txbfechanacimiento.Text = dato[0]["fecha_nacimiento"].ToString();
                    txbnumero.Text = dato[0]["telefono"].ToString();
                    txbdireccion.Text = dato[0]["direccion"].ToString();
                    txbdeuda.Text = dato[0]["deudor"].ToString();
                    gbxmodificar.Enabled = true;
                    txbcedula.Clear();
                }
                else
                {
                    txbnombre.Clear();
                    txbapellido.Clear();
                    txbced.Clear();
                    cbxgenero.SelectedIndex = -1;
                    cbxestadocivil.SelectedIndex = -1;
                    txbfechanacimiento.Clear();
                    txbnumero.Clear();
                    txbdireccion.Clear();
                    txbdeuda.Clear();
                    gbxmodificar.Enabled = false;
                    MessageBox.Show("El cliente no existe en los regisntros");
                    txbcedula.Clear();
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txbnombre.Clear();
            txbapellido.Clear();
            txbced.Clear();
            cbxgenero.SelectedIndex = -1;
            cbxestadocivil.SelectedIndex = -1;
            txbfechanacimiento.Clear();
            txbnumero.Clear();
            txbdireccion.Clear();
            txbdeuda.Clear();
            MessageBox.Show("Se ha cancelado la modificación");
            gbxmodificar.Enabled = false;
            this.Close();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            ValidarCedula oc = new ValidarCedula();
            validarFecha of = new validarFecha();
            ValidarTelefono ot = new ValidarTelefono();
            if ((oc.validar(txbced.Text) == true) && (of.validarf(txbfechanacimiento.Text) == true) && (ot.validart(txbnumero.Text) == true) && ((d + gn + es) == 3) && (txbnombre.Text != "") && (txbapellido.Text != "")&&(deu==1))
            {
                dato[0]["nombre"] = txbnombre.Text;
                dato[0]["apellido"] = txbapellido.Text;
                dato[0]["cedula"] = txbced.Text;
                dato[0]["genero"] = cbxgenero.SelectedItem;
                dato[0]["estado_civil"] = cbxestadocivil.SelectedItem;
                dato[0]["fecha_nacimiento"] = txbfechanacimiento.Text;
                dato[0]["telefono"] = txbnumero.Text;
                dato[0]["direccion"] = txbdireccion.Text;
                dato[0]["deudor"] = txbdeuda.Text;
                dato[0].AcceptChanges();
                dataSet11.tblClientes.WriteXml("D:\\Arch_Cliente.xml");
                txbnombre.Clear();
                txbapellido.Clear();
                txbced.Clear();
                cbxgenero.SelectedIndex = -1;
                cbxestadocivil.SelectedIndex = -1;
                txbfechanacimiento.Clear();
                txbnumero.Clear();
                txbdireccion.Clear();
                MessageBox.Show("Se ha modificado correctamente");
                this.Close();
                gbxmodificar.Enabled = false;
                dato[0].Delete();
            }
            else
            {
                if (oc.validar(txbced.Text) == false) txbcedula.Clear();
                if (of.validarf(txbfechanacimiento.Text) == false) txbfechanacimiento.Clear();
                if (gn == 0) { cbxgenero.SelectedIndex = -1; cbxgenero.Text = ""; }
                if (es == 0) { cbxestadocivil.SelectedIndex = -1; cbxestadocivil.Text = ""; }
                if (ot.validart(txbnumero.Text) == false) txbnumero.Clear();
                if (d == 0) txbdireccion.Clear();
                if (txbnombre.Text == "") txbnombre.Clear();
                if (txbapellido.Text == "") txbapellido.Clear();
                if (deu == 0) txbdeuda.Clear();
                MessageBox.Show("Por favor, ingrese bien los datos y no deje en blaco los casilleros");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxgenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxgenero.Text == "Masculino" || cbxgenero.Text == "Femenino") gn = 1;
            else gn = 0;
        }
    }
}
