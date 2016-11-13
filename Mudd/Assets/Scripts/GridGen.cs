using UnityEngine;
using System.Collections;

public class GridGen : MonoBehaviour {

    bool[,] grid;

    public float x, y;
    public int width, height;


	// Use this for initialization
	void Start () {
        grid = new bool[width, height];
	}
	
	// Update is called once per frame
	void Update () {
	}
}
