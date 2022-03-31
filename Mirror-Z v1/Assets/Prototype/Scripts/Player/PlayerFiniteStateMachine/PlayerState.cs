using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    // Player 
    protected Player player;
    // State Machine
    protected PlayerStateMachine stateMachine;
    // Player Data
    protected ScriptableObject playerClassData;

    protected float startTime;

    private string animBoolName;

    public PlayerState(Player player, PlayerStateMachine stateMachine, ScriptableObject playerClassData, string animBoolName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.playerClassData = playerClassData;
        this.animBoolName = animBoolName;
    }

    public virtual void Enter()
    {
        DoChecks();
        player.Anim.SetBool(animBoolName, true);
        startTime = Time.time;
    }
    public virtual void Exit()
    {
        player.Anim.SetBool(animBoolName, true);
    }
    public virtual void LogicUpdate()
    {

    }
    public virtual void PhysicsUpdate()
    {
        DoChecks();
    }
    public virtual void DoChecks()
    {

    }
}
