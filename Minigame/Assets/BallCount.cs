using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCount : MonoBehaviour
{

    public GameObject[] pin;
    public GameObject[] spawnPin;
    public Rigidbody[] rigidPin;

    private float timer;
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
            ResetPins();
            counter = 0;
        }
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            for (int i = 0; i < 10; i++)
            {
                rigidPin[i].constraints = RigidbodyConstraints.None;
            }
            timer = 1.00f;
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
            rigidPin[i].constraints = RigidbodyConstraints.FreezeRotation;
            pin[i].transform.rotation = spawnPin[i].transform.rotation;
            pin[i].transform.position = spawnPin[i].transform.position;
        }
        timer = 1.00f;
    }
}
