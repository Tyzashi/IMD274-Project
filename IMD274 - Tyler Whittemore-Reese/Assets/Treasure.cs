using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Treasure : MonoBehaviour {

    public AudioClip Blip_C_03;
    public AudioSource GoldNugget;

    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(Blip_C_03, Camera.main.transform.position);
        Score.score += 100;
        Destroy(gameObject);
    }
}
