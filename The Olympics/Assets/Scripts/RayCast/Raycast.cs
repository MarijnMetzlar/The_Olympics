using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour {

	public Transform fading;
	public GameObject lampPrefab;
	
	public AudioSource focusSoundTV;

	public Camera movieCamera;
	public Camera VIPCamera;

	public float timer = 2.0f;
	
	public static float score;
	public static float updatedScore;

	private bool[] boughtObjects = new bool[3];

	public Renderer pointer;
	public Texture neutralPointerTexture;
	public Texture selectedPointerTexture;

	void Start ()
	{
		VIPCamera.enabled = false;
		movieCamera.enabled = true;
	}
	
	void Update () 
	{
		Ray ray = Camera.main.ViewportPointToRay (new Vector3 (0.5f, 0.5f, 0));
		pointer.material.mainTexture = neutralPointerTexture;
		Debug.DrawRay (ray.origin, ray.direction * 1000, Color.cyan);

		RaycastHit hit;

		if (Physics.Raycast (ray, out hit) == true) 
		{
			Debug.DrawRay (ray.origin, ray.direction * hit.distance, Color.red);
			RayHit(hit);
		}
	}

	private void RayHit(RaycastHit hit)
	{
		pointer.material.mainTexture = neutralPointerTexture;
		bool hitSomething = true;
		int price = 0;
		int selectedObject = 99999;
		GameObject reward = lampPrefab;
		Vector3 rewardLocation = lampPrefab.transform.position;
		switch (hit.transform.gameObject.tag) {
		case "videoScreen":
			pointer.material.mainTexture = selectedPointerTexture;


			hitSomething = false;
			timer -= Time.deltaTime;
			//change camera
			if(timer <= 0)
			{
			//sound
			focusSoundTV.Play();
			//FADING
			//Instantiate (fading, new Vector3 (0.0f, 0.0f, 0.0f), Quaternion.identity);

			VIPCamera.enabled = false;
			movieCamera.enabled = true;
			timer = 2.0f;
			}
			
			break;
		case "Screen1":
			price = 20;
			reward = lampPrefab;
			rewardLocation = new Vector3 (12.6f, 2.577f, 760.0f);
			selectedObject = 0;
			break;
		case "Screen2":
			price = 50;
			reward = lampPrefab;
			rewardLocation = new Vector3 (4.0f, 12.0f, 734.1f);
			selectedObject = 1;
			break;

		case "Screen3":
			price = 100;
			reward = lampPrefab;
			rewardLocation = new Vector3 (4.0f, 22.0f, 734.1f);
			selectedObject = 2;
			break;
		default:
			pointer.material.mainTexture = neutralPointerTexture;
			hitSomething = false;
			timer = 2.0f;
			break;
		}

		if (hitSomething) {
			if(boughtObjects[selectedObject] == true)
				return;
			pointer.material.mainTexture = selectedPointerTexture;
			timer -= Time.deltaTime;
			if(timer <= 0)
			{
				if(ScoreCounter.points >= price)
				{
					boughtObjects[selectedObject] = true;
					ScoreCounter.points -= price;
					Instantiate(reward, rewardLocation, Quaternion.identity);
					//sound
					focusSoundTV.Play();
					timer = 2.0f;
				}
			}
		}
	}
}
