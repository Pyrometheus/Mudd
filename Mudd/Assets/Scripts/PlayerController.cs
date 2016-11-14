using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float walkForce = 50;

    Rigidbody body;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
            body.AddForce(Vector3.forward * walkForce);
        if (Input.GetKey(KeyCode.S))
            body.AddForce(Vector3.back * walkForce);
        if (Input.GetKey(KeyCode.A))
            body.AddForce(Vector3.left * walkForce);
        if (Input.GetKey(KeyCode.D))
            body.AddForce(Vector3.right * walkForce);
    }
}
