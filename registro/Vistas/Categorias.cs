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
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String categoria = textBox1.Text;

            Modelo.DBConnect objd = new Modelo.DBConnect();
            Modelo.Categoria objc = new Modelo.Categoria(categoria);

            bool f= objd.insertCategoria(objc);

            if (f)
            {
                MessageBox.Show("Se inserto Correctamente ");
            }
            else
            {
                MessageBox.Show("No se inserto Correctamente ");
            }

        }
    }
}
