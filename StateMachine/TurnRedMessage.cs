using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    internal class TurnRedMessage : IMessage
    {
        public string Message => "Change traffic light to red";
    }
}
