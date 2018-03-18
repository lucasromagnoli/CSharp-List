using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            List<Person> people = new List<Person>
            {
                new Person("Lara Teixeira Ducati", 80485829967, Convert.ToDateTime("21/10/1954")),
                new Person("Pedro Ducati Gomes", 11774838150, Convert.ToDateTime("11/5/1968")),
                new Person("João Amaral Ducati", 56750065406, Convert.ToDateTime("13/9/1988")),
                new Person("Helena Ducati Machado", 33546757998, Convert.ToDateTime("4/7/1980"))
            };

            people.ForEach(delegate (Person p)
            {
                Console.WriteLine(p);
            });

            Console.WriteLine("\nAperte qualquer tecla para o programa finalizar...");
            Console.ReadKey(); // Apertar qualquer tecla para o programa finalizar.
        }
    }
}
