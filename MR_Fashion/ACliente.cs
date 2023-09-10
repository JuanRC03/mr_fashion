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
    public partial class ACliente : Form
    {
        int c = 0, fn = 0, gn = 0, es = 0, tl = 0, d=0,n=0,a=0,deu=0;

        private void txbfechanacimiento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            validarFecha ov = new validarFecha();
            if (ov.validarf(txbfechanacimiento.Text) == true) fn = 1;
            else fn = 0;
        }

        private void txbnombre_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txbnombre.Text == "") n = 0;
            else n = 1;
        }

        private void txbapellido_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txbapellido.Text == "") a = 0;
            else a = 1;
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

        private void txbcedula_KeyPress(object sender, KeyPressEventArgs e)
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                txbdeuda.Focus();

            }
        }

        private void txbdeuda_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txbdeuda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float deuda = float.Parse(txbdeuda.Text);
                if (deuda >= 0)
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

        private void cbxgenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxgenero.Text == "Masculino" || cbxgenero.Text == "Femenino") gn = 1;
            else gn = 0;
        }

        private void cbxestadocivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxestadocivil.Text == "Soltero" || cbxestadocivil.Text == "Casado" || cbxestadocivil.Text == "Divorciado" || cbxestadocivil.Text == "Viudo" ) es = 1;
            else es = 0;
        }

        private void txbdireccion_TextChanged(object sender, EventArgs e)
        {
            if (txbdireccion.Text =="") d = 0;
            else d = 1;
        }

        private void txbnumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ValidarTelefono ot = new ValidarTelefono();
            if (txbnumero.Text.Length == 12) { tl = 1; }
            else { tl = 0; }
        }

        public ACliente()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            ValidarCedula oc = new ValidarCedula();
            validarFecha of = new validarFecha();
            ValidarTelefono ot = new ValidarTelefono();
            if ((oc.validar(txbcedula.Text)==true)&&(of.validarf(txbfechanacimiento.Text)==true)&&(ot.validart(txbnumero.Text)==true)&&((d+gn+es)==3)&&(txbnombre.Text!="")&&(txbapellido.Text!=""&&(deu==1)))
            {
                dataSet11.ReadXml("D:\\Arch_Cliente.xml");
                object[] dato = new object[9];
                dato[0] = txbnombre.Text;
                dato[1] = txbapellido.Text;
                dato[2] = txbcedula.Text;
                dato[3] = cbxgenero.SelectedItem;
                dato[4] = cbxestadocivil.SelectedItem;
                dato[5] = txbfechanacimiento.Text;
                dato[6] = txbnumero.Text;
                dato[7] = txbdireccion.Text;
                dato[8] = txbdeuda.Text;
                dataSet11.tblClientes.Rows.Add(dato);
                dataSet11.WriteXml("D:\\Arch_Cliente.xml");
                MessageBox.Show("Se ha guardado correctamente");
                txbnombre.Clear();
                MessageBox.Show("El ciente se ha guardado correctamente");
                this.Close();
            }
            else
            {
                if (oc.validar(txbcedula.Text) == false) txbcedula.Clear();
                if (of.validarf(txbfechanacimiento.Text) == false) txbfechanacimiento.Clear();
                if (gn == 0) {cbxgenero.SelectedIndex = -1;cbxgenero.Text="" ;}
                if (es == 0) { cbxestadocivil.SelectedIndex = -1;cbxestadocivil.Text="" ; }
                if (ot.validart(txbnumero.Text) == false) txbnumero.Clear();
                if (d == 0) txbdireccion.Clear();
                if (txbnombre.Text == "") txbnombre.Clear();
                if (txbapellido.Text == "") txbapellido.Clear();
                if (deu == 0) txbdeuda.Clear();
                MessageBox.Show("Por favor, ingrese bien los datos y no deje en blaco los casilleros");
            }
        }

        private void txbcedula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ValidarCedula ov = new ValidarCedula();
            if (ov.validar(txbcedula.Text) == false) c = 1;
            else c = 0;

        }
    }
}
