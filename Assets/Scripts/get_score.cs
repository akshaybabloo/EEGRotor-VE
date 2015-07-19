using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class get_score : MonoBehaviour {

	Text txt;

	// Use this for initialization
	void Awake () {
		txt = GetComponent<Text> ();
		txt.text = "Total:" + change_text.score;
	}
	

}
