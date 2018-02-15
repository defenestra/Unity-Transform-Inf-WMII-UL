using UnityEngine;
using System.Collections;

public class RotAround : MonoBehaviour {

    Vector3 rotationMask = new Vector3(0,1,0);
    public float rotationSpeed = 5.0f;
    public float OwnAxisSpeed = 1.0f;
    public Transform target;
	private Vector3 direction;


    private void FixedUpdate()
    {
		//obracanie sie wokol obiektu
		transform.RotateAround(target.transform.position, rotationMask, Time.deltaTime * rotationSpeed);

        /* //obracanie sie wokol wlasnej osi
        	transform.Rotate(new Vector3(
            rotationMask.x * OwnAxisSpeed * Time.deltaTime * -1,
            rotationMask.y * OwnAxisSpeed * Time.deltaTime * -1,
            rotationMask.z * OwnAxisSpeed * Time.deltaTime * -1));*/

    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
