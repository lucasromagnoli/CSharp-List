using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_List.Homeworks;

namespace CSharp_List.MenuOptions
{
    public class List : HomeworkOption
    {

        public List(string name = "List", string description = "Homework - about lists")
        {
            this.Name = name;
            this.Description = description;
            this.homework = new HomeworkList();
            this.call = "list";
            this.key = ConsoleKey.D4;
        }

    }
}
