using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharp_List.Homeworks;
using System.Threading.Tasks;
using CSharp_List.MenuOptions;

namespace CSharp_List
{
    public class Menu
    {
        IDictionary<String, Option> mainMenu = new Dictionary<String, Option>();

        public Menu()
        {
            mainMenu.Add("exit", new Exit());
            mainMenu.Add("options", new Options());
            mainMenu.Add("clear", new Clear());
            mainMenu.Add("list", new List());
            printOptions();
            start();
        }

        public void start()
        {
            string read;
            Option option;

                read = Console.ReadLine().ToLower();

                try
                {
                    option = mainMenu[read];
                    option.start();
                }

                catch (KeyNotFoundException)
                {
                    Console.WriteLine("Opção invalida");
                }

            this.start();
        }

        public void printOptions()
        {
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            string menu = "";

            foreach (Option option in mainMenu.Values)
            {
                menu += $"{option.ToString()}\n";
            }

            return menu;
        }

    }
}
