using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_Serpientes_y_Escaleras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Jugador J1 = new Jugador(1);
        Jugador J2 = new Jugador(2);
        Tablero Tablero1 = new Tablero();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void moverJugadoras(Jugador jugador, Tablero tablero)
        { 
            int avance = jugador.Posicion + Dado.tirar();
            if (avance >= tablero.longitud() -1)
            {
                jugador.mover(100);
            }
            else if (tablero.es_Serpiente(avance) || (tablero.es_Escalera(avance)))
            {
                jugador.mover(tablero.obtenerValor(avance));
            }
            else
            {
                jugador.mover(avance);
            }
                
        }
        private void Iniciar_Juego_Click(object sender, EventArgs e)
        { 

            while (J1.Posicion < 100 || J2.Posicion < 100)
            {
                moverJugadoras(J1, Tablero1);
                mostrarJuego.Text += J1.ToString() + Environment.NewLine;
                moverJugadoras(J2, Tablero1);
                mostrarJuego.Text += J2.ToString() + Environment.NewLine;
            }
        }
        
    }
}
