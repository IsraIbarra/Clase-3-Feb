using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Bilioteca para el manerjo de archivos

namespace Clase_3_Feb
{
    public partial class Bloc : Form
    {
        private string file = null;
        public Bloc()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Escribiendo";
        }

        //GUARDAR COMO
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog(); //Abrir cuadro de dailogo ppara seleccioanr una ruta
            //Especficar el tipo de archivo que vamos a guardar
            sfd.Filter = "Docuentos de Text |*.txt";
            sfd.AddExtension = true;
            DialogResult res = sfd.ShowDialog();//Veridica DIALOGResut para devolder una validacion   //Muestra el cuado de dialgooo


            //Para que no truene por no sleccionar una direccion agregamos una validacion para comporbar que Dialog result es Ok
            if (res == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, textBox1.Text);
                file = sfd.FileName;
            }
            ///Guardar archivo en sfd.FileName que da la direccion seleccionada por el cuadro
            //de dialogo, siendo uno la direccion de guardar y lo otro que es lo que se va a escribir

            toolStripStatusLabel1.Text = "Guardado";
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog(); //Abrir cuadro de dailogo ppara seleccioanr una ruta
            //Especficar el tipo de archivo que vamos a guardar
            sfd.Filter = "Docuentos de Text |*.txt";
            sfd.AddExtension = true;
            DialogResult res = sfd.ShowDialog();//Veridica DIALOGResut para devolder una validacion   //Muestra el cuado de dialgooo


            //Para que no truene por no sleccionar una direccion agregamos una validacion para comporbar que Dialog result es Ok
            if (res == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(sfd.FileName);
                file = sfd.FileName;
            }
            //Abrir un archivo y ponerle al cuadro de texto la información de un texto
            //de dialogo, siendo uno la direccion de guarda y lo otro que es lo que se va a escribir

            toolStripStatusLabel1.Text = "Archivo Abierto";
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(file!= null)
                File.WriteAllText(file, textBox1.Text);
            
            else
           guardarToolStripMenuItem_Click(sender, e);


            toolStripStatusLabel1.Text = "Guardado";

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Escribiendo";
        }
    }
}
//Agrggar pestañas para multiples documentos y que cada pestaña sea un documento diferente y sea independiente

//Rich TextBox para poner emojisy ejemplo si escribimos :) que lo convierta en una carita feliz
//Todo se guarda como texto simple pero al mostrarlo en el RichTextBox se ve como emoji o imagen
