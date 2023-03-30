using System;
using System.Threading;

namespace LeagueOfLegends
{
    public class UIOperation
    {
        public static string CreateMenu(string[] menus)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;

            string menu = "\t ☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺\n \n";

            for (int i = 0; i < menus.Length; i++)
            {
                menu += $"\t {i + 1}-) {menus[i]}  ";
            }
            menu += "\n\n \t ☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺";

            return menu;
        }
        public static string Wait(string text)
        {
            Console.Write("\t");

            string typedText = "";

            for (int i = 0; i < text.Length; i++)
            {
                Thread.Sleep(30);

                Console.Write(text[i]);
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }

            }

            return typedText;
        }
    }
}