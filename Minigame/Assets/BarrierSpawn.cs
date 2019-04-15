using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierSpawn : MonoBehaviour
{

    public GameObject[] pin;
    public GameObject barrier;
    public GameObject trigger;

    public bool isActive;


    // Start is called before the first frame update
    void Start()
    {
        barrier.SetActive(false);
        isActive = false;
        //Debug.Log("OK");
    }

    // Update is called once per frame
    void Update()
    {
        if ((pin[0].GetComponent<PinDespawn>().GetCollision() || pin[1].GetComponent<PinDespawn>().GetCollision() || pin[2].GetComponent<PinDespawn>().GetCollision() ||
            pin[3].GetComponent<PinDespawn>().GetCollision() || pin[4].GetComponent<PinDespawn>().GetCollision() || pin[5].GetComponent<PinDespawn>().GetCollision() ||
            pin[6].GetComponent<PinDespawn>().GetCollision() || pin[7].GetComponent<PinDespawn>().GetCollision() || pin[8].GetComponent<PinDespawn>().GetCollision() ||
            pin[9].GetComponent<PinDespawn>().GetCollision()) || trigger.GetComponent<BallCount>().barrera)
        {
            //Debug.Log("Barra On");
            barrier.SetActive(true);
            isActive = true;
        }
        else
        {
            //Debug.Log("Barra Off");
            barrier.SetActive(false);
            isActive = false;
        }
                 
    }
}
