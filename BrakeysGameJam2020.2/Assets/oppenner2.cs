using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oppenner2 : MonoBehaviour
{
    public GameObject door2;
    public GameObject text1;
    public GameObject text2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            text1.SetActive(false);
            text2.SetActive(true);
            door2.SetActive(false);
        }
    }
}
