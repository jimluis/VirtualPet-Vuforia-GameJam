using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{

    public Transform bar;
    public float health;


    // Start is called before the first frame update
    void Start()
    {
        health = .75f;
    }

    void Update()
    {
        bar.localScale = new Vector3(health, 1f);

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            health = health + .25f;

            
        }

        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            health = health - .25f;

        }
    }

}
