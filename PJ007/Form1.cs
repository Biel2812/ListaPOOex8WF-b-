using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ007
{
    public partial class frmValores : Form
    {
        public frmValores()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            Valorxy v;
            v = new Valorxy();
            v.setXnumero(int.Parse(txtValorx.Text));
            v.setYnumero(int.Parse(txtValory.Text));
            v.calcularValores();

            lblResultado.Text = v.calcularValores();
        }
    }
}
