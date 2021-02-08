using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoEjerciciosCap8Y9.Cap8.Ejercicio3;
using ProyectoEjerciciosCap8Y9.Cap8.Ejercicio5;
using ProyectoEjerciciosCap8Y9.Cap9.Ejercicio1;
using ProyectoEjerciciosCap8Y9.Cap9.Ejercicio3;
using ProyectoEjerciciosCap8Y9.Cap9.Ejercicio4;

namespace ProyectoEjerciciosCap8Y9
{
    public partial class rEjercicios : Form
    {
        public rEjercicios()
        {
            InitializeComponent();
        }

        private void Ejercicio3Button_Click(object sender, EventArgs e)
        {
            Ejercicio3 obj = new Ejercicio3();

            obj.Show();
        }

        private void Ejercicio5Button_Click(object sender, EventArgs e)
        {
            Ejercicio5 obj = new Ejercicio5();

            obj.Show();
        }

        private void Ejercicio1Button_Click(object sender, EventArgs e)
        {
            Ejercicio1 obj = new Ejercicio1();

            obj.Show();
        }

        private void Ejercicio3Cap9Button_Click(object sender, EventArgs e)
        {
            Ejercicio3Cap9 obj = new Ejercicio3Cap9();
            obj.Show();
        }

        private void Ejercicio4Button_Click(object sender, EventArgs e)
        {
            Ejercicio4 obj = new Ejercicio4();

            obj.Show();
        }
    }
}
