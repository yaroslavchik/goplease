using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.States
{
    class InstallState : IState
    {
        private readonly Installator _installator;

        public InstallState(Installator installator)
        {
            _installator = installator;
        }

        public void Next()
        {
            Console.WriteLine("Installation is already in process");
        }

        public void Prev()
        {
            Console.WriteLine("If you want to cancel installatation press 'Close'");
        }

        public void Close()
        {
            Console.WriteLine("You are at the beginning of the installation");
            _installator.SetState(_installator.Hello);
        }

        public void Finish()
        {
            Console.WriteLine("Thank you for using our product! Now you can install something else");
            _installator.SetState(_installator.Hello);
        }

    }
}
