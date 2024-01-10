using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : IEnemyAI
{
    EnemyStates enemy;
    public PatrolState (EnemyStates enemy)
    {
        this.enemy = enemy;
    }
    public void UpdateAction()
    {

    }

    public void OnTriggerEnter(Collision enemy)
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
