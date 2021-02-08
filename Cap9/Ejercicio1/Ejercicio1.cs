using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoEjerciciosCap8Y9.Cap9.Ejercicio1
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            NombreTextBox.Clear();
            CantidadTextBox.Clear();
            PrecioTextBox.Clear();
        }

        public static void Tienda()
        {

        }

        public struct Producto
        {
            public float Precio;
            public string Nombre;
            public int Cantidad; 

            public Producto(float Precio, string Nombre, int Cantidad)
            {
                this.Precio = Precio;
                this.Nombre = Nombre;
                this.Cantidad = Cantidad;
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Producto Tienda;
            float Precio;
            int Cantidad;
            string Nombre;

            Precio = Convert.ToSingle(PrecioTextBox.Text);
            Nombre = NombreTextBox.Text;
            Cantidad = Convert.ToInt32(CantidadTextBox.Text);

            Tienda = new Producto(Precio, Nombre, Cantidad);
            Limpiar();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
