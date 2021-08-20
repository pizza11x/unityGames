using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptTubes : MonoBehaviour
{
    AudioSource audioSource;
    bool alreadyCounted = false;
    // Start is called before the first frame update
    void Start()
    {
        //Initialize the sounds
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!scriptGC.gameOver){
            transform.position = new Vector2(transform.position.x - 2f * Time.deltaTime, 
                transform.position.y);
            if(transform.position.x < -6)
                Destroy(gameObject);
        }
        //If the tube hasn't already been counted, and Flappy has passed it, add the point
        if(!alreadyCounted && transform.position.x < -4){
            //Play sound point
            audioSource.Play();
            alreadyCounted = true;
            scriptPoints.valuePoints += 1;
        }
    }
}
