using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptFlappy : MonoBehaviour
{
    public AudioClip[] audioClips;
    Rigidbody2D valueRB;
    public GameObject gameOver;
    public GameObject restart;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //Initialize the value for physical component
        valueRB = GetComponent<Rigidbody2D>();
        //Initialize the sounds
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !scriptGC.gameOver){
            //Play sound fly
            audioSource.PlayOneShot(audioClips[0]);
            valueRB.velocity = new Vector2(0f,7f);
        }
        
    }
    
    //Flappy collides with tubes
    private void OnCollisionEnter2D(Collision2D other) {
        //Play sound collide
        audioSource.PlayOneShot(audioClips[1]);
        scriptGC.gameOver = true;
        restart.SetActive(true);
        gameOver.SetActive(true);
    }
}
