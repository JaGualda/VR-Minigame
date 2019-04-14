using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierSpawn : MonoBehaviour
{

    public GameObject[] pin;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if (pin[0].GetComponent<PinDespawn>().collision || pin[1].GetComponent<PinDespawn>().collision || pin[2].GetComponent<PinDespawn>().collision ||
            pin[3].GetComponent<PinDespawn>().collision || pin[4].GetComponent<PinDespawn>().collision || pin[5].GetComponent<PinDespawn>().collision ||
            pin[6].GetComponent<PinDespawn>().collision || pin[7].GetComponent<PinDespawn>().collision || pin[8].GetComponent<PinDespawn>().collision || pin[9].GetComponent<PinDespawn>().collision)
        {
            Debug.Log("Barra On");
            gameObject.SetActive(true);
        }
        else
        {
            Debug.Log("Barra Off");
            gameObject.SetActive(false);
        }
                 
    }
}
