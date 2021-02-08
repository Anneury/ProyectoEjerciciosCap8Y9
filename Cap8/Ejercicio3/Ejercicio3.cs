using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoEjerciciosCap8Y9.Cap8.Ejercicio3
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void TiempoFecha_Tick(object sender, EventArgs e)
        {
            HoraLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            FechaLabel.Text = DateTime.Now.ToString("yyyy / ddd / MMM");
        }
    }
}
