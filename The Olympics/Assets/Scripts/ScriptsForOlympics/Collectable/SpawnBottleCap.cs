using UnityEngine;
using System.Collections;

public class SpawnBottleCap : MonoBehaviour {

	public Transform prefabBottleCapDU;
	public Transform prefabBottleCapLR;
	public Transform prefabBottleCapZ;

	public int leftBottleCap = 1;
	public int rightBottleCap = 0;

	public int frontBottleCap = 0;
	public int behindBottleCap = 0;

	public float bottleCapSpawner = 0.0f;
	public float bottleCapSpawner2 = 0.0f;

	// Update is called once per frame
	void Update () 
	{
		bottleCapSpawner += Time.deltaTime;
		bottleCapSpawner2 += Time.deltaTime;

		if (bottleCapSpawner >= 1.5f) 
		{
			if(leftBottleCap == 1 && rightBottleCap == 0)
			{
				//Vertical Collectables left from the camera
				Instantiate (prefabBottleCapDU, new Vector3 (Random.Range (-8.0f, -4.0f), 8.0f, Random.Range (0.5f, 2.5f)), Quaternion.identity);

				//Horizontal Collectables left from the camera
				Instantiate (prefabBottleCapZ, new Vector3 (Random.Range(-7.0f, -4.5f), Random.Range(8.0f, 16.0f), -1), Quaternion.identity);

				leftBottleCap = 0;
				rightBottleCap = 1;

				//reset timer
				bottleCapSpawner = 0.0f;
			}

			else if(leftBottleCap == 0 && rightBottleCap == 1)
			{
				//Vertical Collectables right from the camera
				Instantiate (prefabBottleCapDU, new Vector3 (Random.Range (1.0f, 5.0f), 8.0f, Random.Range (0.5f, 2.5f)), Quaternion.identity);

				//Horizontal Collectables right from the camera
				Instantiate (prefabBottleCapZ, new Vector3 (Random.Range(1.0f, 5.0f), Random.Range(8.0f, 16.0f), -1), Quaternion.identity);

				leftBottleCap = 1;
				rightBottleCap = 0;

				//reset timer
				bottleCapSpawner = 0.0f;
			}
		}

		if (bottleCapSpawner2 >= 3.0f) 
		{
			if(frontBottleCap == 0 && behindBottleCap == 0)
			{
				//Vertical Collectables in front of camera
				//spawn in correct point :)
				frontBottleCap = 1;
				Instantiate (prefabBottleCapDU, new Vector3 (Random.Range (-3.5f, 3.5f), 8.0f, Random.Range (5.0f, 7.0f)), Quaternion.identity);

				//Horizontal Collectable behind the camera
				behindBottleCap = 1;
				Instantiate (prefabBottleCapLR, new Vector3 (-5.5f, Random.Range(8.0f, 16.0f), Random.Range (-0.5f, 1.5f)), Quaternion.identity);

				//reset spawner
				bottleCapSpawner2 = 0.0f;
			}

			else if (frontBottleCap == 1 && behindBottleCap == 1)
			{
				//Horizontal Collectables in front of camera
				//spawn in correct point :)
				frontBottleCap = 0;
				Instantiate (prefabBottleCapLR, new Vector3 (-5.5f, Random.Range(8.0f, 16.0f), Random.Range (5.5f, 7.5f)), Quaternion.identity);

				//Vertical Collectables behind the camera
				behindBottleCap = 0;
				Instantiate (prefabBottleCapDU, new Vector3 (Random.Range (-3.5f, 3.5f), 8.0f, Random.Range (-0.5f, 1.5f)), Quaternion.identity);

				//reset spawner
				bottleCapSpawner2 = 0.0f;
			}
		}
	}
}
