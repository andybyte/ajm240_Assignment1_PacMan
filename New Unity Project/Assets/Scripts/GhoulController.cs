// Ghoul Controller contains simple AI.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhoulController : MonoBehaviour {
	private Transform gh;
	public float speed;
	public Vector3 direction;
	public Vector3 rotate;

	// Initialization
	void Start () {
		gh = this.transform;
	}

	// Update provides movement and rotation when Ghoul contacts wall.
	void Update () {
		gh.Translate (direction * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Wall")) {
			gh.Rotate (rotate);
		}
	}


}
