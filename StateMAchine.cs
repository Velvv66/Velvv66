using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMAchine : MonoBehaviour
{
    //This class is used to mkae sure that we have states which we can transition through and not what kind of states they are aka Idle, Moving etc
    BaseState currentState; //current state valuable

    void Start()
    {
        currentState = GetInitialState();
        if (currentState != null) //entering the state
            currentState.Enter();
    }

  
    void Update()
    {
        if (currentState != null)
            currentState.UpdateLogic();

    }

    void LateUpdate()
    {
        if (currentState != null)
            currentState.UpdatePhysics();

    }

    public void ChangeState(BaseState newState)
    {
        currentState.Exit(); //finishing the current state
        currentState = newState; //assigning state
        currentState.Enter();
    }

    internal object ChangeState(MovementSM stateMachine)
    {
        throw new NotImplementedException();
    }

    protected virtual BaseState GetInitialState()
    {
        return null;

    }
    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10f, 10f, 200f, 100f));
        string content = currentState != null ? currentState.name : "(no current state)";
        GUILayout.Label($"<color='black'><size=40>{content}</size></color>"); //UI and using tags in unity for how it'll be displayed
        GUILayout.EndArea();
    }
}
