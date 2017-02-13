using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.States
{
    class WayState : IState
    {
        private readonly Installator _installator;

        public WayState(Installator installator)
        {
            _installator = installator;
        }

        public void Next()
        {
            Console.WriteLine("Installatation has started! TY !!!");
            _installator.SetState(_installator.Install);
        }

        public void Prev()
        {
            Console.WriteLine("Now agree with license");
            _installator.SetState(_installator.License);
        }

        public void Close()
        {
            Console.WriteLine("You are at the beginning of the installation");
            _installator.SetState(_installator.Hello);
        }

        public void Finish()
        {
            Console.WriteLine("You can finish install only after setup");
        }

    }
}
