using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    public GameObject trigger;
    private int shot;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gameObject.GetComponent<TextMesh>().text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        shot = trigger.GetComponent<BallCount>().counter;
        gameObject.GetComponent<TextMesh>().text = score.ToString();
        if (score == 10 && (shot == 1 || shot == 0))
        {
            gameObject.GetComponent<TextMesh>().text = "Strike !";
            trigger.GetComponent<BallCount>().strike = true;
        }    
        else if (score == 10 && shot == 2 && !gameObject.GetComponent<TextMesh>().text.Equals("Strike !"))
            gameObject.GetComponent<TextMesh>().text = "Spare !";
        
    }

    public void ResetScore()
    {
        score = 0;
    }
}
