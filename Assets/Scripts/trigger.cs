using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {
	public int scoreValue = 10;

	void OnTriggerEnter (Collider other) {
		if (this.enabled) {
						change_text.score += scoreValue;
						this.enabled = false;
				}
	}
}
