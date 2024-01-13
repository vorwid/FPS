using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertState : IEnemyAI
{
    EnemyStates enemy;
    public AlertState (EnemyStates enemy)
    {
        this.enemy = enemy;
    }
    public void UpdateAction()
    {

    }

    public void OnTriggerEnter(Collider enemy)
    {

    }

    public void ToPatrolState()
    {

    }
    public void ToAttackState()
    {

    }
    public void ToAlertState()
    {

    }
    public void ToChaseState()
    {

    }
}
