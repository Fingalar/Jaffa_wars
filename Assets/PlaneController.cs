using UnityEngine;
using System.Collections;

public class PlaneController : MonoBehaviour {
	public GameObject	plane;
	public GameObject	mainCamera;
	private float			trigger;
	// Use this for initialization

	void Start () {
		mainCamera = (GameObject) GameObject.FindWithTag ("MainCamera");
	
		trigger = (transform.position.z + 46);
		Debug.Log (trigger.ToString ());
		Debug.Log (transform.localScale.ToString ());
	}
	
	// Update is called once per frame
	void Update () {
		if (mainCamera.transform.position.z == trigger) {
			Instantiate(plane, new Vector3(transform.position.x, transform.position.y, transform.position.z + 91),  transform.rotation);
				}
	}
}
