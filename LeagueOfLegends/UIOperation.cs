using System;
using System.Collections.Generic;
using System.Threading;

namespace LeagueOfLegends
{
    public class UIOperation
    {
        public static string Wait(string text)
        {
            Console.Write("\t");

            string typedText = "";

            for (int i = 0; i < text.Length; i++)
            {
                Thread.Sleep(50);

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
        public static string CharacterList(String[] characterName)
        {
            string cizgi = "\n \t╔════════════════════════════════════════════════════════╗\n \n";
            int caharacterIndex = 0;
            foreach (var name in characterName)
            {
                caharacterIndex++;
                cizgi += $" \t {caharacterIndex}.KARAKTER \n \t\t \t KARAKTER ADI : {name}\n \t\t \t";
                cizgi += "\n\n \t╚════════════════════════════════════════════════════════╝\n";
            }

            return cizgi;
        }
    }
}