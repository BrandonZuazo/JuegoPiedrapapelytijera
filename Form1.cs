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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void groupUsuario_Enter(object sender, EventArgs e)
        {
         
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
        public Form1( string nombre)
        {
            InitializeComponent();

           labPlayerwin.Text = nombre+" Ganador";
            labPlayer.Text = nombre.ToUpper();
            groupUsuario.Text = nombre.ToUpper();
            labPcwin.Visible = false;
            labPlayerwin.Visible = false;
            labEmpate.Visible = false;
        }
        private char eleccionPc()
        {
            char[] option = new char[] { 'P','A','T'};
            Random random = new Random();
            int randomindex = random.Next(0, option.Length);
            return option[randomindex];

        }
        private void Turnopc()
        {
            switch (eleccionPc())
            {
                case ('P'):
                    butRocaPC.FlatAppearance.BorderColor = Color.Red;
                    break;
                case ('A'):
                    butPapelPC.FlatAppearance.BorderColor = Color.Red;
                    break;
                case ('T'):
                    butTijeraPC.FlatAppearance.BorderColor = Color.Red;
                    break;
            }
        }
        private void limpiareleccion()
        {
            butRocaPC.FlatAppearance.BorderColor = Color.Black;
            butPapelPC.FlatAppearance.BorderColor = Color.Black;
            butTijeraPC.FlatAppearance.BorderColor = Color.Black;
        }

        private void butPiedraPlay_Click(object sender, EventArgs e)
        {
            char Piedra = 'P';
            Botoneleccion(Piedra);

        }
        private void butPapel_Click(object sender, EventArgs e)
        {
            char Piedra = 'A';
            Botoneleccion(Piedra);
        }

        private void butTijera_Click(object sender, EventArgs e)
        {
            char Piedra = 'T';
            Botoneleccion(Piedra);
        }
        
        private void contador(char player)
        {
            int contadorpc = 0;
            int contadorPlayer =0;


            char PC = eleccionPc();

            if (player == eleccionPc())
            {
            contadorpc++;
            contadorPlayer++;

            }
            switch (player)
            {
                case ('P'):
                    if (PC=='A')
                    {
                        contadorpc++;
                    }else if (PC == 'T')
                    {
                        contadorPlayer++;
                    }
                    break;
                    case('A'):
                    if (PC == 'T')
                    {
                        contadorpc++;
                    }
                    else if (PC == 'P')
                    {
                        contadorPlayer++;
                    }
                    break;
                    case('T'):
                    if (PC == 'P')
                    {
                        contadorpc++;
                    }
                    else if (PC == 'A')
                    {
                        contadorPlayer++;
                    }
                    break;
            }
            if (contadorPlayer == contadorpc)
            {
                labEmpate.Visible = true;

            }
            else if(contadorPlayer >= contadorpc) { 
            
                labPlayerwin.Visible = true;
            }else if (contadorPlayer <= contadorpc)
            {
                labPcwin.Visible = true;
            }
                 
            
        }
        private void limpiadorwin()
        {
            labPcwin.Visible = false;
            labPlayerwin.Visible = false;
            labEmpate.Visible = false;
        }
        private void Botoneleccion(char eleccion)
        {
            limpiadorwin();
            limpiareleccion();
            Turnopc();
            contador(eleccion);
        }

    }

}
    
    
