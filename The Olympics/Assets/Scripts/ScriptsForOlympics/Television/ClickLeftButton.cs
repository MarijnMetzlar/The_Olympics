using UnityEngine;
using System.Collections;

public class ClickLeftButton : MonoBehaviour {

	public GameObject video;
	public GameObject news;

	public AudioSource clickTV;

	void OnMouseDown () 
	{
		clickTV.Play();

		if (ClickRightButton.screenChangeRight == 1.0f)
		{
			ClickRightButton.screenChangeRight += 2.0f;
			news.transform.Translate(0, 0, 1);
		} 
		
		else if (ClickRightButton.screenChangeRight == 2.0f) 
		{
			ClickRightButton.screenChangeRight -= 1.0f;
			video.transform.Translate(0, 0, -1);
		} 
		
		else if (ClickRightButton.screenChangeRight == 3.0f)
		{
			ClickRightButton.screenChangeRight -= 1.0f;
			video.transform.Translate (0, 0, 1);
			news.transform.Translate(0, 0, -1);
		}
	}
}
