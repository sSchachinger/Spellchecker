using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Spellchecker
{
    internal class UI
    {

        private string[] _input;

        private List<(int, int, char)> specialCharStorage;
        private char[] specialChar;
        public UI()
        {
            specialCharStorage = new List<(int, int, char)>();
            specialChar = new char[] { '@', '|', '!', '#', '$', '%', '&', '/', '(', ')', '=', '?', '»', '«', '@', '£', '§', '€', '{', '}', '.', '-', ';', '<', '>', '_', ',' };
        }
        public void SetTitle()
        {
            Console.Title = "Spellchecker";
        }
        public string[] GetInput()
        {
            Console.WriteLine("Bitte einen Satz eingeben:");
            _input = Console.ReadLine().Split(' ');
            for (int i = 0; i < _input.Length; i++)
            {
                for (int j = 0; j < specialChar.Length; j++)
                {
                    if (_input[i].Contains(specialChar[j]))
                    {
                        specialCharStorage.Add((i, _input[i].IndexOf(specialChar[j]), specialChar[j]));
                        _input[i] = _input[i].Replace(specialChar[j], ' ');
                        _input[i] = _input[i].Trim();
                    }
                }
            }
            return _input;
        }

        public bool SetOutput(bool[] CorrectedValues)
        {

            for (int i = 0; i < CorrectedValues.Length; i++)
            {
                foreach (var item in specialCharStorage)
                {
                    if (i == item.Item1)
                        _input[i] = _input[i].Insert(item.Item2, item.Item3.ToString());
                }
                if (i == 0)
                {
                            // Anfangsbuchstabe soll groß sein!!
                      
                }

                if (CorrectedValues[i])
                    Console.Write(_input[i]);
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(_input[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write(" ");
            }
            return true;
        }

        public bool SetExit()
        {
            Console.WriteLine("\nWant to exit? (Y/N)");
            string inp = Console.ReadLine();
            if (inp == "Y")
                return false;
            else if (inp == "N")
                return true;
            else
            {
                Console.WriteLine("Falsche Taste");
                return false;
            }

        }

    }
}
