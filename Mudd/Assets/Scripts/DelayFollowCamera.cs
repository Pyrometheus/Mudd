using UnityEngine;
using System.Collections;

public class DelayFollowCamera : MonoBehaviour {

    public float rate;
    public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 tpos = target.position;
        Vector3 pos = transform.position;
        transform.Translate(new Vector3(tpos.x - pos.x, tpos.y - pos.y, 0) * rate);
    }
}
