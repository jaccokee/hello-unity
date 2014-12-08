using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {}

	// Update is called once per frame
	void Update () {
		// Get the input vector from keyboard or analog stick
		var directionVector = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

		rigidbody.velocity = directionVector * speed;
	}
}
