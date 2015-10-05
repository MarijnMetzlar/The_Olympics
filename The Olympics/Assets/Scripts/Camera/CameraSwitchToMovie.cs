using UnityEngine;
using System.Collections;

public class CameraSwitchToMovie : MonoBehaviour {

	public Camera movieCamera;
	public Camera roomCamera;

	private Camera currentCamera;
	private Camera[] cameras;

	private int currentCameraIndex = 0;

	// Use this for initialization
	void Start () 
	{
		cameras = new Camera[] { movieCamera, roomCamera };
		currentCamera = roomCamera;
		OnMouseDown ();
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void OnMouseDown ()
	{
		currentCamera.enabled = false;
		currentCamera = cameras[currentCameraIndex];
		currentCamera.enabled = true;
	}
}
