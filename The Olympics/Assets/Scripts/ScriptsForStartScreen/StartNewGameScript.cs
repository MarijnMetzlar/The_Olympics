using UnityEngine;
using System.Collections;

public class StartNewGameScript : MonoBehaviour {

	void OnMouseDown()
	{
		Application.LoadLevel ("The Olympics");
	}
}
