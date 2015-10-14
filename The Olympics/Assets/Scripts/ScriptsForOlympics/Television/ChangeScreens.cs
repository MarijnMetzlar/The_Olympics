using UnityEngine;
using System.Collections;

public class ChangeScreens : MonoBehaviour {

	public Material[] materials;
	public static int index;
	
	void Start () 
	{
		index = 1;
	}

	void Update()
	{
		if (Input.GetKeyUp (KeyCode.M)) 
		{
			gameObject.GetComponent<Renderer> ().material = materials [index];
			index = (index + 1) % materials.Length;
		}
	}
}
