using UnityEngine;
using System.Collections;

public class SpawnBottleCap : MonoBehaviour {

	public Transform prefabBottleCap;
	public float timeOfBottleCap = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		timeOfBottleCap = Time.deltaTime;

		if (timeOfBottleCap > 5.0f) 
		{
			timeOfBottleCap = 0.0f;
			Instantiate (prefabBottleCap, new Vector3 (9.0f, 2.0f, 24.5f), Quaternion.identity);
		}

		Destroy (gameObject, 5)
	}
}
