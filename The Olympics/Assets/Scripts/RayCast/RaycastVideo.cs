using UnityEngine;
using System.Collections;

public class RaycastVideo : MonoBehaviour {

	public AudioSource focusSoundCollectable;

	public Renderer pointer;
	public Texture neutralPointerTexture;
	public Texture selectedPointerTexture;

	public float elapsedTime = 0.0f;
	public float goldenRingTime = 0.0f;
	public static float updatedScore;

	// Update is called once per frame
	void Update () 
	{
		Ray ray = Camera.main.ViewportPointToRay (new Vector3 (0.5f, 0.5f, 0));
		Debug.DrawRay (ray.origin, ray.direction * 1000, Color.cyan);
		
		RaycastHit hit;
		
		if (Physics.Raycast (ray, out hit) == true) 
		{
			Debug.DrawRay (ray.origin, ray.direction * hit.distance, Color.red);

			if(hit.transform.gameObject.tag == "BottleCap")
			{
				pointer.material.mainTexture = selectedPointerTexture;
				elapsedTime += Time.deltaTime;

				if(elapsedTime > 2.0f)
				{
					focusSoundCollectable.Play();

					Destroy (hit.transform.gameObject);
					ScoreCounter.points += 5.0f;
					elapsedTime = 0.0f;
				}
			}

			if(hit.transform.gameObject.tag == "GoldenRing")
			{
				pointer.material.mainTexture = selectedPointerTexture;
				goldenRingTime += Time.deltaTime;

				if(goldenRingTime > 5.0f)
				{
					//maybe a sound?

					Destroy (hit.transform.gameObject);
					ScoreCounter.points += 100.0f;
					goldenRingTime = 0.0f;
				}
			}

			else
			{
				pointer.material.mainTexture = neutralPointerTexture;
			}
		}
	}
}
