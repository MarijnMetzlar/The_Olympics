using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour {
	
	public Camera roomCamera;
	public Camera movieCamera;
	public Camera scoreBoardCamera;

	private Camera[] cameras;
	private Camera currentCamera;

	// Use this for initialization
	void Start () 
	{
		movieCamera.enabled = false;
		roomCamera.enabled = true;
		scoreBoardCamera.enabled = false;

		//roomCamera.enabled = true;
		//movieCamera.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Input.GetKeyDown (KeyCode.Escape)

		//if (Input.GetKeyDown ("backspace") && movieCamera.enabled == true) 
		if (Input.GetKeyDown (KeyCode.Escape) && movieCamera.enabled == true) 
		{
			ChangeView();
		}

		//if (Input.GetKeyDown ("backspace") && scoreBoardCamera.enabled == true)
		if (Input.GetKeyDown (KeyCode.Escape) && scoreBoardCamera.enabled == true) 
		{
			ChangeView();
		}
	}

	void ChangeView	()
	{
		roomCamera.enabled = true;
		movieCamera.enabled = false;
		scoreBoardCamera.enabled = false;
	}
}
