using UnityEngine;
using System.Collections;

public class BackToRoomScene : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown ("backspace")) 
		{
			Application.LoadLevel ("The Olympics");
		}
	}
}
