using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{

    public Transform bar;
    public static float currentHealth;
    GameObject evolution;

     void Awake()
    {

         evolution = GameObject.Find("Diatama_evolvedII");
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = .75f;
        evolution.SetActive(false);
    }


    void Update()
    {
        bar.localScale = new Vector3(currentHealth, 1f);
        Debug.Log(">>>>>> Healthbar- Update: " + currentHealth);
        if (currentHealth >= 1f)
        {
            GameObject cell = GameObject.Find("Diatama_baby");

            if(cell != null)
            {

                Vector3 tmpCellTransform = new Vector3(cell.transform.position.x, cell.transform.position.y, cell.transform.position.z);
                Destroy(cell);

                currentHealth = .25f;


                // var evolution = Resources.Load("Assets/Images/Diatama_evolved") as Sprite;
                // var evolution = Resources.Load<Sprite>("/Images/Diatama_evolved");
                //  GameObject evolution = Instantiate(Resources.Load("Diatama_evolved", typeof(GameObject))) as GameObject;

                //Diatama_evolvedII
                //evolution = GameObject.Find("Diatama_evolvedII");
                evolution.SetActive(true);
                //evolution.transform.position = tmpCellTransform;
                //evolution.SetActive(true);

               // if (evolution != null)
                  Instantiate(evolution, tmpCellTransform, Quaternion.identity);
               // else
               //     Debug.Log("*** Healthbar - evolution not found ");
            }
            else
                Debug.Log(">>>>>> Healthbar- cell: " + cell);

        }

    }

    public static void IncreaseHealth(float healthIn)
    {

        currentHealth = currentHealth + healthIn;
        //bar.localScale = new Vector3(currentHealth, 1f);

    }

    public static void DecreaseHealth(float healthIn)
    {
        currentHealth = currentHealth - healthIn;
        //bar.localScale = new Vector3(currentHealth, 1f);
        Debug.Log(">>>>>> Healthbar- DecreaseHealth: " + currentHealth);
    }

}
