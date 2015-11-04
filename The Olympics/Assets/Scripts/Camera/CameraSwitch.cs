using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour {

	public Camera movieCamera;
	public Camera VIPCamera;

	public Transform fading;

	private Camera[] cameras;
	private Camera currentCamera;


	// Use this for initialization
	void Start () 
	{
		movieCamera.enabled = true;
		VIPCamera.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Escape) && movieCamera.enabled == true) 
		{
			//FADING
			//Instantiate(fading, new Vector3 (0.0f, 0.0f, 0.0f), Quaternion.identity);
			ChangeView();
		}
	}

	void ChangeView	()
	{
		movieCamera.enabled = false;
		VIPCamera.enabled = true;
	}
}
