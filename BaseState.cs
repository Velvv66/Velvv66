using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseState
{
    //The kinds of state machines here are deterministic - when in one state and there is an input we know what transition will occur and where we will be in the active state
    //and stochastic - when the state machine can be random, we get different result after each chain of events
    
    //Here are going to be the 3 main parts of state machines: enter,update and exit point which in player movememnt words
    //is Movement starts>Player performs action> Stops. So I will follow unity's way of coding those updates

    public string name;

    protected StateMAchine stateMachine; //protected is used for saving data and makes us see the data in the UI

    public BaseState(string name, StateMAchine stateMachine)
    {
        this.name = name;
        this.stateMachine = stateMachine;
    }
    //with virtual void we are declaring that the method exists but the impletmentation will be in children classes
    public virtual void Enter() {}
    public virtual void UpdateLogic() {}
    public virtual void UpdatePhysics() {}
    public virtual void Exit() {}
}
