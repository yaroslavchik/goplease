using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Game
{
    class Fishing : BasicGame
    {
        public Fishing()
        {
            Description = "The greate simulator about fishing";
        }

        public override double GetSize()
        {
            return 110;
        }

    }
}
