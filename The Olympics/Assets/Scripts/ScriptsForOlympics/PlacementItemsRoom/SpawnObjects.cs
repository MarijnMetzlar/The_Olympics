using UnityEngine;
using System.Collections;

public class SpawnObjects : MonoBehaviour {

	public Transform prefab1;
	public Transform prefab2;

	public static float score;
	public static float updatedScore;

	public float clickOncePrefab1 = 0.0f;
	public float clickOncePrefab2 = 0.0f;
	
	
	void Update () 
	{
		score = ScoreCounter.points;
	}

	void OnMouseDown ()
	{
		if (score > 5 && score < 15 && clickOncePrefab1 == 0) 
		{
			Instantiate (prefab1, new Vector3 (10.4f, 2.7f, Random.Range (85.6f, 87.8f)), Quaternion.identity);
			updatedScore += -5.0f;
			clickOncePrefab1 += 1.0f;
		}

		if (score > 15 && score < 25 && clickOncePrefab2 == 0) 
		{
			Instantiate (prefab2, new Vector3 (10.4f, 2.7f, Random.Range (85.6f, 87.8f)), Quaternion.identity);
			updatedScore += -15.0f;
			clickOncePrefab2 += 1.0f;
		}
	}
}
