using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Health : MonoBehaviour
{
    public static bool ded = false;
    public static float health = 100;
    GameObject player;
    public TextMeshProUGUI healthUI;
    // Start is called before the first frame update
    private void Start()
    {
        player = this.gameObject;
    }
    // Update is called once per frame
    void Update()
    {
        healthUI.text = "Health: "+ health;
        if (health <= 0 || Rewinder.isRewinding == true)
        {
            Debug.Log("now");
            ded = true;
            health = 100;


        }
        else
        {
            //ded = false;

        }

    }
}
