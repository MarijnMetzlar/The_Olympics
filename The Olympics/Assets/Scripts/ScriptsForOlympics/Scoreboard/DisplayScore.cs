using UnityEngine;
using System.Collections;

public class DisplayScore : MonoBehaviour {

	public string text;
	public static float points;
	public TextMesh displayedText;
	
	// Update is called once per frame
	void Update () 
	{
		displayedText.text = ScoreCounter.points.ToString();
	}
}
