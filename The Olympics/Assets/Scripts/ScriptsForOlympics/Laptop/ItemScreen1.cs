using UnityEngine;
using System.Collections;

public class ItemScreen1 : MonoBehaviour {

	public Transform Item1;
	public float clickOnce = 0.0f;

	public static float score;
	public static float updatedScore;

	void Update()
	{
		score = ScoreCounter.points;
	}

	void OnMouseDown()
	{
		if (score >= 20.0f && clickOnce == 0.0f) 
		{
			updatedScore -= 20.0f;
			clickOnce += 1.0f;
			Instantiate (Item1, new Vector3 (4.0f, 2.0f, 734.1f), Quaternion.identity);
		}
	}
}
