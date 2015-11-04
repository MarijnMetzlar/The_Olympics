using UnityEngine;
using System.Collections;

public class Robot : MonoBehaviour {

	public GameObject text;
	public AudioSource robotSound;

	public int talkingRobot = 0;

	void Start()
	{
		text.SendMessage("TextOne");
	}

	void OnMouseDown()
	{
		robotSound.Play ();
		talkingRobot += 1;

		if (talkingRobot == 1) 
		{
			text.SendMessage("TextTwo");
		}

		else if (talkingRobot == 2) 
		{
			text.SendMessage("TextThree");
		}

		else if (talkingRobot == 3) 
		{
			text.SendMessage("TextFour");
		}

		else if (talkingRobot == 4) 
		{
			text.SendMessage("TextFive");
		}

		else if (talkingRobot == 5) 
		{
			text.SendMessage("TextSix");
		}

		else if (talkingRobot == 6) 
		{
			text.SendMessage("TextSeven");
		}

		else if (talkingRobot == 7) 
		{
			text.SendMessage("TextEight");
		}

		else if (talkingRobot == 8) 
		{
			text.SendMessage("TextNine");
		}

		else if (talkingRobot == 9) 
		{
			text.SendMessage("TextTen");
		}

		else if (talkingRobot == 10) 
		{
			text.SendMessage("TextEleven");
			talkingRobot = 0;
		}
	}
}
