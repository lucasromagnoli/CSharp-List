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
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        IDictionary<String, Option> mainMenu = new Dictionary<String, Option>();
        IDictionary<ConsoleKey, Option> keyMenu = new Dictionary<ConsoleKey, Option>();
        Option[] options = new Option[] { new Clear(), new Options(), new Exit(), new List()};

        public Menu()
        {
            for(int contador = 0; contador < options.Length; contador++)
            {
                Option op = options[contador];

                mainMenu.Add(op.call, op);
                keyMenu.Add(op.key, op);
            }

            printOptions("Escolha uma das opções abaixo.\nPara selecionar basta escrever a opção ou pressionar a tecla de atalho.");
            start();
        }

        public void start()
        {
            string read;
            Option option;
   
            ConsoleKeyInfo keyOption;

            keyOption = Console.ReadKey();

            try
            {
                option = keyMenu[keyOption.Key];
                ClearCurrentConsoleLine();
                option.start();
            }
            catch (KeyNotFoundException)
            {
                ClearCurrentConsoleLine();
                if (Char.IsLetter(keyOption.KeyChar))
                {
                    Console.Write(keyOption.KeyChar);
                    read = keyOption.KeyChar + Console.ReadLine().Trim().ToLower();
                } else
                {
                    read = Console.ReadLine().Trim().ToLower();
                }
                
                try
                {
                    option = mainMenu[read];
                    option.start();
                }

                catch (KeyNotFoundException)
                {
                    Console.WriteLine("Opção invalida");
                }
            }

            this.start();
        }

        public void printOptions(string text = "Escolha uma das opções abaixo:")
        {
            Console.WriteLine($"{text}\n{this}");
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
