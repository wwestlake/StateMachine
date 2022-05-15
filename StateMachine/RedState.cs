using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    internal class RedState : IState
    {
        public IState NextState { get; set; }

        public string Description => "Red";

        public void Operation(IContext context, IMessage message)
        {
            if (message.GetType() != typeof(TurnGreenMessage))
            {
                Console.WriteLine($"Invalid state message: {message.GetType().FullName}");
                return;
            }

            context.SetState(NextState);
        }
    }
}
