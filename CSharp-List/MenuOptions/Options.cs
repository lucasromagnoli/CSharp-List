using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_List;

namespace CSharp_List.MenuOptions
{
    public class Options : Option
    {
        public Options(string name = "Options", string description = "List all options.")
        {
            this.Name = name;
            this.Description = description;
            this.call = "options";
            this.key = ConsoleKey.D2;
        }
        public override void start(){
            new Menu().printOptions();
        }
    }
}
