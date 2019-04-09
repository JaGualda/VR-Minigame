using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutCollision : MonoBehaviour
{

    public GameObject collision;
    public GameObject ballspawn;
    private Vector3 spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = ballspawn.transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "BowlingBall")
        {
            Debug.Log("Colisión detectada");
            Instantiate(col.gameObject, spawnPosition, transform.rotation);
            Destroy(col.gameObject);

        }
    }
}
