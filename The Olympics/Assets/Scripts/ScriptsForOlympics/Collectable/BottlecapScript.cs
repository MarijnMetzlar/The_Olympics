using UnityEngine;
using System.Collections;

public class BottlecapScript : MonoBehaviour 
{
	public float speedy = 100.0f;
	public float bottleCapDespawner = 0.0f;


	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (0.0f, 0.015f, 0.0f);

		bottleCapDespawner += Time.deltaTime;

		transform.Rotate (Vector3.up, speedy * Time.deltaTime);
		//transform.Rotate (Vector3.one, speedy * Time.deltaTime);

		if (bottleCapDespawner >= 15.0f) 
		{
			Destroy (gameObject);
		}
	}
}
