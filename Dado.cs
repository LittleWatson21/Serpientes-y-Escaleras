using System;

namespace Juego_Serpientes_y_Escaleras
{
    class Dado
    {
        private const int CARA_MINIMA = 1;
        private const int CARA_MAXIMA = 6;
        private static Random gen = new Random();
        public static int tirar()
        {
            return gen.Next(CARA_MINIMA, CARA_MAXIMA+1);
        }
    }
}
