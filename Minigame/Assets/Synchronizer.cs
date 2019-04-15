using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Synchronizer : MonoBehaviour
{
    public GameObject[] pin;
    public GameObject[] spawnPin;
    public Rigidbody[] rigidPin;
    public GameObject trigger;
    private float timer = 6000.00f;
    private bool barrier;

    // Start is called before the first frame update
    void Start()
    {
        barrier = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            barrier = false;
            timer = 6000.00f;
        }
    }

    public void ResetPins()
    {
        timer = 5.00f;
        while (barrier) ;
        for (int i = 0; i < 10; i++)
        {
            rigidPin[i].constraints = RigidbodyConstraints.FreezeRotation;
            pin[i].transform.rotation = spawnPin[i].transform.rotation;
            pin[i].transform.position = spawnPin[i].transform.position;
        }
        trigger.GetComponent<BallCount>().timer = 1.00f;
    }
}
