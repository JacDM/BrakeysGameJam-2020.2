using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Damage = 0.1f;

    // Update is called once per frame
    void Update()
    {
        Object.Destroy(gameObject, 2.0f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Health.health -= 5f;
            Debug.Log(Health.health);
        }
    }

    
}
