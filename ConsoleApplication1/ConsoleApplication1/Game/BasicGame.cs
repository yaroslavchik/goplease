using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Game
{
    public abstract class BasicGame
    {
        protected string Description = "";

        public string GetDescription()
        {
            return Description;
        }

        public abstract double GetSize();

    }

}
