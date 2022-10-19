using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellchecker
{
    public class Dictionary
    {
        public libLinkedList.ILinkedList<string> dict { get; set; } 

        public Dictionary()
        {
            dict = new libLinkedList.LinkedList<string>();
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
