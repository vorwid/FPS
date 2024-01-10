using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyAI 
{
    void UpdateAction();

    void OnTriggerEnter(Collision enemy);

    void ToPatrolState();
    void ToAttackState();
    void ToAlertState();
    void ToChaseState();
    
}
