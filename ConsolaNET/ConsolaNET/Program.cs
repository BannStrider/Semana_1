using System;

namespace ConsolaNET
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desafio
                //Declaramos variables
                int contador = 0;
                string mensaje_original = "El rápido zorro marrón salta por encima del perro perezoso";
                string mensaje_reverso;
                char[] mensaje_cadena = mensaje_original.ToCharArray();

                //Hacemos que el mensaje nuevo se le haga un reverso
                Array.Reverse(mensaje_cadena);
                mensaje_reverso = new String(mensaje_cadena);

                //Contamos las veces que aparece la letra
                foreach (char letra in mensaje_cadena)
                {
                    if (letra == 'o')
                    {
                        contador++;
                    }
                }

                Console.WriteLine("Mensaje original: " + mensaje_original);
                Console.WriteLine("Mensaje reverso: " + mensaje_reverso);
                Console.WriteLine($"La letra 'o' aparece {contador} veces.");

            /**
             * Test
             * 
             * 1. ¿Cuál de los siguientes nombres de variable es un buen nombre de variable?
             * initialMessage
             * 
             * 2. ¿Cuál de las siguientes es una mala razón para usar un comentario de código?
             * Quiere explicar cómo funciona una nueva palabra clave de C#.
             * 
             * 3. ¿Cuál de las siguientes afirmaciones sobre los espacios en blanco es verdadera?
             * Debe agregar espacios en blanco prudentemente para mejorar la legibilidad del código.
             * 
             */
        }
    }
}
