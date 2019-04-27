using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ObjectIdentifyer : MonoBehaviour
{
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
            if(tb.name == "ObjectTarget_car")
            Debug.Log(">>>>>> ObjectTarget_car - TrackableName: " + tb.name);

            if (tb.name == "ObjectTarget_tree")
                Debug.Log(">>>>>> ObjectTarget_tree- TrackableName: " + tb.name);
        }



    }
}
