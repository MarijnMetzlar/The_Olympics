using UnityEngine;
using System.Collections;

using System.Collections.Generic; 
using System.Runtime.Serialization.Formatters.Binary; 
using System.IO;

public static class SaveInformation
{
	public static void SaveAllInformation()
	{
		PlayerPrefs.SetFloat ("PLAYERSCORE", ScoreCounter.points);

	}
}
