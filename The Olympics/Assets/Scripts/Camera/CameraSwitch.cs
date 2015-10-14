using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour {
	
	public Camera roomCamera;
	public Camera movieCamera;
	public Camera VIPCamera;

	private Camera[] cameras;
	private Camera currentCamera;

	// Use this for initialization
	void Start () 
	{
		movieCamera.enabled = true;
		//roomCamera.enabled = false;
		VIPCamera.enabled = false;

		//roomCamera.enabled = true;
		//movieCamera.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Input.GetKeyDown (KeyCode.Escape)

		if (Input.GetKeyDown (KeyCode.Escape) && movieCamera.enabled == true) 
		{
			ChangeView();
		}
	}

	void ChangeView	()
	{
		movieCamera.enabled = false;
		VIPCamera.enabled = true;
	}
}
