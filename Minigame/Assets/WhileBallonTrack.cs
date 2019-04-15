using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileBallonTrack : MonoBehaviour
{

    public GameObject colliderThrow;
    public bool collision;

    // Start is called before the first frame update
    void Start()
    {
        colliderThrow.SetActive(false);
        collision = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(collision == false)
            colliderThrow.SetActive(false);
    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "BowlingBall")
        {
            //Debug.Log("Colisión bola track");
            collision = true;
            colliderThrow.SetActive(true);       
        }    
    }

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "BowlingBall")
        {
            //Debug.Log("Colisión detectada");
            collision = false;
        }
    }
}
