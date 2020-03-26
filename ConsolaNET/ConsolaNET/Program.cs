using System;

namespace ConsolaNET
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desafio
            string nombreProyecto = "ACME";

            string mensaje = "Ver salida español";
            string ruta = $@"C:\Ejemplo\{nombreProyecto}\es_ES\";

            string mensajeRuso = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            string rutaRuso = $@"C:\Ejemplo\{nombreProyecto}\ru_RU\";

            Console.WriteLine(mensaje + ": \n" + ruta + "\n\n");

            Console.WriteLine(mensajeRuso + ": \n" + rutaRuso);

            /**
             * Test
             * 
             * 1. ¿Cuál de las siguientes secuencias de escape usaría para agregar comillas dobles a una cadena literal?
             * \"
             * 
             * 2. ¿Cuál de las siguientes líneas de código usa correctamente la interpolación de cadenas, suponiendo que la variable value es una cadena?
             * Console.WriteLine($"My value: {value}");
             * 
             * 3. Ha insertado caracteres Unicode en las cadenas para presentar un mensaje especial en tailandés, pero el mensaje solo se muestra como signos de interrogación. ¿Qué ha ocurrido?
             * La consola del usuario no admite caracteres Unicode.
             * 
             */
        }
    }
}
