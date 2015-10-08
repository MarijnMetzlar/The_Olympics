using UnityEngine;
using System.Collections;

public class SpawnBottleCap : MonoBehaviour {

	public Transform prefabBottleCap;

	public float bottleCapSpawner = 0.0f;

	// Use this for initialization
	void Start () 
	{
		Instantiate (prefabBottleCap, new Vector3 (Random.Range(-4.6f, 4.6f), -4.2f, Random.Range(1.3f, 6.8f)), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () 
	{
		bottleCapSpawner += Time.deltaTime;

		if (bottleCapSpawner >= 2.0f) 
		{
			bottleCapSpawner = 0.0f;
			Instantiate (prefabBottleCap, new Vector3 (Random.Range (-4.6f, 4.6f), -4.2f, Random.Range (1.3f, 6.8f)), Quaternion.identity);
		}
	}
}
