using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_List.MenuOptions
{
    public class Exit : Option
    {
        public Exit(string name = "Exit", string description = "Exit from the aplication.")
        {
            this.Name = name;
            this.Description = description;
        }

        public override void start()
        {
            Environment.Exit(0);
        }

    }
}
