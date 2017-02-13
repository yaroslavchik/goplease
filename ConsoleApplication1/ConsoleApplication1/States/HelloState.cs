using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.States
{
    class HelloState : IState
    {
        private readonly Installator _installator;

        public HelloState(Installator installator)
        {
            _installator = installator;
        }

        public void Next()
        {
            Console.WriteLine("Now agree with license");
            _installator.SetState(_installator.License);
        }

        public void Prev()
        {
            Console.WriteLine("It's only the first step of setup");
        }

        public void Close()
        {
            Console.WriteLine("You are at the beginning of the installation");
        }

        public void Finish()
        {
            Console.WriteLine("You can finish install only after setup");
        }

    }
}
