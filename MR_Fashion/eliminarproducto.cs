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
    public partial class eliminarproducto : UserControl
    {
        System.Data.DataRow[] dato;
        public eliminarproducto()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
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
                groupBox2.Enabled = true;
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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            dato[0].Delete();
            dataSet11.tblClientes.WriteXml("D:\\Arch_Ropa.xml");
            np.Text = "";
            cp.Text = "";
            prep.Text = "";
            canp.Text = "";
            g.Text = "";
            c.Text = "";
            origen.Text = "";
            t.Text = "";
            groupBox2.Enabled = false;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            np.Text = "";
            cp.Text = "";
            prep.Text = "";
            canp.Text = "";
            g.Text = "";
            c.Text = "";
            origen.Text = "";
            t.Text = "";
            MessageBox.Show("Se ha cancelado la eliminacion de datos");
            groupBox2.Enabled = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
