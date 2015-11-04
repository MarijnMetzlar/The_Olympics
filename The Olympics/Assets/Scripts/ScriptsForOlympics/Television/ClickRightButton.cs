using UnityEngine;
using System.Collections;

public class ClickRightButton : MonoBehaviour {

	public GameObject video;
	public GameObject news;
	public static float screenChangeRight = 1.0f;

	public AudioSource clickTV;

	void OnMouseDown () 
	{
		clickTV.Play ();

		if (screenChangeRight == 1.0f)
		{
			screenChangeRight += 1.0f;
			video.transform.Translate (0, 0, 1);
		} 

		else if (screenChangeRight == 2.0f) 
		{
			screenChangeRight += 1.0f;
			video.transform.Translate (0, 0, -1);
			news.transform.Translate(0, 0, 1);
		} 

		else if (screenChangeRight == 3.0f)
		{
			screenChangeRight = 1.0f;
			news.transform.Translate(0, 0, -1);
		}
	}
}
