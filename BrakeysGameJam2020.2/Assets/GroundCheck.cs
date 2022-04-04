using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<Move2D>().isGrounded = true;
        }
        if(collision.gameObject.layer == 9)
        {
            Debug.Log("lol");
            collision.gameObject.GetComponentInParent<TurretDAI>().enabled = false;
        }
        if(collision.gameObject.tag == "Respawn")
        {
            Health.ded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<Move2D>().isGrounded = false;
        }
    }
}
