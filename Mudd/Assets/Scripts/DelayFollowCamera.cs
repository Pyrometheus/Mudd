using UnityEngine;
using System.Collections;

public class DelayFollowCamera : MonoBehaviour {

    public float rate;
    public Transform target;
    Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - target.position;	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 motion = (target.position - transform.position) + offset;
        transform.position += new Vector3(motion.x, 0, motion.z) * Mathf.Pow(rate, Time.deltaTime * 100);
        //Vector3 tpos = target.position;
        //Vector3 pos = transform.position;
        //transform.position += new Vector3(tpos.x - pos.x, 0, tpos.z - pos.z) * rate;
    }
}
