using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    internal interface IState
    {
        IState NextState { set; }

        void Operation(IContext context, IMessage message);

        string Description { get; }
    }
}
