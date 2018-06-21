using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectGold : MonoBehaviour {

	public AudioClip  Blip_C_03;
	public AudioSource GoldNugget;

	void OnTriggerEnter()
	{
		AudioSource.PlayClipAtPoint (Blip_C_03, Camera.main.transform.position);
		Score.score += 100;
		Destroy (gameObject);

	}

}
