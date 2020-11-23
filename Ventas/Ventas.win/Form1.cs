using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.BL;

namespace Ventas.win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var productosBL = new productosBL();
            var listadeProductos = productosBL.ObtenerProductos();

            foreach (var productos in listadeProductos)
            {
                MessageBox.Show(productos.Descripcion);
            }
        }
    }
}
