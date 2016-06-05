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
    public partial class Form1 : Form
    {
        int cantidadProcesos;
        int cantidadRecursos;
        int[] disponibles;
        int[] trabajo;
        int[] existencias;
        int[,] asignados;
        int[,] maximos;
        int[,] necesidades;
        bool[] finalizados;
        DialogoSecuencias DialogoSec;
        public Form1()
        {
            InitializeComponent();

        }
        private void limpiarmatrices()
        {
            Asignados.Rows.Clear();
            Asignados.Columns.Clear();
            Maximos.Rows.Clear();
            Maximos.Columns.Clear();
            Necesidades.Rows.Clear();
            Necesidades.Columns.Clear();
            Disponibles.Rows.Clear();
        }
        private void cargarmatrices()
        {
            string[] fila = new string[cantidadRecursos];
            for (int x = 0; x < cantidadRecursos; x++)
            {
                Asignados.Columns.Add("R" + (x + 1) + "A", "R" + (x + 1));
                Maximos.Columns.Add("R" + (x + 1) + "A", "R" + (x + 1));
                Necesidades.Columns.Add("R" + (x + 1) + "A", "R" + (x + 1));
                Disponibles.Rows.Add("R" + (x + 1), "0");
                fila[x] = "0";
            }
            for (int x = 0; x < cantidadProcesos; x++)
            {
                Asignados.Rows.Add(fila);
                Asignados.Rows[x].HeaderCell.Value = "P" + (x + 1);
                Maximos.Rows.Add(fila);
                Maximos.Rows[x].HeaderCell.Value = "P" + (x + 1);
                Necesidades.Rows.Add(fila);
                Necesidades.Rows[x].HeaderCell.Value = "P" + (x + 1);
            }
        }
        private void Inicializar()
        {
            disponibles = new int[cantidadRecursos];
            finalizados = new bool[cantidadProcesos];
            trabajo = new int[cantidadRecursos];
            existencias = new int[cantidadRecursos];
            asignados = new int[cantidadProcesos, cantidadRecursos];
            maximos = new int[cantidadProcesos, cantidadRecursos];
            necesidades = new int[cantidadProcesos, cantidadRecursos];
        }
        //Crea la estructura de matrices a partir de la cantidad de procesos y recursos
        private void Instantanea_Click(object sender, EventArgs e)
        { 
            limpiarmatrices();
            bool error = false;
            try
            {
                cantidadProcesos = Int32.Parse(TCantidadP.Text);
                if (cantidadProcesos <= 0)
                {
                    MessageBox.Show("Debe ingresar un valor mayor que 0 en la cantidad de procesos");
                    error = true;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar un numero en la cantidad de procesos");
                error = true;
            }
            try
            {
                cantidadRecursos = Int32.Parse(TCantidadR.Text);
                if (cantidadRecursos <= 0)
                {
                    MessageBox.Show("Debe ingresar un valor mayor que 0 en la cantidad de recursos");
                    error = true;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar un numero en la cantidad de recursos");
                error = true;
            }
            if (!error)
            {
                cargarmatrices();
            }
        }
        private void cargarnecesidades(int fila,int columna,int valor)
        {
            Necesidades.Rows[fila].Cells[columna].Value = valor;
        }
        private bool comprobacion()
        {
            try
            {
                for (int x = 0; x < cantidadRecursos; x++)
                {
                    disponibles[x] =Int32.Parse(Disponibles.Rows[x].Cells[1].Value.ToString());
                    for (int y = 0; y < cantidadProcesos; y++)
                    {
                        maximos[y, x] = Int32.Parse(Maximos.Rows[y].Cells[x].Value.ToString());
                        asignados[y, x] = Int32.Parse(Asignados.Rows[y].Cells[x].Value.ToString());
                        necesidades[y, x] = maximos[y, x] - asignados[y, x];
                        cargarnecesidades(y,x, necesidades[y, x]);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numericos en las celdas");
                return false;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No deben existir valores nulos en las matrices!");
                return false;
            }
            return true;
        }
        //Devuelve los indices de la matriz de necesidades que sean menores o iguales que el vector disponible
        private int[] necesmenorquedeman(int[] trabajo, bool[] finalizados)
        {
            List<int> indicval = new List<int>();
            bool correcto;
            for (int x = 0;x<cantidadProcesos;x++)
            {
                correcto = true;
                for (int y=0;y<cantidadRecursos;y++)
                {
                    if (necesidades[x,y]> trabajo[y])
                    {
                        correcto = false;
                    }
                }
                if (correcto && !finalizados[x])
                {
                    indicval.Add(x);
                }
            }
            if (indicval.Count!=0)
            {
                return indicval.ToArray();
            }else
            {
                indicval.Add(-1);
                return indicval.ToArray();
            }
            
        }
        private bool ejecutandobanquero(int[] trabajo, bool[]finalizados,int[] cadenasegura,int nivel)
        {
            //Comprobara si se terminaron todos los procesos en la secuencia actual
            bool finalizado = true;
            for (int x=0;x<cantidadProcesos;x++)
            {
                if (!finalizados[x])
                {
                    finalizado = false;
                }
            }
            if (finalizado)
            {
                //Paso 4
                //Imprime la cadena segura
                string cadenaseg = "";
                for (int x=0;x<cantidadProcesos;x++)
                {
                    cadenaseg += cadenasegura[x];
                }
                DialogoSec.Secuenciasseguras.Items.Add(cadenaseg);
                return true;
            }
            else
            {
                int[] necesidadesval = necesmenorquedeman(trabajo,finalizados);
                if (necesidadesval[0] != -1)
                {
                    string validas = "";
                    for (int x = 0; x < necesidadesval.Count(); x++)
                    {
                        validas+= (necesidadesval[x] + 1).ToString();
                        if (x!=(necesidadesval.Length-1))
                        {
                            validas += ", ";
                        }
                    }
                    //MessageBox.Show("Las necesidades validas son "+validas+" El nivel es "+nivel);
                    bool respuesta=false;
                    for (int x = 0; x < necesidadesval.Count(); x++)
                    {
                        //MessageBox.Show("La actual es "+ (necesidadesval[x] + 1) + " El nivel es " + nivel);
                        finalizados[necesidadesval[x]] = true;
                        cadenasegura[nivel] = (necesidadesval[x] + 1);
                        respuesta = ejecutandobanquero(sumarasigatrab(trabajo, necesidadesval[x]), finalizados, cadenasegura,nivel+1);
                        finalizados[necesidadesval[x]] = false;
                    }
                    return respuesta;
                }
                else
                {
                    return false;
                }
            }
            
        }
        private int[] sumarasigatrab(int[] trabajo,int proceso)
        {
            //Paso 3
            for (int y = 0; y < cantidadRecursos; y++)
            {
                trabajo[y] += asignados[proceso, y];
            }
            return trabajo;
        }
        private void banquero()
        {
            DialogoSec = new DialogoSecuencias();
            //Primero genera todas las posibles secuencias de estados seguros
            trabajo = disponibles;
            for (int x=0;x<cantidadProcesos;x++)
            {
                finalizados[x] = false;
            }
            //Paso 2
            int[] necesidadesval = necesmenorquedeman(trabajo,finalizados);
            if (necesidadesval[0] != -1)
            {
                bool respuesta = false;
                string validas = "";
                for (int x = 0; x < necesidadesval.Count(); x++)
                {
                    validas += (necesidadesval[x]+1).ToString();
                    if (x != (necesidadesval.Length - 1))
                    {
                        validas += ", ";
                    }
                }
                //MessageBox.Show("Las necesidades validas son " + validas);
                //Analiza todos los indices validos para generar todas las secuencias de estados seguras
                for (int x = 0; x < necesidadesval.Length; x++)
                {
                    //MessageBox.Show("La actual es " + (necesidadesval[x] + 1));
                    int[] cadenasegura=new int[cantidadProcesos];
                    finalizados[necesidadesval[x]] = true;
                    cadenasegura[0] = (necesidadesval[x]+1);
                    respuesta = ejecutandobanquero(sumarasigatrab(trabajo, necesidadesval[x]), finalizados, cadenasegura,1);
                    finalizados[necesidadesval[x]] = false;
                    trabajo = disponibles;
                }
                if (respuesta)
                {
                    TEstado.Text = "Estado = Seguro";
                    TEstado.ForeColor = Color.Black;
                    TEstado.BackColor = Color.Lime;
                    //Selecciona por defecto el primero
                    Secuenciassegurass.Visible = true; DialogoSec.Secuenciasseguras.SelectedIndex = 0;
                } else
                {
                    TEstado.Text = "Estado = Inseguro";
                    TEstado.ForeColor = Color.White;
                    TEstado.BackColor = Color.Red;
                    Secuenciassegurass.Visible = false;
                }
            }
            else
            {
                TEstado.Text = "Estado = Inseguro";
                TEstado.ForeColor = Color.White;
                TEstado.BackColor = Color.Red;
                Secuenciassegurass.Visible = false;
            }
        }
        private void Estadoseguro_Click(object sender, EventArgs e)
        {
            Inicializar();
            if (comprobacion())
            {
                banquero();
            }
        }

        private void Ejercicio1_Click(object sender, EventArgs e)
        {
            limpiarmatrices();
            int[] filaasignados = new int[4];
            int[] filamaximos = new int[4];
            string[] filanecesidades = new string[4];
            cantidadRecursos = 4;
            cantidadProcesos = 5;
            TCantidadP.Text = "5";
            TCantidadR.Text = "4";
            cargarmatrices();
            Disponibles.Rows[0].Cells[1].Value = "2";
            Disponibles.Rows[1].Cells[1].Value = "1";
            Disponibles.Rows[2].Cells[1].Value = "0";
            Disponibles.Rows[3].Cells[1].Value = "0";
            filaasignados[0] = 0;
            filaasignados[1] = 0;
            filaasignados[2] = 1;
            filaasignados[3] = 1;
            filamaximos[0] = 0;
            filamaximos[1] = 0;
            filamaximos[2] = 1;
            filamaximos[3] = 2;
            for (int x=0;x<4;x++)
            {
                Asignados.Rows[0].Cells[x].Value = filaasignados[x].ToString();
                Maximos.Rows[0].Cells[x].Value = filamaximos[x].ToString();
                cargarnecesidades(0,x,filamaximos[x]-filaasignados[x]);
            }
            filaasignados[0] = 2;
            filaasignados[1] = 0;
            filaasignados[2] = 0;
            filaasignados[3] = 0;
            filamaximos[0] = 2;
            filamaximos[1] = 7;
            filamaximos[2] = 5;
            filamaximos[3] = 0;
            for (int x = 0; x < 4; x++)
            {
                Asignados.Rows[1].Cells[x].Value = filaasignados[x].ToString();
                Maximos.Rows[1].Cells[x].Value = filamaximos[x].ToString();
                cargarnecesidades(1, x, filamaximos[x] - filaasignados[x]);
            }
            filaasignados[0] = 0;
            filaasignados[1] = 0;
            filaasignados[2] = 3;
            filaasignados[3] = 4;
            filamaximos[0] = 6;
            filamaximos[1] = 6;
            filamaximos[2] = 5;
            filamaximos[3] = 6;
            for (int x = 0; x < 4; x++)
            {
                Asignados.Rows[2].Cells[x].Value = filaasignados[x].ToString();
                Maximos.Rows[2].Cells[x].Value = filamaximos[x].ToString();
                cargarnecesidades(2, x, filamaximos[x] - filaasignados[x]);
            }
            filaasignados[0] = 2;
            filaasignados[1] = 3;
            filaasignados[2] = 5;
            filaasignados[3] = 6;
            filamaximos[0] = 4;
            filamaximos[1] = 3;
            filamaximos[2] = 5;
            filamaximos[3] = 6;
            for (int x = 0; x < 4; x++)
            {
                Asignados.Rows[3].Cells[x].Value = filaasignados[x].ToString();
                Maximos.Rows[3].Cells[x].Value = filamaximos[x].ToString();
                cargarnecesidades(3, x, filamaximos[x] - filaasignados[x]);
            }
            filaasignados[0] = 0;
            filaasignados[1] = 3;
            filaasignados[2] = 3;
            filaasignados[3] = 1;
            filamaximos[0] = 0;
            filamaximos[1] = 6;
            filamaximos[2] = 5;
            filamaximos[3] = 2;
            for (int x = 0; x < 4; x++)
            {
                Asignados.Rows[4].Cells[x].Value = filaasignados[x].ToString();
                Maximos.Rows[4].Cells[x].Value = filamaximos[x].ToString();
                cargarnecesidades(4, x, filamaximos[x] - filaasignados[x]);
            }
        }

        private void Secuenciassegurass_Click(object sender, EventArgs e)
        {
            DialogoSec.Show();
        }
    }
}
