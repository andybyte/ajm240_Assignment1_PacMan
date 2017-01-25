// Script to rotate walls.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRotator : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		Vector3 rotation = new Vector3 (0, 0, 45);

		transform.Rotate (rotation * Time.deltaTime);
	}
}
