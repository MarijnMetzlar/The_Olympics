using UnityEngine;
using System.Collections;

public class FadingChange : MonoBehaviour {
		
	public Texture2D fadeInTexture;
	public float fadeInSpeed = 0.5f;
		
	private int drawDepth = -1000;
	private float alpha = 1.0f;
	private int fadeDir = -1;

	private float elapsedTime = 0.0f;
		

	void OnGUI()
	{
		alpha += fadeDir * fadeInSpeed * Time.deltaTime;
		alpha = Mathf.Clamp01 (alpha);
			
		GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha);
		GUI.depth = drawDepth;
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeInTexture);

		removeFading ();
	}

	void removeFading()
	{
		elapsedTime += Time.deltaTime;
		if (elapsedTime > 2.0f) 
		{
			Destroy(gameObject);
		}
	}
}
