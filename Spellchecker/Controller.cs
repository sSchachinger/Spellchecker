using System;
using System.Collections.Generic;
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
            gd.dict = fh.readFile();

            while (runVar)
            {
                bool[] CorrectedValues = dh.CheckDictionary(ui.GetInput(), gd.dict);
                ui.SetOutput(CorrectedValues);
                runVar = ui.SetExit();
            }
        
        }
    }
}
