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
    public partial class venta : UserControl
    {
        double a;
        double s = 0;
        double i = 0;
        double p;
        double sum;
        public venta()
        {
            InitializeComponent();
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
           
                    
                    listBox1.Items.Add(lblNombre.Text);
                    listBox2.Items.Add(lblTalla.Text);
                    listBox3.Items.Add(lblprecio.Text);
                    a = int.Parse(lblprecio.Text);
                    venta1 objadd = new venta1();
                    objadd.suma(a, ref s);
                    Total.Enabled = true;
                     cproducto.Clear();
            lblNombre.Text = "";
            lblcolor.Text = "";
            lblTalla.Text="";
            lblprecio.Text="";
            Añadir.Enabled = false;

                
        }

        private void cproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                VerificarCodigoProducto ov = new VerificarCodigoProducto();
                if (ov.verificarp(cproducto.Text) == true)
                {
                    dataSet11.ReadXml("D:\\Arch_Ropa.xml");
                    System.Data.DataRow[] dato;
                    dato = dataSet11.tblProductos.Select("codigo_producto='" + cproducto.Text + "'");
                    if (dato.Length > 0)
                    {

                        lblNombre.Text = dato[0]["nombre_producto"].ToString();
                        lblprecio.Text = dato[0]["precio_unidad"].ToString();
                        lblTalla.Text = dato[0]["talla"].ToString();
                        lblcolor.Text = dato[0]["color"].ToString();
                        Añadir.Enabled = true;
                        Total.Visible = true;

                    }
                    else
                    {
                        Añadir.Enabled = false;
                        lblNombre.Text = "";
                        lblprecio.Text = "";
                        lblTalla.Text = "";
                        lblcolor.Text = "";
                        MessageBox.Show("El producto no existe en los regisntros");
                        cproducto.Clear();
                        Total.Visible = true;
                    }
                }
                else
                {

                    MessageBox.Show("Por favor ingrese un codigo valido");
                    cproducto.Clear();
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox2.Text);
                
                if (n < 16 && n > 9)
                {
                    i = double.Parse(textBox2.Text);
                    p = i / 100;
                    IVA objad = new IVA();
                    sum = objad.resul(s, p);
                    lblTotal.Text = sum.ToString();
                }
                else
                {
                    MessageBox.Show("El rango del iva desde 10 hasta 15");
                    textBox2.Clear();
                }
            }
            catch
            {
                MessageBox.Show("No se aceptan letras, espacios en blanco o numeros decimales en el IVA");
                textBox2.Clear();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
