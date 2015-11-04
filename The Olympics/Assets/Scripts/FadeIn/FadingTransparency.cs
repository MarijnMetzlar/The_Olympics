using UnityEngine;
using System.Collections;

public class FadingTransparency : MonoBehaviour {
	
	public Renderer fader;

	// Update is called once per frame
	void Update () 
	{
		Color color = fader.material.color;
		color.a -= 0.1f;
		fader.material.color = color;
	}
}
