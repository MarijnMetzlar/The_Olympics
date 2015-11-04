using UnityEngine;
using System.Collections;

public class ButtonTable : MonoBehaviour {

	public static bool clickedButton = false;

	public Renderer button;
	public Material activeButton;
	public Material notActiveButton;


	void OnMouseDown ()
	{
		if (clickedButton == true) 
		{
			clickedButton = false;
			button.material = notActiveButton;
		} 
		else 
		{
			clickedButton = true;
			button.material = activeButton;
		}
	}
}
