using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerStateMachine StateMachine { get; private set; }

    public Animator Anim { get; private set; }

    private void Awake()
    {
        StateMachine = new PlayerStateMachine();


    }

    private void Start()
    {
        Anim = GetComponent<Animator>();
        // Initialize the player statemachine
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        StateMachine.CurrentState.PhysicsUpdate();
    }
}
