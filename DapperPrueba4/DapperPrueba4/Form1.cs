using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperPrueba4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductoRepository productoR = new ProductoRepository();

        #region Metodos
        private Productos CrearNuevo()
        {
            var Producto = new Productos{ 
                Id = Int32.Parse(tbxID.Text),
                Nombre = tbxNombre.Text,
                Descripcion = tbxDescripcion.Text,
                Precio = Decimal.Parse(tbxPrecio.Text),
                Stock = Int32.Parse(tbxStock.Text),
                Marca = tbxMarca.Text,
                Categoria = tbxCategoria.Text,
            };
            return Producto;
        }

        private void RellenarForm(Productos producto)
        {
            tbxID.Text = producto.Id.ToString();
            tbxNombre.Text = producto.Nombre;
            tbxDescripcion.Text = producto.Descripcion;
            tbxPrecio.Text = producto.Precio.ToString();
            tbxStock.Text = producto.Stock.ToString();
            tbxMarca.Text = producto.Marca;
            tbxCategoria.Text = producto.Categoria;
        }
        #endregion

        private void btnCargarTodos_Click(object sender, EventArgs e)
        {
            var Producto = productoR.ObtenerTodos();
            dgvProductos.DataSource = Producto;
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            var Producto = productoR.ObtenerPorId(Int32.Parse(tbxBuscarID.Text));
            dgvProductos.DataSource = new List<Productos> { Producto };
            if (Producto != null)
            {
                RellenarForm(Producto);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var Producto = CrearNuevo();
            var NewProd = productoR.InsertarProducto(Producto);
            MessageBox.Show($"{NewProd} filas modificadas");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var Producto = CrearNuevo();
            var UpProduct = productoR.ActualizarProducto(Producto);
            MessageBox.Show($"{UpProduct} filas modificadas");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var DeleteProduct = productoR.EliminarProducto(Int32.Parse(tbxID.Text));
            MessageBox.Show($"{DeleteProduct} filas modificadas");
        }
    }
}
