using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto memoria = new Producto();
            memoria.Codigo = "9146";
            memoria.Descripcion = "Memoria Ram";
            memoria.PrecioUnitario = 199.99m;

            Producto discoDuro = new Producto()
            {
                Codigo = "003",
                Descripcion = "Disco Duro 1T",
                PrecioUnitario = 520.99m
            };

            Producto laptop = new Producto()
            {
                Codigo = "004",
                Descripcion = "Laptop Asus",
                PrecioUnitario = 10000.99m
            };

            List<Producto> productos = new List<Producto>();
            productos.Add(memoria);
            productos.Add(discoDuro);
            productos.Add(laptop);

            dgvProductos.DataSource = productos;
        }
    }
}
