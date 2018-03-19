using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_List.MenuOptions
{
    public class Clear : Option
    {
        public Clear(string name = "Clear", string description = "Clear all commands.")
        {
            this.Name = name;
            this.Description = description;
            this.call = "clear";
            this.key = ConsoleKey.D1;
        }

        public override void start()
        {
            Console.Clear();
            new Menu().printOptions();
        }
    }
}
