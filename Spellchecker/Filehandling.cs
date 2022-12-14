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
        public libLinkedList.ILinkedList<string> readFileLL()
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
        public Hashtable.IlibHashtable<string,int> readFileHT()
        {
            StreamReader sr = new StreamReader(path);
            string line;
            Hashtable.IlibHashtable<string,int> hashtable = new Hashtable.libHashtable<string,int>();

            while ((line = sr.ReadLine()) != null)
            {
                hashtable.put(line, line.Length);
            }
            sr.Close();
            return hashtable;
        }



    }
}
