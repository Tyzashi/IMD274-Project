using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int score;

    Text text;

    private void Start()
    {
        text = GetComponent<Text>();

    }

    private void Update()
    {
        text.text = score.ToString();
    }
}
