using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA;
using TMPro;

public class Rewinder : MonoBehaviour
{
    public static bool isRewinding = false;

    List<Vector2> position;
    public int tries = 0;
    public GameObject remote;
    public TextMeshProUGUI triesUI;
    public Rigidbody2D rb;
    public GameObject key;

    // Start is called before the first frame update
    void Start()
    {
        position = new List<Vector2>();
        position.Insert(0, transform.position);
        remote.gameObject.SetActive(false);

    }
    private void FixedUpdate()
    {
        if (isRewinding==true)
        {
            Rewind();
            
        }
        else
        {
            Record();
        }
    }

    void Update()
    {
        triesUI.text = "Tries: " + tries;
        Debug.Log("upd " + Health.ded);
       if(Input.GetKeyDown(KeyCode.R))
       {
            Rewind();
       }
       else if(Health.ded == true)
       {
            Debug.Log("pls");
            Rewind();
       }
       
    }
    public void Rewind()
    {
        isRewinding = true;
        // rb.isKinematic = true;
        if (position.Count > 0)
        {
            transform.position = position[0];
            position.RemoveAt(0);
            remote.gameObject.SetActive(true);

        }
        else
        {
            position.Insert(0, transform.position);
            isRewinding = false;
            Health.ded = false;
            tries = tries + 1;
            remote.gameObject.SetActive(false);
            key.gameObject.SetActive(true);


        }
    }
    public void Record()
    {
        Vector2 prev = transform.position;
        if (prev != position[0])
        {
            position.Insert(0, transform.position);
        }
    }
}
