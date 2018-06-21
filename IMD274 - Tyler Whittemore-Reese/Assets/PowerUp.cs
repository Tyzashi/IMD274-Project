using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour {

    public float JumpSpeed = 10f;
    public float jumpBonus;
    public Rigidbody rb;

    private void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
