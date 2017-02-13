using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.SetupDetails
{
    abstract class GameSetup
    {
        public void Prepare()
        {
            UnzipFiles();
            CreateBD();
            CreateLabel();

        }

        public abstract void UnzipFiles();

        public void CreateBD()
        {
            Console.WriteLine("Created BD");
        }

        public void CreateLabel()
        {
            Console.WriteLine("Created Label on the desktop");
        }

    }
}
