using UnityEngine;
using System.Collections;

public class SpawnObjects : MonoBehaviour {

	public Transform prefab1;
	public Transform prefab2;

	public static float score;
	public float updatedScore;

	public float clickOncePrefab1 = 0.0f;
	public float clickOncePrefab2 = 0.0f;
	

	// Update is called once per frame
	void Update () 
	{
		updatedScore = score;
		score = ScoreCounter.points;

		//OnMouseDown ();
		//Just For Fun
	}

	void OnMouseDown ()
	{
		if (score > 5 && score < 15 && clickOncePrefab1 == 0) 
		{
			Instantiate (prefab1, new Vector3 (10.4f, 2.7f, Random.Range (85.6f, 87.8f)), Quaternion.identity);
			updatedScore = score - 5;
			clickOncePrefab1 += 1.0f;
		}

		if (score > 15 && score < 25 && clickOncePrefab2 == 0) 
		{
			Instantiate (prefab2, new Vector3 (10.4f, 2.7f, Random.Range (85.6f, 87.8f)), Quaternion.identity);
			updatedScore = score - 15;
			clickOncePrefab2 += 1.0f;
		}
	}
}
