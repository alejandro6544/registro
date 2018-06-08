using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace registro
{
    public partial class Form1 : Form
    {

        LinkedList<Modelo.Estudiante> listaE;
        public Form1()
        {
            InitializeComponent();
            listaE = new LinkedList<Modelo.Estudiante>();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            String id = textBox5.Text;
            String nombre1 = textBox1.Text;
            String nombre2 = textBox2.Text;
            String apellido1 = textBox3.Text;
            String apellido2 = textBox4.Text;
            String codigo = textBox6.Text;
            String carrera = textBox7.Text;

            Modelo.Estudiante objE = new Modelo.Estudiante(id, nombre1, nombre2, apellido1, apellido2, codigo, carrera);
            listaE.AddLast(objE);

            limpiar();
        }

        private void limpiar()
        {
            textBox5.Text = "Identificación";
            textBox1.Text = "Nombre1 Estudiante";
            textBox2.Text = "Nombre2 Estudiante";
            textBox3.Text = "Apellido1 Estudiante";
            textBox4.Text = "Apellido2 Estudiante";
            textBox6.Text = "Código";
            textBox7.Text = "Carrera";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region Recorrer la lista
            //String mm = "";
            //foreach (var value in listaE)
            //{
            //    mm += value.toString() + "\n";
            //}

            //MessageBox.Show(mm); 
            #endregion

            Modelo.DBConnect objD = new Modelo.DBConnect();
           bool f= objD.insertEstudiante(listaE);
            if (f)
            {
                MessageBox.Show("Se inserto correctamente");
            }
            else
            {
                MessageBox.Show("Error al insertar!!!!");
            }

        }
    }
}
