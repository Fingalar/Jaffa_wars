using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject plane;
	private	float trigger;

	// Use this for initialization
	void Start () {
		trigger = 250;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 cameraMove = new Vector3 (transform.position.x, transform.position.y, transform.position.z + 0.2f);
		transform.position = cameraMove;
		if (transform.position.z >= trigger ) {
			Instantiate(plane, new Vector3(115, 0, transform.position.z + 300), Quaternion.identity);
			trigger += 230;
		}
	}
}