using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    public GameObject winText;
    public float resetDelay;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        else if (instance != null)
        { 
            Destroy(gameObject);

        }

    }

    public void Win()
    {
        winText.SetActive(true);
        Invoke("Reset", resetDelay);
    }

    public void Reset()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
