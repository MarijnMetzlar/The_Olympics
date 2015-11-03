using UnityEngine;
using System.Collections;

public class SpawnGoldenRing : MonoBehaviour {

	public Transform goldenRingPrefab;

	public float goldenRingTimer;
	
	void Update () 
	{
		goldenRingTimer += Time.deltaTime;

		if (goldenRingTimer >= 50.0f) 
		{
			Instantiate (goldenRingPrefab, new Vector3 (Random.Range (-20.0f, 20.0f), -10.0f, Random.Range (-20.0f, 20.0f)), Quaternion.identity);
			goldenRingTimer = 0.0f;
		}
	}
}
