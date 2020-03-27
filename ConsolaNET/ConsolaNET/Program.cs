using System;

namespace ConsolaNET
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desafio
            string[] matriz_id = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            foreach (string id in matriz_id)
            {
                if (id.StartsWith("B"))
                {
                    Console.WriteLine(id);
                }
            }

            /**
             * Test
             * 
             * 1. ¿Cómo se accede al tercer elemento de una matriz?
             * myArray[2]
             * 
             * 2. ¿Cuál de las siguientes respuestas es la forma correcta de crear una nueva matriz de números enteros con tres elementos?
             * int[] myArray = new int[3];
             * 
             * 3. ¿Cuál de las siguientes instrucciones foreach es la correcta?
             * foreach (int value in values)
             * 
             */
        }
    }
}
