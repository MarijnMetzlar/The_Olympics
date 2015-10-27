using UnityEngine;
using System.Collections;

public class BottlecapScript : MonoBehaviour 
{
	public float speedy = 100.0f;
	public float bottleCapDespawner = 0.0f;
	public static float score;
	public static float updatedScore;

	// Update is called once per frame
	void Update () 
	{
		transform.Translate (0.0f, 0.015f, 0.0f);
		transform.Rotate (Vector3.up, speedy * Time.deltaTime);

		bottleCapDespawner += Time.deltaTime;

		if (bottleCapDespawner >= 15.0f) 
		{
			Destroy (gameObject);
		}
	}

//	void OnMouseDown()
//	{
//		Destroy (gameObject);
//		updatedScore += 15.0f;
//	}
}
