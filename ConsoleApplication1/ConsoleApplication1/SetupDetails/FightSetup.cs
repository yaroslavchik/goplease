using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.SetupDetails
{
    class FightSetup : GameSetup
    {
        public override void UnzipFiles()
        {
            Console.WriteLine("Unzipped fighters");
        }
    }
}
