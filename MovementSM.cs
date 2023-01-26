using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSM : StateMAchine
{
    [HideInInspector]
    //this is hidden so they show in the inspector
    public Idle idleState;
    [HideInInspector]
    public Moving movingState;
    [HideInInspector]
    public Jumping jumpingState;

    public Rigidbody2D rigidbody;
    public SpriteRenderer spriteRenderer;
    //the state machine is aware of the states we are in but also we want the other systems to be aware of it.
    //so I'm gonna change the sprite color to indicate the state change

    public float speed = 4f; //defining the speed variable
    public float jumpForce = 10f;

    private void Awake()
    {
        idleState = new Idle(this);
        movingState = new Moving(this);
        jumpingState = new Jumping(this); // initializing the state by passing the state machine
    }

    protected override BaseState GetInitialState()
    {
        return idleState;
    }
}
