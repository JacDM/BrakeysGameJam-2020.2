using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCone : MonoBehaviour
{
    public TurretDAI turretAI;
    public bool isLeft = false;

    private void Awake()
    {
        turretAI = gameObject.GetComponentInParent<TurretDAI>();
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if(Health.ded != true || turretAI.state == true)
        {
            if (col.CompareTag("Player"))
            {
                if (turretAI.GetComponentInParent<TurretDAI>().lookingRight)
                {
                    turretAI.Attack(false);
                }
                else
                {
                    turretAI.Attack(true);
                }
            }
        }
        
    }
}
