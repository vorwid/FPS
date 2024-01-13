using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PatrolState : IEnemyAI
{
    EnemyStates enemy;
    int nextWaypoint = 0;
    public PatrolState (EnemyStates enemy)
    {
        this.enemy = enemy;
    }
    public void UpdateAction()
    {
        Watch();
    }

    void Watch()
    {
        RaycastHit hit;
        if(Physics.Raycast(enemy.transform.position, -enemy.transform.forward, out hit, enemy.patrolRange))
        {

        } 
    }

    public void OnTriggerEnter(Collider enemy)
    {
        if(enemy.gameObject.CompareTag("Player"))
        {
            ToAlertState();
        }
    }

    public void ToPatrolState()
    {
        Debug.Log("I'm patrolling already");
    }
    public void ToAttackState()
    {
        enemy.currentState = enemy.attackState;
    }
    public void ToAlertState()
    {
        enemy.currentState = enemy.alertState;
    }
    public void ToChaseState()
    {
        enemy.currentState = enemy.chaseState;   
    }
}
