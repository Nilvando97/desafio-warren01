using System;

namespace DesafioWarren01
{
    class Program
    {
        public static int inverter(int n)
        {

            int resultado = 0;

            while (n > 0)
            {
                resultado = 10 * resultado + n % 10;
                n /= 10;
            }
            return resultado;
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000000; i++)
            {
                if((i + inverter(i)) % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
