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
    public partial class Form1 : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        //imagen como boton estudiante
        private void pictureBox1_Click(object sender, EventArgs e)
        {
   
            Form2 Form2 = new Form2();
            //muestra el formulario 2
            Form2.Show();
            //oculta el formulario actual
            this.Hide();
        }

        //imagen como boton Docente
        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
            Form3 Form3 = new Form3();
            //muestra el formulario 3
            Form3.Show();
            //oculta el formulario actual
            this.Hide();
        }

        private void metroShell1_HelpButtonClick(object sender, EventArgs e)
        {
            //boton Acerca de
            MessageBox.Show("programa realizado por Joel David Quisbert".ToString());
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //boton salir
            Application.Exit();
        }
    }
}