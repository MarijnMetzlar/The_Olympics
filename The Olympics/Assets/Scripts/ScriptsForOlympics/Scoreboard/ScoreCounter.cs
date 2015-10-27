using UnityEngine;
using System.Collections;

public class ScoreCounter : MonoBehaviour {
	
	public float timerPoints;
	public static float points;
	public float changedPoints;
	public float changedPoints2;

	public float elapsedTime = 0.0f;


	// Update is called once per frame
	void Update () 
	{
		changedPoints = RaycastVideo.updatedScore;
		changedPoints2 = ItemScreen1.updatedScore;

		elapsedTime += Time.deltaTime;

		if (elapsedTime >= 1.0f) 
		{
			timerPoints += 1;
			elapsedTime = 0.0f;
		}

		points = changedPoints + changedPoints2 + timerPoints;
	}
}
