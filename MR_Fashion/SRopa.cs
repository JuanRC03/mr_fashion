using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MR_Fashion
{
    public partial class SRopa : UserControl
    {
        public SRopa()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            VerificarCodigoProducto ov = new VerificarCodigoProducto();
            if (ov.verificarp(cproducto.Text) == true)
            {
                dataSet11.ReadXml("D:\\Arch_Ropa.xml");
                System.Data.DataRow[] dato;
                dato = dataSet11.tblProductos.Select("codigo_producto='" + cproducto.Text + "'");
                if (dato.Length > 0)
                {
                    int s = int.Parse(dato[0]["cantidad_productos"].ToString());
                    if (s == 0) {
                        MessageBox.Show("El producto esta agotado");
                        np.Text = "";
                        cp.Text = "";
                        canp.Text = "";
                        prep.Text = "";
                    }
                    else {
                        np.Text = dato[0]["nombre_producto"].ToString();
                        cp.Text = dato[0]["codigo_producto"].ToString();
                        canp.Text = dato[0]["cantidad_productos"].ToString();
                        prep.Text = dato[0]["precio_unidad"].ToString();
                        MessageBox.Show("El producto aun esta en strock");
                    }
                }
                else
                {
                    np.Text = "";
                    cp.Text = "";
                    canp.Text = "";
                    prep.Text = "";
                    MessageBox.Show("El producto no existe en los regisntros");
                    cproducto.Clear();
                }
            }
            else
            {

                MessageBox.Show("Por favor ingrese un codigo valido");
                cproducto.Clear();
            }
        }
    }
}
