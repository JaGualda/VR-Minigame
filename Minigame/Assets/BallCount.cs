using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCount : MonoBehaviour
{

    public GameObject[] pin;
    public GameObject[] spawnPin;
    public Rigidbody[] rigidPin;
    public GameObject score;

    public float timer = 600.00f;
    private float timer2 = 8.00f;
    public int counter;
    public bool barrera = false;
    public bool strike = false;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 2 || strike)
        {
            barrera = true;
            timer2 -= Time.deltaTime;
            if (timer2 < 0)
            {
                ResetPins();
                counter = 0;
                strike = false;
                score.GetComponent<Score>().ResetScore();
                timer2 = 8.00f;
            }
        }
        timer -= Time.deltaTime;        //Timer
        if (timer < 0)
        {
            for (int i = 0; i < 10; i++)
            {
                rigidPin[i].constraints = RigidbodyConstraints.None;
            }
            barrera = false;
            Debug.Log("Constraints clear");
            timer = 600.00f;
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

    public void ResetPins()
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
