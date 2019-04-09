using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutCollision : MonoBehaviour
{

    public GameObject collision;
    public GameObject ball;
    public GameObject ballspawn;

    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter(Collision col)
        {
            if(col.gameObject.name == "Bowling Ball")
            {
                Debug.Log("Colisión detectada");
                Destroy(col.gameObject);

            }
        }
    }
}
