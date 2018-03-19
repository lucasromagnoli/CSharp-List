using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_List.Homeworks;

namespace CSharp_List
{
    public class HomeworkOption : Option
    {
        public HomeworkList homework;

        public override void start()
        {
            Console.Clear();
            Console.WriteLine($"Iniciando o homework {this.Name}...\n");
            homework.Start();
            Console.WriteLine($"\nFinalizando o homework {this.Name}...\n");
            new Menu().printOptions();
        }
    }
}
