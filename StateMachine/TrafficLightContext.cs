using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    internal class TrafficLightContext : IContext
    {
        IState currentState;

        public void Operation(IMessage message)
        {
            currentState.Operation(this, message);
        }

        public void SetState(IState newState)
        {
            if (currentState == null)
            {
                currentState = newState;
            }
            else
            {
                Console.Write($"Transition from {currentState.Description} ");
                currentState = newState;
                Console.WriteLine($"to: {currentState.Description}");
            }
        }



    }
}
