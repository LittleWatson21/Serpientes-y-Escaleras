using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Serpientes_y_Escaleras
{
    class Jugador
    {
        private int _numeroJugador;
        private int _Posicion;
        public Jugador (int numeroJugador)
        {
            //Asignamos el número del jugador
            _numeroJugador = numeroJugador;
            _Posicion = 0;
        }

        public int numeroJugador
        {
            get { return _numeroJugador; }
        }

        public int Posicion
        {
            get { return _Posicion; }
        }

        public void mover(int casillas_avance)
        {
            _Posicion = casillas_avance;
        }


        public override string ToString()
        {
            return "Jugador" + "[" + numeroJugador + "] en la posición: " + Posicion;
        }
    }
}
