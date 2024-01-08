using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;


//dziedziczy po skrypcie Enemy
public class SkullMonster : Enemy
{
    public void pistolHit(int damage)
    {
        health = health - damage;
    }

    public void Death()
    {
        
    }
    
}
