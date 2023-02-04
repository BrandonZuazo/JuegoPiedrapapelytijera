using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piedrapapelytijera2._0
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void butSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butJugar_Click(object sender, EventArgs e)
        {
            try
            {
            string nombre=textNombre.Text;
            Form1 ventana= new Form1(nombre);

            if(nombre=="")
                    MessageBox.Show("Por favor ingrese un nombre", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             
             else 
                    ventana.ShowDialog();
            

            }
            catch (FormatException)
            {

                MessageBox.Show("Por favor ingrese solo letras","Error de formato",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }
       
       
    }
}
