﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropState : IState
{
    public void OnEnterState(object action)
    {
        Debug.Log("IsDrop");
    }

    public void OnStayState(object action)
    {
        var actor = (PlayerActor) action;
        actor.PlayerMove();
        actor.PlayerDownWhether();
    }

    public void OnExitState(object action)
    {
        
    }
}