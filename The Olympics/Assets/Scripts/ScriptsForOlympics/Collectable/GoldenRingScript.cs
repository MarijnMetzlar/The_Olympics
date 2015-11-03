using UnityEngine;
using System.Collections;

public class GoldenRingScript : MonoBehaviour {

	public float speedy = 100.0f;
	public float goldenRingDespawner = 0.0f;
	public static float score;
	public static float updatedScore;
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (0.0f, 0.025f, 0.0f);
		transform.Rotate (Vector3.up, speedy * Time.deltaTime);
		
		goldenRingDespawner += Time.deltaTime;
		
		if (goldenRingDespawner >= 10.0f) 
		{
			Destroy (gameObject);
		}
	}
}
