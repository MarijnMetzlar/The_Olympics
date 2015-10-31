using UnityEngine;
using System.Collections;

public class RaycastVideo : MonoBehaviour {

	public AudioSource focusSoundCollectable;

	public float elapsedTime = 0.0f;
	public static float updatedScore;

	// Update is called once per frame
	void Update () 
	{
		Ray ray = Camera.main.ViewportPointToRay (new Vector3 (0.5f, 0.5f, 0));
		Debug.DrawRay (ray.origin, ray.direction * 10, Color.cyan);
		
		RaycastHit hit;
		
		if (Physics.Raycast (ray, out hit) == true) 
		{
			Debug.DrawRay (ray.origin, ray.direction * hit.distance, Color.red);

			if(hit.transform.gameObject.tag == "BottleCap")
			{

				elapsedTime += Time.deltaTime;

				if(elapsedTime > 0.2f)
				{
					focusSoundCollectable.Play();

					Destroy (hit.transform.gameObject);
					updatedScore += 15.0f;

					elapsedTime = 0.0f;
				}
			}
		}
	}
}
