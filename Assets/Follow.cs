using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	public Transform ship;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.eulerAngles = new Vector3(ship.eulerAngles.x, ship.eulerAngles.y, ship.eulerAngles.z);
	}
}
