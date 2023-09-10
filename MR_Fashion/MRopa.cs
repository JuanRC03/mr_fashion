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

    public partial class MRopa : Form
    {
        int cant_pro = 0, genero = 0, origen = 0, tal = 0, col = 0;

        private void txbgenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txbgenero.Text == "Masculino" || txbgenero.Text == "Femenino") genero = 1;
            else genero = 0;
        }

        private void txborigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txborigen.Text == "Nacional" || txborigen.Text == "Extranjero") origen = 1;
            else origen = 0;
        }

        private void talla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (talla.Text == "XXS" || talla.Text == "XS" || talla.Text == "M" || talla.Text == "L" || talla.Text == "XL" || talla.Text == "XXL") tal = 1;
            else tal = 0;
        }

        private void color_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (color.Text == "Amarillo" || color.Text == "Rojo" || color.Text == "Celeste" || color.Text == "Blanco" || color.Text == "Verde" || color.Text == "Violeta" || color.Text == "Azul" || color.Text == "Rosa" || color.Text == "Negro") col = 1;
            else col = 0;
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            VerificarCodigoProducto ov = new VerificarCodigoProducto();
            try
            {
                float x = float.Parse(txbcantidad.Text);

                if ((txbnombre.Text != "") && (ov.verificarp(txbcodigo.Text) == true) && (txbcantidad.Text != "") && (x > 0) && (cant_pro == 1) && (genero == 1) && (origen == 1) && (tal == 1) && (col == 1))
                {
                    
                    dato[0]["nombre_producto"] = txbnombre.Text;
                    dato[0]["codigo_producto"] = txbcodigo.Text;
                    dato[0]["cantidad_productos"] = txbcantidad.Text;
                    dato[0]["precio_unidad"] = txbprecio.Text;
                    dato[0]["genero"] = txbgenero.SelectedItem;
                    dato[0]["origen"] = txborigen.SelectedItem;
                    dato[0]["talla"] = talla.SelectedItem;
                    dato[0]["color"] = color.SelectedItem;
                    dato[0].AcceptChanges();
                    dataSet11.tblProductos.WriteXml("D:\\Arch_Ropa.xml");
                    MessageBox.Show("Se ha modificado correctamente");
                    dato[0].Delete();
                    this.Close();
                }
                else
                {
                    if (txbnombre.Text == "") txbnombre.Clear();
                    if (ov.verificarp(txbcodigo.Text) == false) txbcodigo.Clear();
                    if ((txbcantidad.Text == "") || (x < 1)) txbcantidad.Clear();
                    if (cant_pro == 0) txbprecio.Clear();
                    if (genero == 0) { txbgenero.SelectedIndex = -1; txbgenero.Text = ""; }
                    if (origen == 0) { txborigen.SelectedIndex = -1; txborigen.Text = ""; }
                    if (tal == 0) { talla.SelectedIndex = -1; talla.Text = ""; }
                    if (col == 0) { color.SelectedIndex = -1; color.Text = ""; }
                    dato[0].Delete();
                    MessageBox.Show("Por favor ingrese todos los datos correctos");

                }
            }
            catch
            {
                txbprecio.Clear();
                MessageBox.Show("Por favor ingrese todos los datos de manera correta");
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            VerificarCodigoProducto ov = new VerificarCodigoProducto();
            if (ov.verificarp(cproducto.Text) == true)
            {
                dataSet11.ReadXml("D:\\Arch_Ropa.xml");
                dato = dataSet11.tblProductos.Select("codigo_producto='" + cproducto.Text + "'");
                if (dato.Length > 0)
                {
                    txbnombre.Text = dato[0]["nombre_producto"].ToString();
                    txbcodigo.Text = dato[0]["codigo_producto"].ToString();
                    txbcantidad.Text = dato[0]["cantidad_productos"].ToString();
                    txbprecio.Text = dato[0]["precio_unidad"].ToString();
                    txbgenero.Text = dato[0]["genero"].ToString();
                    txborigen.Text = dato[0]["origen"].ToString();
                    talla.Text = dato[0]["talla"].ToString();
                    color.Text = dato[0]["color"].ToString();
                    gbxmodificar.Enabled = true;
                    cproducto.Clear();
                }
                else
                {
                    MessageBox.Show("El producto no existe");
                    gbxmodificar.Enabled = false;
                    txbnombre.Clear();
                    txbcodigo.Clear();
                    txbcantidad.Clear();
                    txbprecio.Clear();
                    txbgenero.SelectedIndex = -1;
                    txborigen.SelectedIndex = -1;
                    talla.SelectedIndex = -1;
                    color.SelectedIndex = -1;
                    
                }

            }
            else
            {
                MessageBox.Show("Por favor ingrese un codigo valido");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbprecio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(txbprecio.Text);
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

        System.Data.DataRow[] dato;
        public MRopa()
        {
            InitializeComponent();
        }

        private void cproducto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
    }
}
