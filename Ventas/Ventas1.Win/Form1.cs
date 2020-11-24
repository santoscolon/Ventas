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

namespace Ventas1.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var productoBL = new productosBL();
            var listadeProductos = productoBL.ObtenerProductos();

            listadeProductosBindingSource.DataSource = listadeProductos;
        }
    }
}
