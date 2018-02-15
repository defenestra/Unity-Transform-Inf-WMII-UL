using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	/*public Transform m_Target;
	public float m_Speed = 5.0f;
	private bool moving = false;
	private Vector3 direction;
	private GameObject plChar;*/

	public Transform target;
	public float orbitDistance = 200.0f;
	public float orbitDegreesPerSec = 180.0f;
	private Vector3 direction;
	Vector3 rotationMask = new Vector3(0,1,0);

	// Use this for initialization
	void Start () {

	}

	void Orbit()
	{
		if(target != null)
		{
			//"patrzenie" w kierunku obiektu
			direction = target.position - transform.position;
			//zepwnia odleglosc od obiektu
			transform.position = target.position + (transform.position - target.position).normalized * orbitDistance;
			//obracanie wokol obiektu
			transform.RotateAround(target.transform.position, Vector3.up, orbitDegreesPerSec * Time.deltaTime);
			//transform.RotateAround(target.position, Vector3.right, orbitDegreesPerSec * Time.deltaTime); //

		}
	}

	void Orbit2()
	{
		if (target != null) {
			direction = target.position - transform.position;

			//transform.position = target.position + (transform.position - target.position).normalized * orbitDistance;
			transform.Translate (direction * orbitDegreesPerSec * Time.deltaTime, Space.World);

			transform.RotateAround (target.position, rotationMask, Time.deltaTime * orbitDegreesPerSec);
		}
	}

	// Update is called once per frame
	void Update () {

		// Call from LateUpdate instead...
		// Orbit();

	}
	// Call from LateUpdate if you want to be sure your
	// target is done with it's move.
	void LateUpdate () {
	//void FixedUpdate () {

		//Orbit();
		Orbit2();

	}

	/*Vector3 rotationMask = new Vector3(1, 0, 0);
	Vector3 Mask2 = new Vector3 (0, 1, 0);
	public float rotationSpeed = 5.0f;
	public float OwnAxisSpeed = 1.0f;
	public Transform rotateX;
	public Transform rotateY;
	//public GameObject m_Target;

	private void FixedUpdate()
	{
		//transform.position = new Vector3(m_Target.transform.position.x, m_Target.transform.position.y, transform.position.z);

		//transform.RotateAround(rotateAround)


		//obracanie sie wokol obiektu
		transform.RotateAround(rotateX.transform.position, rotationMask, Time.deltaTime * rotationSpeed);
		transform.RotateAround(rotateY.transform.position, Mask2, Time.deltaTime * rotationSpeed);



		transform.Rotate(new Vector3( //obracanie wokol wlasnej osi
			rotationMask.x * OwnAxisSpeed * Time.deltaTime * -1,
			rotationMask.y * OwnAxisSpeed * Time.deltaTime * -1,
			rotationMask.z * OwnAxisSpeed * Time.deltaTime * -1));

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//sledzenie obiektu
		/*direction = m_Target.position - transform.position;
		moving = true;

		if (moving)
			transform.Translate (direction * m_Speed * Time.deltaTime, Space.World);*/
	//}
}
