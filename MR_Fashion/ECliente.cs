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
    public partial class ECliente : Form
    {
        System.Data.DataRow[] dato;
        public ECliente()
        {
            InitializeComponent();
        }

        private void ECliente_Load(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            ValidarCedula oV = new ValidarCedula();
            if (oV.validar(txbcedula.Text) != true)
            {
                MessageBox.Show("Por favor ingrese un número de cedula correcto");
                txbcedula.Clear();
                lbln.Text = "";
                lbla.Text = "";
                lblc.Text = "";
                lblg.Text = "";
                lble.Text = "";
                lblf.Text = "";
                lblt.Text = "";
                lbld.Text = "";
            }
            else
            {
                dataSet11.ReadXml("D:\\Arch_Cliente.xml");
                
                dato = dataSet11.tblClientes.Select("cedula='" + txbcedula.Text + "'");
                if (dato.Length > 0)
                {

                    lbln.Text = dato[0]["nombre"].ToString();
                    lbla.Text = dato[0]["apellido"].ToString();
                    lblc.Text = dato[0]["cedula"].ToString();
                    lblg.Text = dato[0]["genero"].ToString();
                    lble.Text = dato[0]["estado_civil"].ToString();
                    lblf.Text = dato[0]["fecha_nacimiento"].ToString();
                    lblt.Text = dato[0]["telefono"].ToString();
                    lbld.Text = dato[0]["direccion"].ToString();
                    txbcedula.Clear();
                }
                else
                {
                    lbln.Text = "";
                    lbla.Text = "";
                    lblc.Text = "";
                    lblg.Text = "";
                    lble.Text = "";
                    lblf.Text = "";
                    lblt.Text = "";
                    lbld.Text = "";
                    MessageBox.Show("El cliente no existe en los regisntros");
                    txbcedula.Clear();
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            dato[0].Delete();
            dataSet11.tblClientes.WriteXml("D:\\Arch_Cliente.xml");
            lbln.Text = "";
            lbla.Text = "";
            lblc.Text = "";
            lblg.Text = "";
            lble.Text = "";
            lblf.Text = "";
            lblt.Text = "";
            lbld.Text = "";
            MessageBox.Show("Se ha eliminado correctamente");
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Se ha cancelado la eliminacion");
        }
    }
}
