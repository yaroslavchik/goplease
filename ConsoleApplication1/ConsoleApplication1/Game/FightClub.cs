using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Game
{
    class FightClub : BasicGame
    {
        public FightClub()
        {
            Description = "Game about street fighting";
        }

        public override double GetSize()
        {
            return 150;
        }

    }
}
