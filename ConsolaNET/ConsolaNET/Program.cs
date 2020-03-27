using System;
using System.Collections.Generic;

namespace ConsolaNET
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desafio
                //Declaramos variables
                var numeros_fibonacci = new List<int> {1,1};

                while (numeros_fibonacci.Count < 20){
                    var fila_anterior = numeros_fibonacci[numeros_fibonacci.Count - 1];
                    var fila_anterior_2 = numeros_fibonacci[numeros_fibonacci.Count - 2];

                    numeros_fibonacci.Add(fila_anterior + fila_anterior_2);
                }

                foreach (var item in numeros_fibonacci){
                    Console.WriteLine(item);
                }
        }
    }
}
