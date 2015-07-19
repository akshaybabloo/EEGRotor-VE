using UnityEngine;
using System.Collections;

public class ChangeSceneTo : MonoBehaviour {

	
	void OnTriggerEnter (Collider other) {
		if (this.enabled) {
			Application.LoadLevel("end");
			this.enabled = false;
		}
	}
}