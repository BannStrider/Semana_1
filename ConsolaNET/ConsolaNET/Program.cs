using System;

namespace ConsolaNET
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desafio
            Random random = new Random();
            int diasRestantes = random.Next(12);
            int porcentajeDescuento = 0;

            if (diasRestantes == 0)
            {
                Console.WriteLine("Tu suscripción ha caducado.");
            }
            else if (diasRestantes == 1)
            {
                Console.WriteLine("Tu suscripción caduca en horas.");
                porcentajeDescuento = 20;
            }
            else if (diasRestantes <= 5)
            {
                Console.WriteLine($"Tu suscripción caduca en {diasRestantes} días.");
                porcentajeDescuento = 10;
            }
            else if (diasRestantes <= 10)
            {
                Console.WriteLine("Tu suscripción caduca pronto. ¡Renuevala ahora!");
            }

            if (porcentajeDescuento > 0)
            {
                Console.WriteLine($"¡Renueva ahora y ahorra {porcentajeDescuento}%!");
            }

            /**
             * Test
             * 
             * 1. Si int x = 5;, ¿cuál de las siguientes expresiones booleana es válida y se evalúa como verdadera?
             * x == 5
             * 
             * 2. ¿Cuál de las siguientes opciones no es un operador válido?
             * %%
             * 
             * 3. ¿Cuál de las siguientes opciones sobre la instrucción if es falsa?
             * Puede agregar else antes de una instrucción else if.
             * 
             */
        }
    }
}
