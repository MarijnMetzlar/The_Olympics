using UnityEngine;
using System.Collections;

public class BubbleScript : MonoBehaviour {

	public float bubbleDespawner = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (0.0f, 0.025f, 0.0f);

		bubbleDespawner += Time.deltaTime;

		if (bubbleDespawner >= 10.0f) 
		{
			Destroy (gameObject);
		}
	}
}
