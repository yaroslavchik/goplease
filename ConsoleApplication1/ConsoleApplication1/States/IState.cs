using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.States
{
    interface IState
    {
        void Next();
        void Prev();
        void Close();
        void Finish();
    }
}
