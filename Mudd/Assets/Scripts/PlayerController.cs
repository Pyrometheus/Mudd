using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float walkForce = 50;
    public float maxWalkSpeed = 100;

    Rigidbody body;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
            walk(Vector3.forward);
        if (Input.GetKey(KeyCode.S))
            walk(Vector3.back);
        if (Input.GetKey(KeyCode.A))
            walk(Vector3.left);
        if (Input.GetKey(KeyCode.D))
            walk(Vector3.right);

        transform.rotation = Quaternion.LookRotation(directionToMouse());

        if(body.velocity.sqrMagnitude > maxWalkSpeed * maxWalkSpeed)
            body.velocity *= maxWalkSpeed / body.velocity.magnitude;
    }

    void walk(Vector3 dir)
    {
        body.MovePosition(body.position + dir * walkForce * Time.deltaTime);
        //body.AddForce(dir * walkForce);
    }

    Vector3 mouseToWorldPoint()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(ray, out hit);
        return hit.point;
    }

    Vector3 directionToMouse()
    {
        Vector3 diff = mouseToWorldPoint() - transform.position;
        diff.y = 0;
        return diff;
    }
}
