﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour {

	public static int score;

	Text text;

	void Start () {

		text = GetComponent <Text> ();

	}

	void Update () {

		text.text = score.ToString ();
	}
}
