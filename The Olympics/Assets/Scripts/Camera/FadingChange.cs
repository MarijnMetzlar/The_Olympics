using UnityEngine;
using System.Collections;

public class FadingChange : MonoBehaviour {
		
	public Texture2D fadeInTexture;
	public float fadeInSpeed = 0.8f;
		
	private float alpha = 1.0f;
	private int fadeDir = -1;
		
	void OnGUI()
	{
		alpha += fadeDir * fadeInSpeed * Time.deltaTime;
		alpha = Mathf.Clamp01 (alpha);
			
		GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha);
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeInTexture);
	}
		
	public float BeginFade (int direction)
	{
		fadeDir = direction;
		return (fadeInSpeed);
	}
}
