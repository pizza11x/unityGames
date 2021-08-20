using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptGC : MonoBehaviour
{
    float spawnTimer;
    float spawnRate = 3f;
    public GameObject tube;
    public static bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameOver){
            //adds to spawnTimer the duration of the frame just elapsed
            spawnTimer += Time.deltaTime;
            // If the spawnTimer is greater than or equal to the spawnRate, then randomly generate the tubes
            if(spawnTimer >= spawnRate){
                spawnTimer -= spawnRate;
                Vector2 spawnPosition = new Vector2(2f, Random.Range(-1f,2f));
                Instantiate(tube, spawnPosition, Quaternion.identity);
            }
        }
        
    }
}
