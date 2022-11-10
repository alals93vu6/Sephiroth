﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : IState
{

    public void OnEnterState(object action)
    {
        Debug.Log("IsMove");
        var actor = (PlayerActor) action;
    }

    public void OnStayState(object action)
    {
        var actor = (PlayerActor) action;
        
        actor.PlayerMove();
        
        if (Mathf.Abs(actor.H) <= 0.39f)
        {
            actor.rig.velocity = Vector2.zero;
            actor.changeState(new IdleState());
        }
    }

    public void OnExitState(object action)
    {
        var actor = (PlayerActor) action;
        
    }
}
