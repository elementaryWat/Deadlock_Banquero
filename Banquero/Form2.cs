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
        public DialogoSecuencias()
        {
            InitializeComponent();
        }

        private void Secuenciasseguras_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("El item seleccionado es " + Secuenciasseguras.SelectedItem.ToString());
        }
    }
}
