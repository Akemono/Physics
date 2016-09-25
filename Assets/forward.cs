using UnityEngine;
using System.Collections;

public class forward : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * 1 * Time.deltaTime);
	}
}
