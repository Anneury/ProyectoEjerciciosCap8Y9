using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoEjerciciosCap8Y9.Cap9.Ejercicio4
{
    public partial class Ejercicio4 : Form
    {
        public int Acumulador { get; set; } = 0;
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Neumaticos neumaticos;
            neumaticos = Neumaticos.Diagonal+Acumulador;
            EnumLabel.Text = Convert.ToString(neumaticos);
            
            Acumulador++;
            
            if (Acumulador == 12)
                Acumulador = 0;
        }
        enum Neumaticos
        {
            Diagonal = 1, Radial, Verano, Invierno, AllSeason,
            Asimetrico, Direccionales, Tubuless,
            PerfilBajo, ReCauchutados, RunFlat, Ecologicos
        }
    }
}
