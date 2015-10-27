using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour {

	public Transform fading;

	public Camera movieCamera;
	public Camera VIPCamera;

	public float elapsedTime = 0.0f;

	void Start ()
	{
		VIPCamera.enabled = true;
		movieCamera.enabled = false;
	}
	
	void Update () 
	{
		Ray ray = Camera.main.ViewportPointToRay (new Vector3 (0.5f, 0.5f, 0));
		Debug.DrawRay (ray.origin, ray.direction * 10, Color.cyan);

		RaycastHit hit;

		if (Physics.Raycast (ray, out hit) == true) 
		{
			Debug.DrawRay (ray.origin, ray.direction * hit.distance, Color.red);

			if (hit.transform.gameObject.tag == "videoScreen") 
			{
				elapsedTime += Time.deltaTime;

				if (elapsedTime > 2.0f) 
				{
					Instantiate (fading, new Vector3 (0.0f, 0.0f, 0.0f), Quaternion.identity);
					VIPCamera.enabled = false;
					movieCamera.enabled = true;

					elapsedTime = 0.0f;

				}
			}
		}
	}
}
