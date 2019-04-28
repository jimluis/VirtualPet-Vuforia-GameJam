using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ObjectIdentifier : MonoBehaviour
{
    //public delegate void HealthUpdate(float hits);
    public Transform bar;
    //Healthbar healthBar = new Healthbar();

 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        IEnumerable<Vuforia.TrackableBehaviour> tbs = TrackerManager.Instance.GetStateManager().GetActiveTrackableBehaviours();
        foreach (TrackableBehaviour tb in tbs)
        {
            if (tb.name == "ObjectTarget_car")
            {
                Debug.Log(">>>>>> ObjectTarget_car- TrackableName: " + tb.name);
                Healthbar.DecreaseHealth(.001f);
            }


            if (tb.name == "ObjectTarget_tree")
            {
                Debug.Log(">>>>>> ObjectTarget_tree- TrackableName: " + tb.name);
                Healthbar.IncreaseHealth(.001f);
            }
           
        }



    }
}
