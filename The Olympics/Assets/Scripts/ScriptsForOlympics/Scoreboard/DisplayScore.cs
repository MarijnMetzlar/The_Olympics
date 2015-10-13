using UnityEngine;
using System.Collections;

public class DisplayScore : MonoBehaviour {

	public string text;
	public static float points;
	
	// Update is called once per frame
	void Update () 
	{
		GetComponent<TextMesh>().text = " " + ScoreCounter.points;
	}
}
