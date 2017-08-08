using UnityEngine;
using System.Collections;

public class ParalaxMover : MonoBehaviour {
	
	float speed = -0.1f;

	void FixedUpdate () {
		Vector3 Po = transform.position;
		Po.x += speed * Time.deltaTime;
		transform.position = Po;
	}
}
