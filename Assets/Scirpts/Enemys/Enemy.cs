using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public bool canMeleeAttack;
    public bool canShoot;
    public float meleeDamage;
    public float shootDamage;

    public void pistolHit(int damage)
    {
        Debug.Log("Otrzymalem obrazenia " + damage);
    }    
}