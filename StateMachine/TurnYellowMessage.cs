﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    internal class TurnYellowMessage : IMessage
    {
        public string Message => "Turn light yellow";
    }
}
