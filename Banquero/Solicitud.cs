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
    public partial class Solicitud : Form
    {
        int proceso;
        int cantidadprocesos;
        int cantidadrecursos;
        int[] solicitud;
        Form1 Formprincipal;
        public Solicitud(int cantidadp,int cantidadr,Form1 Formp)
        {
            Formprincipal = Formp;
            cantidadprocesos = cantidadp;
            cantidadrecursos = cantidadr;
            solicitud = new int[cantidadrecursos];
            InitializeComponent();
            for (int x=0;x<cantidadprocesos;x++)
            {
                Listaprocesos.Items.Add("P"+(x+1));
            }
            for (int x=0;x<cantidadrecursos;x++)
            {
                string[] filaR = { "R"+(x+1),"0"};
                DetSol.Rows.Add(filaR);
            }
        }

        private void BSolic_Click(object sender, EventArgs e)
        {
            proceso = Listaprocesos.SelectedIndex;
            bool todosceros = true;
            if (proceso!=-1)
            {
                for (int x=0;x<cantidadrecursos;x++)
                {
                    solicitud[x] = Int32.Parse(DetSol.Rows[x].Cells[1].Value.ToString());
                    if (solicitud[x]!=0)
                    {
                        todosceros = false;
                    }
                }
                if (todosceros)
                {
                    MessageBox.Show("Todas las cantidades de la solicitud son iguales a 0!");
                }
                else
                {
                    Formprincipal.Solicitarrecursos(proceso, solicitud);
                    Dispose();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un proceso!");
            }
        }

        private void DetSol_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool error=false;
            if (e.RowIndex!=-1 && e.ColumnIndex!=-1)
            {
                try
                {
                    int valor = Int32.Parse(DetSol.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    if (valor<0)
                    {
                        MessageBox.Show("Debe ingresar un valor mayor que 0 en la cantidad de recursos");
                        error = true;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Debe ingresar un valor numerico en las cantidad de recursos");
                    error = true;
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Debe ingresar un valor no nulo en las cantidad de recursos");
                    error = true;
                }
                if (error)
                {
                    DetSol.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0";
                }
            }
        }
    }
}
