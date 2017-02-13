using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Game;

namespace ConsoleApplication1.GameAdditions
{
    class Russifier : AdditionsBase
    {
        private BasicGame _game;

        public Russifier(BasicGame game)
        {
            _game = game;
            Description = _game.GetDescription() + " +Russifier";
        }

        public override double GetSize()
        {
            return _game.GetSize() + 25;
        }
    }
}
