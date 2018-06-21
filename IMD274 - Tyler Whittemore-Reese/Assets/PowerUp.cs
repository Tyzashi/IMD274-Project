using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour {

	public float JumpSpeed = 10f;
	public float jumpBonus; 
	public Rigidbody rb;

	void Update () 
	{

		transform.Rotate (Vector3.up, speed * Time.deltaTime);

	}

	void OnTriggerEnter ()
	{
		Destroy (gameObject);
	}

}
