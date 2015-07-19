using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class change_text : MonoBehaviour{
	public static int score;        // The player's score.
	
	
	Text text;                      // Reference to the Text component.

	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		score = 0;
		//GameObject player = new GameObject ("First Person Controller");
	}
	
	
	void Update ()
	{
		// Set the displayed text to be the word "Score" followed by the score value.
		text.text = "Score: " + score;
	}



}




//	Text txt;
//	private int currentPoints = 0;
//
//	// Use this for initialization
//	void Start () {
//		txt = gameObject.GetComponent<Text>();
//		txt.text = "Points:" + currentPoints;
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		txt.text = "Points:" + currentPoints;
//		for (int a = 0; a<=3; a++) {
//						currentPoints = a * 10;
//				}
//	
//	}

