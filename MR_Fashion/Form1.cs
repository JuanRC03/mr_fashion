using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MR_Fashion
{
    public partial class Form1 : Form
    {
        int cont = 0;
        public Form1()
        {
            
            
            InitializeComponent();
            try
            {
                dataSet1.Clear();
                dataSet1.ReadXml("D:\\Arch_Ropa.xml");
                dataSet1.ReadXml("D:\\Arch_Cliente.xml");
                dataSet1.Clear();
            }
            catch
            {
                dataSet1.WriteXml("D:\\Arch_Ropa.xml");
                dataSet1.WriteXml("D:\\Arch_Cliente.xml");
            }

        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            
            pnli.Visible = true;
            pnlv.Visible = false;
            pnlp.Visible = false;
            pnlc.Visible = false;
            pnlr.Visible = false;
            pnlprductos.Visible = false;
            pnlclientes.Visible = false;
            sRopa1.Visible = false;
            pantallainicio1.Visible = true;
            venta1.Visible = false;
            vcDeudor1.Visible = false;

        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            pnli.Visible = false;
            pnlv.Visible = true;
            pnlp.Visible = false;
            pnlc.Visible = false;
            pnlr.Visible = false;
            pnlprductos.Visible = false;
            pnlclientes.Visible = false;
            venta1.Visible = true;
            pantallainicio1.Visible = false;
            sRopa1.Visible = true;
           
            vcDeudor1.Visible = false;




        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            pnli.Visible = false;
            pnlv.Visible = false;
            pnlp.Visible = true;
            pnlc.Visible = false;
            pnlr.Visible = false;
            pnlclientes.Visible = false;
            if (pnlprductos.Visible == true)
            {
                pnlprductos.Visible = false;
            }
            else
            {
                pnlprductos.Visible = true;
            }
            pnlreporte.Visible = false;

        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            pnli.Visible = false;
            pnlv.Visible = false;
            pnlp.Visible = false;
            pnlc.Visible = true;
            pnlr.Visible = false;
            pnlprductos.Visible = false;
            if (pnlclientes.Visible == true)
            {
                pnlclientes.Visible = false;
            }
            else
            {
                pnlclientes.Visible = true;
            }
            pnlreporte.Visible = false;

        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            if (pnlreporte.Visible == true)
            {
                pnlreporte.Visible = false;
            }
            else
            {
                pnlreporte.Visible = true;
            }
            pnli.Visible = false;
            pnlv.Visible = false;
            pnlp.Visible = false;
            pnlc.Visible = false;
            pnlr.Visible = true;
            pnlclientes.Visible = false;
            pnlprductos.Visible = false;

        }
        private void iconButton8_Click(object sender, EventArgs e)
        {
            ACliente oa = new ACliente();
            oa.ShowDialog();
            /*pantallainicio1.Visible = false;
            ingresoProductos1.Visible = false;
            eliminarproducto1.Visible = false;
            verproductos1.Visible = false;
            modificarproducto1.Visible = false;

            guardarCliente1.Visible = true;
            buscardatoscliente1.Visible = false;
            buscareliminarcliente1.Visible = false;
            buscarmodificar1.Visible = false;*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            ARopa or = new ARopa();
            or.ShowDialog();
            /*oA.ShowDialog();
            pantallainicio1.Visible = false;
            ingresoProductos1.Visible = true;
            eliminarproducto1.Visible = false;
            verproductos1.Visible = false;
            modificarproducto1.Visible = false;

            guardarCliente1.Visible = false;
            buscardatoscliente1.Visible = false;
            buscareliminarcliente1.Visible = false;
            buscarmodificar1.Visible = false;*/



        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ERopa or = new ERopa();
            or.ShowDialog();
            /*pantallainicio1.Visible = false;
            ingresoProductos1.Visible = false;
            eliminarproducto1.Visible = true;
            verproductos1.Visible = false;
            modificarproducto1.Visible = false;

            guardarCliente1.Visible = false;
            buscardatoscliente1.Visible = false;
            buscareliminarcliente1.Visible = false;
            buscarmodificar1.Visible = false;*/
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            MRopa or = new MRopa();
            or.ShowDialog();
            /*
            pantallainicio1.Visible = false;
            ingresoProductos1.Visible = false;
            eliminarproducto1.Visible = false;
            verproductos1.Visible = false;
            modificarproducto1.Visible = true;

            guardarCliente1.Visible = false;
            buscardatoscliente1.Visible = false;
            buscareliminarcliente1.Visible = false;
            buscarmodificar1.Visible = false;*/
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            BRopa or = new BRopa();
            or.ShowDialog();
            /*pantallainicio1.Visible = false;
            ingresoProductos1.Visible = false;
            eliminarproducto1.Visible = false;
            verproductos1.Visible = true;
            modificarproducto1.Visible = false;

            guardarCliente1.Visible = false;
            buscardatoscliente1.Visible = false;
            buscareliminarcliente1.Visible = false;
            buscarmodificar1.Visible = false;*/
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ECliente oe = new ECliente();
            oe.ShowDialog();
            /*pantallainicio1.Visible = false;
            ingresoProductos1.Visible = false;
            eliminarproducto1.Visible = false;
            verproductos1.Visible = false;
            modificarproducto1.Visible = false;

            guardarCliente1.Visible = false;
            buscardatoscliente1.Visible = false;
            buscareliminarcliente1.Visible = true;
            buscarmodificar1.Visible = false;*/
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            MCliente om = new MCliente();
            om.ShowDialog();
            /*pantallainicio1.Visible = false;
            ingresoProductos1.Visible = false;
            eliminarproducto1.Visible = false;
            verproductos1.Visible = false;
            modificarproducto1.Visible = false;

            guardarCliente1.Visible = false;
            buscardatoscliente1.Visible = false;
            buscareliminarcliente1.Visible = false;
            buscarmodificar1.Visible = true;*/
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            BCliente OB = new BCliente();
            OB.ShowDialog();
            /*pantallainicio1.Visible = false;
            ingresoProductos1.Visible = false;
            eliminarproducto1.Visible = false;
            verproductos1.Visible = false;
            modificarproducto1.Visible = false;

            guardarCliente1.Visible = false;
            buscardatoscliente1.Visible = true;
            buscareliminarcliente1.Visible = false;
            buscarmodificar1.Visible = false;*/
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void opciones_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                panel2.BackColor = Color.Gray;
                panel8.BackColor = Color.Gray;
                panel7.BackColor = Color.Gray;
                flowLayoutPanel2.BackColor = Color.Gray;
                cont = 1;
            }
            else
            {
                panel2.BackColor = Color.FromArgb(41, 39, 40);
                panel8.BackColor = Color.FromArgb(41, 39, 40);
                panel7.BackColor = Color.FromArgb(41, 39, 40);
                flowLayoutPanel2.BackColor = Color.FromArgb(41, 39, 40);
                cont = 0;
            }
            
        }

        private void iconButton17_Click(object sender, EventArgs e)
        {
            MasculinoFemenino1 om = new MasculinoFemenino1();
            om.ShowDialog();
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            MasculinoFemenino om = new MasculinoFemenino();
            om.ShowDialog();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            vcDeudor1.Visible = true;
            sRopa1.Visible = false;
            pantallainicio1.Visible = false;
            venta1.Visible = false;

        }

        private void iconButton13_Click(object sender, EventArgs e)
        {
            sRopa1.Visible = true;
            pantallainicio1.Visible = false;
            venta1.Visible = false;
            vcDeudor1.Visible = false;
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            reportropa objadd = new reportropa();
            objadd.ShowDialog();
        }

        private void iconButton15_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton15_Click_1(object sender, EventArgs e)
        {
            reportropa1 objadd1 = new reportropa1();
            objadd1.ShowDialog();
        }

        private void sRopa1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
