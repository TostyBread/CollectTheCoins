using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{

    public float InitialDuration = 60f;
    public float CurrentTime = 0f;

    private bool timesUp;

    // Start is called before the first frame update
    void Start()
    {
        CurrentTime = InitialDuration;
    }

    // Update is called once per frame
    void Update()
    {
        //When the game is over, it should stop the game
        if(CurrentTime <= 0 && !timesUp)
        {
            Debug.Log("TIMES UP");
            timesUp = true;
            return;
        }

        CurrentTime -= Time.deltaTime;
    }
}
