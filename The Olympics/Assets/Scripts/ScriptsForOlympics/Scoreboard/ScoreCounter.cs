using UnityEngine;
using System.Collections;

public class ScoreCounter : MonoBehaviour {

	public static float points;
	public float changedPoints;
	public float changedPoints2;

	public float elapsedTime = 0.0f;


	// Update is called once per frame
	void Update () 
	{
		changedPoints = RaycastVideo.updatedScore;
		changedPoints2 = Raycast.updatedScore;

		points = changedPoints + changedPoints2;
	}
}
