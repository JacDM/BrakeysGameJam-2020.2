using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oppen : MonoBehaviour
{
    public GameObject text;
    public GameObject door1;
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            text.SetActive(true);
            door1.SetActive(false);
        }
    }
}
