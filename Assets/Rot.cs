using UnityEngine;
using System.Collections;

public class Rot : MonoBehaviour {

    public float rotSpeed = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 1, 0), rotSpeed * Time.deltaTime);
	}
}
