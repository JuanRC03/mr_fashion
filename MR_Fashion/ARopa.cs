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
    public partial class ARopa : Form
    {
        int cant_pro = 0, genero = 0, origen = 0,tal=0, col=0;

        private void cbxgenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxgenero.Text == "Masculino" || cbxgenero.Text == "Femenino") genero = 1;
            else genero = 0;
        }

        private void cbxorigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxorigen.Text == "Nacional" || cbxorigen.Text == "Extranjero") origen = 1;
            else origen = 0;
        }

        private void talla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (talla.Text == "XXS" || talla.Text == "XS" || talla.Text == "M" || talla.Text == "L" || talla.Text == "XL" || talla.Text == "XXL" ) tal = 1;
            else tal = 0;
        }

        private void color_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (color.Text == "Amarillo" || color.Text == "Rojo" || color.Text == "Celeste" || color.Text == "Blanco" || color.Text == "Verde" || color.Text == "Violeta" || color.Text == "Azul" || color.Text == "Rosa" || color.Text == "Negro" ) col = 1;
            else col = 0;
        }

        private void p_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                c.Focus();

            }
        }

        private void c_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                cp.Focus();

            }
        }

        private void cp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                precio.Focus();

            }
        }

        private void precio_KeyPress(object sender, KeyPressEventArgs e)
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
                cbxorigen.Focus();

            }
        }

        private void cbxorigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                talla.Focus();

            }
        }

        private void talla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                color.Focus();

            }

        }

        private void color_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ARopa_Load(object sender, EventArgs e)
        {
            p.Focus();
        }

        public ARopa()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            VerificarCodigoProducto ov = new VerificarCodigoProducto();
            try
            {
                float x = float.Parse(cp.Text);

                if ((p.Text != "") && (ov.verificarp(c.Text) == true) && (cp.Text != "") && (x > 0) && (cant_pro == 1) && (genero == 1) && (origen == 1) && (tal == 1) && (col == 1))
                {
                    dataSet11.ReadXml("D:\\Arch_Ropa.xml");
                    object[] dato = new object[8];
                    dato[0] = p.Text;
                    dato[1] = c.Text;
                    dato[2] = cp.Text;
                    dato[3] = precio.Text;
                    dato[4] = cbxgenero.SelectedItem;
                    dato[5] = cbxorigen.SelectedItem;
                    dato[6] = talla.SelectedItem;
                    dato[7] = color.SelectedItem;
                    dataSet11.tblProductos.Rows.Add(dato);
                    dataSet11.WriteXml("D:\\Arch_Ropa.xml");
                    p.Clear();
                    c.Clear();
                    cp.Clear();
                    precio.Clear();
                    cbxgenero.SelectedIndex = -1;
                    cbxorigen.SelectedIndex = -1;
                    talla.SelectedIndex = -1;
                    color.SelectedIndex = -1;
                    MessageBox.Show("Los datos se han guardado correctamente");
                    this.Close();
                }
                else
                {
                    if (p.Text == "") p.Clear();
                    if (ov.verificarp(c.Text) == false) c.Clear();
                    if ((cp.Text == "") || (x < 1)) cp.Clear();
                    if (cant_pro == 0) precio.Clear();
                    if (genero == 0) { cbxgenero.SelectedIndex = -1; cbxgenero.Text = ""; }
                    if (origen == 0) { cbxorigen.SelectedIndex = -1; cbxorigen.Text = ""; }
                    if (tal == 0) { talla.SelectedIndex = -1; talla.Text = ""; }
                    if (col == 0) { color.SelectedIndex = -1; color.Text = ""; }
                    MessageBox.Show("Por favor ingrese todos los datos de manera correta");

                }
            }
            catch
            {
                precio.Clear();
                MessageBox.Show("Por favor ingrese todos los datos de manera correta");
            }
            
        }

        private void precio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(precio.Text);
                if (x > 0)
                {
                    cant_pro = 1;
                }
                else
                {
                    cant_pro = 0;
                }
            }
            catch
            {
                cant_pro = 0;
            }
        }
    }
}
