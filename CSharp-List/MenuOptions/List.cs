using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_List.Homeworks;

namespace CSharp_List.MenuOptions
{
    public class List : Option
    {
        HomeworkList homework = new HomeworkList();

        public List(string name = "List", string description = "Homework - about lists")
        {
            this.Name = name;
            this.Description = description;
        }

        public override void start()
        {
            Console.Clear();
            Console.WriteLine($"Iniciando o homework {this.Name}...\n");
            homework.Start();
        }

    }
}
