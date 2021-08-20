using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptFloor : MonoBehaviour
{
    Vector2 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        //Assign the starting position with the position inserted in the transform
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(!scriptGC.gameOver){
            //if the end of the floow si far away, slide it to left
            if(transform.position.x >= -0.76f){
                //Slide to left
                transform.position = new Vector2(transform.position.x - 2f * Time.deltaTime, 
                    transform.position.y);
            }else
                transform.position = startPosition;
        }
        
    }
}
