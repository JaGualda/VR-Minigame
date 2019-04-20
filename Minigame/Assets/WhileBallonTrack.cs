using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileBallonTrack : MonoBehaviour
{

    public GameObject colliderThrow;
    public bool collision;
    public GameObject score;
    private AudioSource source;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        colliderThrow.SetActive(false);
        collision = false;
        source = GetComponent<AudioSource>();
        timer = 2.00f;
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
            if (score.GetComponent<Score>().score > 0)
                timer -= Time.deltaTime;
            if(timer < 0)
            {
                col.rigidbody.AddForce(100, 0, 0);
                timer = 2.00f;
            }
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BowlingBall")
        {
            source.time = 0.15f;
            source.PlayDelayed(0);
        }

    }
}
