// Script to rotate platforms.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotator : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		Vector3 rotation = new Vector3 (0, 0, 9);

		transform.Rotate (rotation * Time.deltaTime);
	}
}
