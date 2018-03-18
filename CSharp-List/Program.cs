using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_List.Homeworks;

/* Exemplos em C#
 *
 * Como criar uma lista, ordenar a mesma e verificar se determinado item da lista possui certo atributo ou não.
 * 
 */

namespace CSharp_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"User: {Environment.UserName}\n" +
                              $"Machine: {Environment.MachineName}\n" +
                              $"OS Version: {Environment.OSVersion}\n");
            /* Criamos a tabela de pessoas, onde recebe uma lista de objetos do tipo pessoa.
             * Removemos alguns itens pelo index e outro pelo objeto em si.
             */

            Menu menu = new Menu();
            
            Console.WriteLine("\nAperte qualquer tecla para o programa finalizar...");
            Console.ReadKey(); // Apertar qualquer tecla para o programa finalizar.
        }
    }
}
