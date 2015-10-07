using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class SavingGameScript : MonoBehaviour
{

	Selectable button;

	void start()
	{
		
	}

	void OnEnable () 
	{
		button = gameObject.GetComponent<Selectable>();
		Debug.Log(button.interactable.ToString());
	}

	public void save()
	{
		Debug.Log ("You saved!");

		BinaryFormatter binary = new BinaryFormatter ();
		FileStream fStream = File.Create (Application.persistentDataPath + "/savefile.sav");

		SaveManager saver = new SaveManager ();
		saver.points = ScoreCounter.points;
		//all other...

		binary.Serialize (fStream, saver);
		fStream.Close ();
	}

	public void load()
	{
		Debug.Log ("You loaded!");

		if (File.Exists(Application.persistentDataPath + "/savefile.sav")) 
		{
			BinaryFormatter binary = new BinaryFormatter();
			FileStream fStream = File.Open(Application.persistentDataPath + "/savefile.sav", FileMode.Open);
			SaveManager saver = (SaveManager)binary.Deserialize(fStream);
			fStream.Close();

			ScoreCounter.points = saver.points;
			//all stuff, give back to classes
		}
	}

}

[Serializable]
class SaveManager
{
	public float points;
	//add stuff...
}
