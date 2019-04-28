using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{

    public Transform bar;
    public static float currentHealth;
    GameObject evolution;
    public static GameObject whale; 

     void Awake()
    {

         evolution = GameObject.Find("Diatama_evolvedII");
         whale = GameObject.Find("whale");

    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = .75f;
        evolution.SetActive(false);
        whale.SetActive(false); 
    }


    void Update()
    {
        bar.localScale = new Vector3(currentHealth, 1f);
        Debug.Log(">>>>>> Healthbar- Update: " + currentHealth);

        if (currentHealth >= 1f)
        {
            GameObject cell = GameObject.Find("Diatama_baby"); 


            if (cell != null)
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

           // Debug.Log(">>>>>> Healthbar- cell: " + cell);

        }

    }

    public static void IncreaseHealth(float healthIn)
    {

        currentHealth = currentHealth + healthIn;
        //bar.localScale = new Vector3(currentHealth, 1f);

        if (healthIn >= 0.01f)
        {
            GameObject evolvedII = GameObject.Find("Diatama_evolvedII");

            Vector3 tmpevolvedIITransform = new Vector3(evolvedII.transform.position.x, evolvedII.transform.position.y, evolvedII.transform.position.z);
            Destroy(evolvedII);

            currentHealth = 1f;
            whale.SetActive(true);

            //Instantiate(whale, tmpevolvedIITransform, Quaternion.identity);
        }

    }

    public static void DecreaseHealth(float healthIn)
    {
        currentHealth = currentHealth - healthIn;
        //bar.localScale = new Vector3(currentHealth, 1f);
        Debug.Log(">>>>>> Healthbar- DecreaseHealth: " + currentHealth);
    }

}
