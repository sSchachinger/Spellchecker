using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellchecker
{
    internal class Filehandling
    {
        private string path;
        public Filehandling(string path)
        {
            this.path = path;
        }
        public libLinkedList.ILinkedList<string> readFile()
        {
            StreamReader sr = new StreamReader(path);
            string line;
            libLinkedList.ILinkedList<string> linkedList = new libLinkedList.LinkedList<string>();

            while ((line = sr.ReadLine()) != null)
            {
                linkedList.Add(line);
            }
            sr.Close();
            return linkedList;
        }

    }
}
