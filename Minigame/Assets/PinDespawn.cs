using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinDespawn : MonoBehaviour
{
    public GameObject spawn;
    public GameObject score;

    private float timer;
    public bool collision;

    // Start is called before the first frame update
    void Start()
    {
        collision = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (collision)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                this.transform.position = spawn.transform.position;
                Debug.Log("Despawn pin");
                collision = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.name == "TriggerPin")
        {
            timer = 2.00f;
            collision = true;
            score.GetComponent<Score>().score++;
        }
    }

    public bool GetCollision()
    {
        return collision;
    }
}