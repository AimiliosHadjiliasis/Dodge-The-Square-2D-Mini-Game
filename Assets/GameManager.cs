using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void EndGame()
    {
        //Reload our scene when we collide witrh an object:
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
