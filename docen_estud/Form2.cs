using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//codigo realizado por JD

namespace docen_estud
{
    public partial class Form2 : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
          //boton salir
            Application.Exit(); 
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            //boton volver al formulario 1         
            Form1 Form1 = new Form1();
            Form1.Show();
            //oculta el formulario actual
            this.Hide();
        }

        private void btnMos_Click(object sender, EventArgs e)
        {
            //boton ver
            var estudiante = new Estudiante();
            //muestra el contenido de cada caja en 4 textos
            string nombre = this.txtNom.Text;//recolecta
            this.lblNombre.Text = "Nombre: "+" " + nombre.ToString();//muestra
            string edad = this.txtEd.Text;
            this.lblEdad.Text = "Edad: " + " " + edad.ToString();
            string carrera = this.txtCarre.Text;
            this.lblCarrera.Text = "Carrera: " + " " + carrera.ToString();
            string curso = this.txtCur.Text;
            this.lblCurso.Text = "Curso: " + " " + curso.ToString();
        }
    }
}