using UnityEngine;
using System.Collections;

public class BottlecapScript : MonoBehaviour 
{
	public float speedy = 100.0f;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (0.0f, 0.1f, 0.0f);
		transform.Rotate (Vector3.up, speedy * Time.deltaTime);
		transform.Rotate (Vector3.one, speedy * Time.deltaTime);
	}
}
