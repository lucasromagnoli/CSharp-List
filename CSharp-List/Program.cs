using System;
using System.Collections.Generic;
using System.IO;
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
            Console.WriteLine($"User: {Environment.UserName}\n" +
                              $"Machine: {Environment.MachineName}\n" +
                              $"OS Version: {Environment.OSVersion}\n");
            /* Criamos a tabela de pessoas, onde recebe uma lista de objetos do tipo pessoa.
             * Removemos alguns itens pelo index e outro pelo objeto em si.
             */
            List<Person> people = new List<Person>
            {
                new Person("Lara Teixeira Ducati", 80485829967, Convert.ToDateTime("21/10/1954")),
                new Person("Pedro Ducati Gomes", 11774838150, Convert.ToDateTime("11/5/1992")),
                new Person("João Amaral Ducati", 56750065406, Convert.ToDateTime("13/9/1998")),
                new Person("Helena Ducati Machado", 33546757998, Convert.ToDateTime("4/7/1980"))
            };
            
            people.Add(new Person("Carlos Amaral Ducati", 76381744022, Convert.ToDateTime("18/11/1970")));
            people.Add(new Person("Laura Teixeira Amaral", 92022259238, Convert.ToDateTime("3/9/1976")));

            people.Insert(0, new Person("Matheus Machado Amaral", 34497055043, Convert.ToDateTime("1/6/1965")));
            people.RemoveAt(0);
            people.Insert(3, new Person("Lucas Gomes Amaral", 03450513435, Convert.ToDateTime("26/6/1969")));

            Person gabrielGomesDucati = new Person("Gabriel Gomes Ducati", 24377466097, Convert.ToDateTime("9/12/1973"));
            people.Add(gabrielGomesDucati);
            people.Remove(gabrielGomesDucati);

            // Variável para receber a pessoa mais velha.
            Person younger;
            // Variável para receber a pessoa mais nova.
            Person older;

            Console.WriteLine("Existe pelo menos uma pessoa com mais de 40 anos?: {0}", people.Exists(p => p.getAge() >= 40) ? "Sim" : "Não");
            Console.WriteLine("Existe pelo menos uma pessoa com menos de 18 anos?: {0}", people.Exists(p => p.getAge() < 18) ? "Sim" : "Não");
            Console.WriteLine("Existe pelo menos uma pessoa com o nome de Lara Teixeira Ducati: {0}", people.Exists(p => p.Name == "Lara Teixeira Ducati") ? "Sim" : "Não");

            Console.WriteLine("\nLista de pessoas não ordenadas:");
            people.ForEach(delegate (Person person)
            {
                Console.WriteLine(String.Format("{0} - {1} anos", person.Name, person.getAge()));
            });

            people.Reverse();
            Console.WriteLine("\nLista ao contrário:");
            people.ForEach(delegate (Person person)
            {
                Console.WriteLine(String.Format("{0} - {1} anos", person.Name, person.getAge()));
            });

            Console.WriteLine("\nLista ordenadas por nome:");
            people.Sort(delegate (Person person1, Person person2){
                return person1.Name.CompareTo(person2.Name);
            });
            people.ForEach(delegate (Person person)
            {
                Console.WriteLine(String.Format("{0} - {1} anos", person.Name, person.getAge()));
            });

            Console.WriteLine("\nLista ordenadas por idade (Crescente):");
            people.Sort(delegate (Person person1, Person person2) {
                return person1.getAge().CompareTo(person2.getAge());
            });
            people.ForEach(delegate (Person person)
            {
                Console.WriteLine(String.Format("{0} - {1} anos", person.Name, person.getAge()));
            });

            // Acrescentamos a pessoa mais jovem para a variavel older.
            older = people[0];

            Console.WriteLine("\nLista ordenadas por idade (Decrescente):");
            people.Sort(delegate (Person person1, Person person2) {
                return person1.getAge().CompareTo(person2.getAge());
            });
            people.Reverse();
            people.ForEach(delegate (Person person)
            {
                Console.WriteLine(String.Format("{0} - {1} anos", person.Name, person.getAge()));
            });

            // Acrescentamos a pessoa mais jovem para a variavel younger.
            younger = people[0];

            //Convertendo a lista para array.
            Person[] personArray = people.ToArray();


            // Imprimindo na tela a pessoa mais velha e a mais jovem.
            Console.WriteLine("\nMais velha: {0} - {1} anos", older.Name, older.getAge());
            Console.WriteLine("Mais jovem: {0} - {1} anos", younger.Name, younger.getAge());

            //Lista com todas as pessoas com ou menos de 30 anos.
            List<Person> youngPeople = people.FindAll(delegate (Person p) { return p.getAge() <= 30; });
            //Lista com todas as pessoas com mais de 30 anos.
            List<Person> olderPeople = people.FindAll(delegate (Person p) { return p.getAge() > 30; });

            //Imprimi na tela a lista das pessoas mais jovens.
            Console.WriteLine("\nLista de pessoas jovens:");
            youngPeople.ForEach(delegate (Person person)
            {
                Console.WriteLine(String.Format("{0} - {1} anos", person.Name, person.getAge()));
            });

            //Imprimi na tela a lista das pessoas mais velhas.
            Console.WriteLine("\nLista de pessoas velhas:");
            olderPeople.ForEach(delegate (Person person)
            {
                Console.WriteLine(String.Format("{0} - {1} anos", person.Name, person.getAge()));
            });


            //Diretorio a onde o programa está sendo executado.
            string path = $@"{Environment.CurrentDirectory}\log.txt";
            using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Lista de pessoas:");
                    people.ForEach(delegate (Person person)
                    {
                        sw.WriteLine(person);
                    });
                }
            
            Console.WriteLine("\nAperte qualquer tecla para o programa finalizar...");
            Console.ReadKey(); // Apertar qualquer tecla para o programa finalizar.
        }
    }
}
