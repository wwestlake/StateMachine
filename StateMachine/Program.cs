using StateMachine;

Console.WriteLine("Traffic Light");

IContext ctx = new TrafficLightContext();

IState red = new RedState();
IState yellow = new YellowState();
IState green = new GreenState();

red.NextState = green;
green.NextState = yellow;
yellow.NextState = red;

ctx.SetState(red);
IMessage greenMsg = new TurnGreenMessage();
IMessage redMsg = new TurnRedMessage();
IMessage yellowMsg = new TurnYellowMessage();



ctx.Operation(greenMsg);
ctx.Operation(yellowMsg);
ctx.Operation(redMsg);
ctx.Operation(greenMsg);
ctx.Operation(yellowMsg);
ctx.Operation(redMsg);




