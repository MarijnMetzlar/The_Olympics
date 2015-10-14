using UnityEngine;
using System.Collections;

public class CameraSwitchToScoreBoard : MonoBehaviour {

	public Camera scoreBoardCamera;
	public Camera roomCamera;

	private Camera currentCamera;
	private Camera[] cameras;
	
	private int currentCameraIndex = 0;
	
	// Use this for initialization
	void Start () 
	{
		cameras = new Camera[] { scoreBoardCamera, roomCamera };
		currentCamera = roomCamera;
		OnMouseDown ();
	}
	
	void OnMouseDown ()
	{
		currentCamera.enabled = false;
		currentCamera = cameras[currentCameraIndex];
		currentCamera.enabled = true;
	}
}
