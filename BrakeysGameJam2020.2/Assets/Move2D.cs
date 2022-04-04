using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{
    public float moveSpeed;
    public bool isGrounded = false;
    float movementpre;
    public SpriteRenderer charecter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jump();
        movementpre = Input.GetAxis("Horizontal");
        if(movementpre < 0)
        {
            charecter.flipX = true;
        }
        else
        {
            charecter.flipX = false;

        }
        Vector3 movement = new Vector3(movementpre,0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }
    void jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);

        }
    }
}
