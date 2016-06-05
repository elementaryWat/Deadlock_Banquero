using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banquero
{
    public partial class DialogoSecuencias : Form
    {
        Form1 Formprincipal;
        public DialogoSecuencias(Form1 form)
        {
            InitializeComponent();
            Formprincipal = form;

        }

        private void Secuenciasseguras_DoubleClick(object sender, EventArgs e)
        {
            Formprincipal.indice = Secuenciasseguras.SelectedIndex;
            Formprincipal.Ejecutarsecuencia();
        }
    }
}
