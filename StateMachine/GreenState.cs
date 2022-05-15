using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    internal class GreenState : IState
    {
        public IState NextState { set; get; }


        public string Description => "Green";

        public void Operation(IContext context, IMessage message)
        {
            if (message.GetType() != typeof(TurnYellowMessage))
            {
                Console.WriteLine($"Invalid state message: {message.GetType().FullName}");
                return;
            }
            context.SetState(NextState);
        }
    }
}
