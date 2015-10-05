﻿using UnityEngine;
using System.Collections;

public class SpawnBall : MonoBehaviour {

	public Transform prefab1;
	public Transform prefab2;

	public static float score;
	public float updatedScore;

	public float clickOncePrefab1 = 0.0f;
	public float clickOncePrefab2 = 0.0f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		updatedScore = score;
		score = ScoreCounter.points;

		//OnMouseDown ();
		//Just For Fun
	}

	void OnMouseDown ()
	{
		if (score > 5 && score < 15 && clickOncePrefab1 == 0) 
		{
			Instantiate (prefab1, new Vector3 (12.0f, 2.5f, Random.Range (21.0f, 25.0f)), Quaternion.identity);
			updatedScore = score - 5;
			clickOncePrefab1 += 1.0f;
		}

		if (score > 15 && score < 25 && clickOncePrefab2 == 0) 
		{
			Instantiate (prefab2, new Vector3 (12.0f, 2.5f, Random.Range (21.0f, 25.0f)), Quaternion.identity);
			updatedScore = score - 15;
			clickOncePrefab2 += 1.0f;
		}
	}
}
