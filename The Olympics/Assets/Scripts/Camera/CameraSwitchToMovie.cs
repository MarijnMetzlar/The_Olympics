using UnityEngine;
using System.Collections;

public class CameraSwitchToMovie : MonoBehaviour {

	public Camera movieCamera;
	public Camera VIPCamera;

	private Camera currentCamera;
	private Camera[] cameras;

	private int currentCameraIndex = 0;

	// Use this for initialization
	void Start () 
	{
		cameras = new Camera[] { movieCamera, VIPCamera };
		currentCamera = VIPCamera;
	}

	void OnMouseDown ()
	{
		currentCamera.enabled = false;
		currentCamera = cameras[currentCameraIndex];
		currentCamera.enabled = true;
	}
}
