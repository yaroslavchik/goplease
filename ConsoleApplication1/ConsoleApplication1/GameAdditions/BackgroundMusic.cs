using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Game;

namespace ConsoleApplication1.GameAdditions
{
    class BackgroundMusic : AdditionsBase
    {
        private BasicGame _game;

        public BackgroundMusic(BasicGame game)
        {
            _game = game;
            Description = _game.GetDescription() + " +Background Music";
        }

        public override double GetSize()
        {
            return _game.GetSize() + 35;
        }
    }
}
