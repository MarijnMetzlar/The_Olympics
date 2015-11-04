using UnityEngine;
using System.Collections;

public class ToNextScene : MonoBehaviour {

	public float elapsedTime = 0.0f;

	// Update is called once per frame
	void Update () 
	{
		elapsedTime += Time.deltaTime;

		if (elapsedTime >= 3.0f) 
		{
			Application.LoadLevel ("The Olympics");
		}
	}
}
