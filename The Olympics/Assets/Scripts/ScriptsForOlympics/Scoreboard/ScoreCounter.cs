using UnityEngine;
using System.Collections;

public class ScoreCounter : MonoBehaviour {

	public string text;
	public static float points;
	public float elapsedTime = 0.0f;


	// Update is called once per frame
	void Update () 
	{
		points = SpawnObjects.score;

		elapsedTime += Time.smoothDeltaTime;
		if (elapsedTime >= 1.0f) 
		{
			points += 1;
			elapsedTime = 0.0f;
		}

		GetComponent<TextMesh>().text = " " + points;
	}
}
