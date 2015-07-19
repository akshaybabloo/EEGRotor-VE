using UnityEngine;
using System.Collections;

public class button_click : MonoBehaviour {
	

	// Update is called once per frame
	public void ClickEvent (int OnClickEvent) {
		Application.LoadLevel (OnClickEvent);
	
	}
}
