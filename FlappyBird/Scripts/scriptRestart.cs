using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptRestart : MonoBehaviour
{
    public void restart(){
        scriptGC.gameOver = false;
        SceneManager.LoadScene(0);
    }
}
