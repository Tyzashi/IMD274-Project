using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour {

    public float m_JumpSpeed = 100f;
    public Rigidbody rb;


    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
