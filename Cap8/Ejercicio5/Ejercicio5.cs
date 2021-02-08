using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoEjerciciosCap8Y9.Cap8.Ejercicio5
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            string menor, mayor;
            if (Cadena2TextBox.Text.CompareTo(Cadena1TextBox.Text) < 0)
            {
                menor = Cadena1TextBox.Text;
                mayor = Cadena2TextBox.Text;
            }
            else
            {
                mayor = Cadena1TextBox.Text;
                menor = Cadena2TextBox.Text;
            }
            CadenaList.Items.Add("1. " + mayor);
            CadenaList.Items.Add("2. " + menor);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            CadenaList.Items.Clear();
            Cadena2TextBox.Clear();
            Cadena1TextBox.Clear();
        }
    }
}
