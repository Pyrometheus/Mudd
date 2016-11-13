using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float walkForce = 50;

    Rigidbody2D body;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
            body.AddForce(Vector2.up * walkForce);
        if (Input.GetKey(KeyCode.S))
            body.AddForce(Vector2.down * walkForce);
        if (Input.GetKey(KeyCode.A))
            body.AddForce(Vector2.left * walkForce);
        if (Input.GetKey(KeyCode.D))
            body.AddForce(Vector2.right * walkForce);
    }
}
