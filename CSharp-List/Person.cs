using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_List
{


    public class Person
    {
        //Propriedades
        public String Name { get; set; }
        public ulong Cpf { get; set; }
        public DateTime DateOfBirth { get; set; }
        
        //Construtores
        public Person(String name, ulong cpf, DateTime dateOfBirth)
        {
            this.Name = name;
            this.Cpf = cpf;
            this.DateOfBirth = dateOfBirth;

        }

        // Métodos
        public int getAge()
        {
            // Calculamos o tempo que se passou da data de aniversário da pessoa, até o dia atual.
            TimeSpan timeSpan = (DateTime.Today - DateOfBirth);

            /* Quando o objeto do tipo DateTime é instanciado o mesmo possui os valores: 01/01/0001 00:00:00.
             * Para ter a idade correta da pessoa, acrescetamos (-1) nas propriedades Year e Days. */
            return ( (new DateTime() + timeSpan).AddYears(-1).AddDays(-1).Year );
        }

        public override string ToString()
        {
            return $"Nome: {Name} " +
                   $"| CPF: {Cpf} " +
                   $"| Data de nascimento: {DateOfBirth.ToShortDateString()} [{getAge()} anos]";
        }
    }
}
