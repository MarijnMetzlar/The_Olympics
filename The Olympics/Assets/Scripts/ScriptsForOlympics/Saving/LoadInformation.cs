using UnityEngine;
using System.Collections;

public class LoadInformation
{
	public static void LoadAllInformation()
	{
		ScoreCounter.points = PlayerPrefs.GetFloat ("PLAYERSCORE");
	}

}
