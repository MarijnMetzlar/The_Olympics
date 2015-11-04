using UnityEngine;
using System.Collections;

public class CameraSwitchToMovie : MonoBehaviour {

	public Transform fading;

	public Camera movieCamera;
	public Camera VIPCamera;

	private Camera currentCamera;
	private Camera[] cameras;

	private int currentCameraIndex = 0;

	// Use this for initialization
	void Start () 
	{
		cameras = new Camera[] { movieCamera, VIPCamera };
		currentCamera = movieCamera;
	}

	void ChangeToMovie ()
	{
		Instantiate(fading, new Vector3 (0.0f, 0.0f, 0.0f), Quaternion.identity);

		currentCamera.enabled = false;
		currentCamera = cameras[currentCameraIndex];
		currentCamera.enabled = true;
	}
}
