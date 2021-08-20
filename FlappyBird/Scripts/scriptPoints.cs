using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptPoints : MonoBehaviour
{
    public static int valuePoints;
    // Start is called before the first frame update
    void Start()
    {
        valuePoints = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Update the text on screen
        GetComponent<Text>().text = valuePoints.ToString();
    }
}
