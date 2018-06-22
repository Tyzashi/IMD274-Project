using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour {

    public AudioClip Blip;
    public AudioSource Source;


    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(Blip, Camera.main.transform.position);
        Score.score += 100;
        Destroy(gameObject);
    }
}
