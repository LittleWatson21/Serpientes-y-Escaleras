namespace Juego_Serpientes_y_Escaleras
{
    class Tablero
    {
        protected int [] _casillas;
        const int SERPIENTE = 1;
        const int ESCALERA = 2;


        public Tablero ()
        {
            _casillas = new int[101];
            for(int i=1; i<_casillas.Length; i++)
            {
                _casillas[i] = i;
            }
            establecer_Serpientes();
            establecer_Escaleras();
            
        }

        public void establecer_Serpientes()
        {
            
            _casillas[25] = 10;
            _casillas[37] = 22;
            _casillas[60] = 57;
            _casillas[75] = 6;
            _casillas[99] = 9;
            _casillas[14] = 2;
            _casillas[55] = 20;
            _casillas[83] = 65;
        }

        public void establecer_Escaleras()
        {
            _casillas[5]  = 18;
            _casillas[13] = 23;
            _casillas[27] = 32;
            _casillas[38] = 63;
            _casillas[47] = 59;
            _casillas[58] = 70;
            _casillas[64] = 91;
            _casillas[77] = 82;
        }

        public bool es_Serpiente(int _posicion)
        {
            return _casillas[_posicion] < _posicion;

        }

        public bool es_Escalera(int _posicion)
        {
            return _casillas[_posicion] > _posicion;
        }

        public int longitud()
        {
            return _casillas.Length;
        }

        public int obtenerValor(int indice)
        {
            return _casillas[indice];
        }
    }
}
