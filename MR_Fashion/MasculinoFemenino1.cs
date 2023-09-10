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
    public partial class MasculinoFemenino1 : Form
    {
        public MasculinoFemenino1()
        {
            InitializeComponent();
            DataSet1.ReadXml("D:\\Arch_Ropa.xml");
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MasculinoFemenino1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
