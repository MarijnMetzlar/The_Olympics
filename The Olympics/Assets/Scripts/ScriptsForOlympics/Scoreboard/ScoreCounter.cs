using UnityEngine;
using System.Collections;

public class ScoreCounter : MonoBehaviour {

	public string text;
	public static float points;
	public float elapsedTime = 0.0f;
	
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		points = SpawnBall.score;

		elapsedTime += Time.smoothDeltaTime;
		if (elapsedTime >= 1.0f) 
		{
			points += 1;
			elapsedTime = 0.0f;
		}

		GetComponent<TextMesh>().text = " " + points;
	}
}
