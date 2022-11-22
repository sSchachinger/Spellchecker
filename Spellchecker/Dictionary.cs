using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellchecker
{
    public class Dictionary
    {
        public libLinkedList.ILinkedList<string> dictLL { get; set; }
        public Hashtable.IlibHashtable<string, int> dictHT { get; set; }

        public Dictionary()
        {
            dictLL = new libLinkedList.LinkedList<string>();
            dictHT = new Hashtable.libHashtable<string, int>();
        }
    }
    public class German : Dictionary
    {
        public German() : base()
        {

        }

    }
    public class English : Dictionary
    {
        public English() : base()
        {

        }
    }
}
