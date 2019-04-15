using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotTracker : MonoBehaviour
{
    public GameObject trigger;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger.GetComponent<BallCount>().counter == 0)
            gameObject.GetComponent<TextMesh>().text = "Shot 1";
        else if (trigger.GetComponent<BallCount>().counter == 1)
            gameObject.GetComponent<TextMesh>().text = "Shot 2";
    }
}
