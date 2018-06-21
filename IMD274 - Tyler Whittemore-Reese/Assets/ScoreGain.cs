using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGain : MonoBehaviour {

	public Text ScoreText;
	private int Score;

	void Start () {
		Score = 0;
		SetScoreText ();
	}

	void OnTriggerEnter(Collider other)
	{
		Score = Score + 1;
		SetScoreText ();
	}

	void SetScoreText ()
	{
		ScoreText.text = "Score: " + Score.ToString ();
	}
}
