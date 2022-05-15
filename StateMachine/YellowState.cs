using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    internal class YellowState : IState
    {
        public IState NextState { get; set; }

        public string Description => "Yellow";

        public void Operation(IContext context, IMessage message)
        {
            if (message.GetType() != typeof(TurnRedMessage))
            {
                Console.WriteLine($"Invalid state message: {message.GetType().FullName}");
                return;
            }

            context.SetState(NextState);
        }
    }
}
