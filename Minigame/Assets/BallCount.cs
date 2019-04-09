using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCount : MonoBehaviour
{

    public GameObject[] pin;
    public GameObject[] spawnPin;
    public GameObject refPin;

    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 2)
        {
            counter = 0;
            ResetPins();
        }  
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "BowlingBall")
        {
            counter++;
            Debug.Log(counter);
        }
           
    }

    private void ResetPins()
    {
        for(int i=0; i<10; i++)
        {
            Destroy(pin[i]);
            Instantiate(refPin, spawnPin[i].transform.position, transform.rotation);
        }
    }
}
