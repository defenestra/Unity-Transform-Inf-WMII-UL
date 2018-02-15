using UnityEngine;
using System.Collections;

public class RotAroundY : MonoBehaviour {

	public Transform target;
	public float orbitDistance = 10.0f;
	public float orbitDegreesPerSec = 180.0f;
	private Vector3 direction;
	Vector3 rotationMask = new Vector3(0,1,0);


	Vector3 relativePos;

	void Orbit()
	{
		relativePos = transform.position + (target.position - transform.position) * orbitDistance;
		Quaternion rotation = Quaternion.LookRotation (relativePos);
		transform.rotation = rotation;

		transform.RotateAround (target.position, rotationMask, Time.deltaTime * orbitDegreesPerSec);
	}

	private void LateUpdate()
	{
		Orbit ();
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
