using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.States
{
    class LicenseState : IState
    {
        private readonly Installator _installator;

        public LicenseState(Installator installator)
        {
            _installator = installator;
        }

        public void Next()
        {
            Console.WriteLine("Now choose install direct");
            _installator.SetState(_installator.Way);
        }

        public void Prev()
        {
            Console.WriteLine("Hello, it's start of install");
            _installator.SetState(_installator.Hello);
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
