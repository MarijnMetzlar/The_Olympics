using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour {

	public Transform fading;
	public Transform lampPrefab;

	public AudioSource focusSoundTV;

	public Camera movieCamera;
	public Camera VIPCamera;

	public float elapsedTime = 0.0f;
	public float elapsedTime1 = 0.0f;
	public float elapsedTime2 = 0.0f;
	public float elapsedTime3 = 0.0f;
	
	public static float score;
	public static float updatedScore;

	public float clickOnce = 0.0f;
	public float clickOnce2 = 0.0f;
	public float clickOnce3 = 0.0f;

	void Start ()
	{
		VIPCamera.enabled = true;
		movieCamera.enabled = false;
	}
	
	void Update () 
	{
		score = ScoreCounter.points;

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
					//sound
					focusSoundTV.Play();

					//change camera
					Instantiate (fading, new Vector3 (0.0f, 0.0f, 0.0f), Quaternion.identity);
					VIPCamera.enabled = false;
					movieCamera.enabled = true;

					elapsedTime = 0.0f;

				}
			}

			else if (hit.transform.gameObject.tag == "Screen1")
			{
				elapsedTime1 += Time.deltaTime;

				if (elapsedTime1 > 2.0f && score >= 20.0f && clickOnce == 0.0f)
				{
					//sound
					focusSoundTV.Play();

					updatedScore -= 20.0f;
					clickOnce += 1.0f;
					Instantiate (lampPrefab, new Vector3 (4.0f, 2.0f, 734.1f), Quaternion.identity);

					elapsedTime1 = 0.0f;
				}

				else if(score <= 20.0f && clickOnce == 0.0f )
				{
					elapsedTime1 = 0.0f;
				}

				else if(clickOnce == 1.0f)
				{
					elapsedTime1 = 0.0f;
				}
			}

			else if (hit.transform.gameObject.tag == "Screen2")
			{
				elapsedTime2 += Time.deltaTime;
				
				if (elapsedTime2 > 2.0f && score >= 50.0f && clickOnce2 == 0.0f)
				{
					focusSoundTV.Play();

					updatedScore -= 50.0f;
					clickOnce2 += 1.0f;
					Debug.Log ("You bought item2");

					elapsedTime2 = 0.0f;
				}

				else if(score <= 50.0f && clickOnce2 == 0.0f)
				{
					elapsedTime2 = 0.0f;
				}

				else if(clickOnce2 == 1.0f)
				{
					elapsedTime2 = 0.0f;
				}
			}

			else if (hit.transform.gameObject.tag == "Screen3")
			{
				elapsedTime3 += Time.deltaTime;
				
				if (elapsedTime3 > 2.0f && score >= 100.0f && clickOnce3 == 0.0f)
				{
					focusSoundTV.Play();

					updatedScore -= 100.0f;
					clickOnce3 += 1.0f;
					Debug.Log ("You bought item3");
					
					elapsedTime3 = 0.0f;
				}

				else if(score <= 100.0f  && clickOnce3 == 0.0f)
				{
					elapsedTime3 = 0.0f;
				}

				else if(clickOnce3 == 1.0f)
				{
					elapsedTime3 = 0.0f;
				}
			}
		}
	}
}
