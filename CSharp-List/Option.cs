using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharp_List.Homeworks;
using System.Threading.Tasks;

namespace CSharp_List
{
    public abstract class Option
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public string call;
        public ConsoleKey key;

        public abstract void start();

        public override string ToString()
        {
            return $@"[{Name} ~ Shortcut: {key.ToString()}] - {Description}";
        }

    }
}
