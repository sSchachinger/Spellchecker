using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Spellchecker
{
    internal class Controller
    {
        public Controller()
        {
            Console.WriteLine("Spellchecker");
        }
        public void Main()
        {
            string path = "C:\\Users\\Simon&Tanja\\source\\repos\\Spellchecker\\Spellchecker\\german.dic";
            UI ui = new UI();
            ui.SetTitle();
            Datahandling dh = new Datahandling();
            German gd = new German();

            Filehandling fh = new Filehandling(path);

            bool runVar = true;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            gd.dictLL = fh.readFileLL();
            stopwatch.Stop();
            Console.WriteLine("Einlesegeschwindigkeit Linkedlist:" + stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();

            stopwatch.Start();
            gd.dictHT = fh.readFileHT();
            stopwatch.Stop();
            Console.WriteLine("Einlesegeschwindigkeit Hashtable:" + stopwatch.ElapsedMilliseconds);

            while (runVar)
            {
                bool[] CorrectedValues = dh.CheckDictionaryLL(ui.GetInput(), gd.dictLL);
                CorrectedValues = dh.CheckDictionaryHT(ui.GetInput(), gd.dictHT);
                ui.SetOutput(CorrectedValues);
                runVar = ui.SetExit();
            }

        }
    }
}
