using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.States;

namespace ConsoleApplication1
{
    class Installator
    {
        public HelloState Hello { get; private set; }
        public LicenseState License { get; private set; }
        public WayState Way { get; private set; }
        public InstallState Install { get; private set; }

        private IState _currentState;

        public Installator()
        {
            Hello = new HelloState(this);
            License = new LicenseState(this);
            Way = new WayState(this);
            Install = new InstallState(this);

            _currentState = Hello;
        }

        public void Next()
        {
            _currentState.Next();
        }

        public void Prev()
        {
            _currentState.Prev();
        }

        public void Close()
        {
            _currentState.Close();
        }

        public void Finish()
        {
            _currentState.Finish();
        }

        public void SetState(IState state)
        {
            _currentState = state;
        }
    }


}
