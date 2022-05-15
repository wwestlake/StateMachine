using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    internal interface IContext
    {

        void SetState(IState newState);

        void Operation(IMessage message);

    }
}
