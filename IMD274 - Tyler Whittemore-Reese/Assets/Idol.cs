using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idol : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        GameManager.instance.Win();
    }
}
