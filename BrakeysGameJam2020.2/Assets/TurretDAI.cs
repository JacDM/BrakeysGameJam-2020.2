using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretDAI : MonoBehaviour
{
    public int currHealth;
    public int maxalth;

    public float distance;
    public float WakeRange;
    public float shootInterval;
    public float bulletSpeed = 100;
    public float bulletTimer;

    public bool awake = false;
    public bool lookingRight = false;

    public GameObject bullet;
    public Transform target;
    public Transform shootPointLeft, shootPointRight,top;
    public Animator anim;
    public bool state = true;



    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void Start()
    {
        currHealth = maxalth;
    }
    private void Update()
    {
        anim.SetBool("Awake", awake);
        anim.SetBool("lookingRight", lookingRight);
        RangeCheck();
        if(target.transform.position.x > transform.position.x)
        {
            lookingRight = true;
        }
        else
        {
            lookingRight = false;
        }
    }
    
    void RangeCheck()
    {
        distance = Vector3.Distance(transform.position, target.transform.position);
        if(distance < WakeRange)
        {
            awake = true;
        }
        else { awake = false; }
    }
    public void Attack(bool attackingRight)
    {
        bulletTimer += Time.deltaTime;
        if(bulletTimer >= shootInterval)
        {
            Vector2 direction = target.transform.position - transform.position;
            direction.Normalize();

            if (!attackingRight)
            {
                GameObject bulletClone;
                bulletClone = Instantiate(bullet, shootPointLeft.transform.position, shootPointLeft.transform.rotation) as GameObject;
                bulletClone.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;

                bulletTimer = 0;
            }
            else
            {
                GameObject bulletClone;
                bulletClone = Instantiate(bullet, shootPointRight.transform.position, shootPointRight.transform.rotation) as GameObject;
                bulletClone.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;

                bulletTimer = 0;
                Debug.Log("nolol");
            }
        }

    }
   

}
