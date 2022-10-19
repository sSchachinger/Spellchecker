using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellchecker
{
    internal class Datahandling
    {
        public bool[] CheckDictionary(string[] strList, libLinkedList.ILinkedList<string> linkedList)
        {
            bool[] result = new bool[strList.Length];
            for (int i = 0; i < strList.Length; i++)
            {
                if (linkedList.Contains(strList[i]))
                    result[i] = true;
                else
                    result[i] = false;
            }
            return result;
        }
    }

}
