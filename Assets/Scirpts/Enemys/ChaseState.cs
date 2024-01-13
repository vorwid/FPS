using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : IEnemyAI
{
    EnemyStates enemy;
    public ChaseState (EnemyStates enemy)
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
