using UnityEngine;
using System.Collections;

public class LaptopChangeScreens : MonoBehaviour {

	public GameObject screen1;
	public GameObject screen2;
	public GameObject screen3;

	public float changeScreen = 1.0f;

	// Use this for initialization
	void OnMouseDown()
	{
		if (changeScreen == 1.0f) 
		{
			changeScreen += 1.0f;
			screen1.transform.Translate (0, -2, 0);
			screen2.transform.Translate (0, 2, 0);
		}

		else if (changeScreen == 2.0f) 
		{
			changeScreen += 1.0f;
			screen2.transform.Translate (0, -2, 0);
			screen3.transform.Translate (0, 2, 0);
		}

		else if (changeScreen == 3.0f) 
		{
			changeScreen = 1.0f;
			screen3.transform.Translate (0, -2, 0);
			screen1.transform.Translate (0, 2, 0);
		}
	}
}
