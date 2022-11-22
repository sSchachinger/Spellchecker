using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellchecker
{
    internal class Datahandling
    {
        public bool[] CheckDictionaryLL(string[] strList, libLinkedList.ILinkedList<string> linkedList)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Reset();
            stopwatch.Start();

            bool[] result = new bool[strList.Length];
            for (int i = 0; i < strList.Length; i++)
            {
                if (linkedList.Contains(strList[i]))
                    result[i] = true;
                else
                    result[i] = false;
            }

            Console.WriteLine("Einlesegeschwindigkeit Linkedlist:" + stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
            return result;
        }
        public bool[] CheckDictionaryHT(string[] strList, Hashtable.IlibHashtable<string,int> hashtable)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Reset();
            stopwatch.Start();
            bool[] result = new bool[strList.Length];
            for (int i = 0; i < strList.Length; i++)
            {
                Tuple<string,int> tuple = new Tuple<string, int>(strList[i], strList[i].Length);

                if (hashtable.Contains(tuple))
                    result[i] = true;
                else
                    result[i] = false;
            }
            Console.WriteLine("Einlesegeschwindigkeit Linkedlist:" + stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
            return result;
        }
    }

}
