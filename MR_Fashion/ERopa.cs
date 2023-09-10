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
    public partial class ERopa : Form
    {

        System.Data.DataRow[] dato;
        public ERopa()
        {
            InitializeComponent();
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

                    np.Text = dato[0]["nombre_producto"].ToString();
                    cp.Text = dato[0]["codigo_producto"].ToString();
                    canp.Text = dato[0]["cantidad_productos"].ToString();
                    prep.Text = dato[0]["precio_unidad"].ToString();
                    g.Text = dato[0]["genero"].ToString();
                    origen.Text = dato[0]["origen"].ToString();
                    c.Text = dato[0]["talla"].ToString();
                    t.Text = dato[0]["color"].ToString();
                    cproducto.Clear();

                }
                else
                {
                    np.Text = "";
                    cp.Text = "";
                    canp.Text = "";
                    prep.Text = "";
                    g.Text = "";
                    origen.Text = "";
                    c.Text = "";
                    t.Text = "";
                    MessageBox.Show("El producto no existe en los regisntros");
                    cproducto.Clear();
                }
            }
            else
            {

                MessageBox.Show("Por favor ingrese un codigo valido");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            dato[0].Delete();
            dataSet11.tblProductos.WriteXml("D:\\Arch_Ropa.xml");
            np.Text = "";
            cp.Text = "";
            canp.Text = "";
            prep.Text = "";
            g.Text = "";
            origen.Text = "";
            c.Text = "";
            t.Text = "";
            MessageBox.Show("Se ha eliminado correctamente");
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
