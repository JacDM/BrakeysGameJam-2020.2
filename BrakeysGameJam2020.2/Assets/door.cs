using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Diagnostics.Tracing;

public class door : MonoBehaviour
{
    public TextMeshProUGUI winner;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Health.ded == true)
        {
            counter = counter + 1;
            if(counter == 10)
            {
                counter = 0;
                winner.text = "";

            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(key.stateofKey == true)
            {
                winner.text = "YAYYY YOU WIN, GOD BLESS YOU(IM CHRISTIAN BTW)";
            }
            
        }
        else
        {
            winner.text = "WHERE IS THE KEY?";
            Health.ded = true;

        }
    }
}
