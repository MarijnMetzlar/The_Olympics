using UnityEngine;
using System.Collections;

public class RobotText : MonoBehaviour {

	public TextMesh robotText;
	public string text;

	//" + "\n" + "

	void TextOne()
	{
		robotText.text = ("Greetings, I have been waiting" + "\n" + "for your arrival! (press me)");
	}

	void TextTwo()
	{
		robotText.text = ("Hello, it's me Mr. Tuffy! If you" + "\n" + "need any help, press me to" + "\n" + "initiate my assistance.");
	}

	void TextThree()
	{
		robotText.text = ("To change the channel of the TV," + "\n" + "press on either side of the screen.");
	}

	void TextFour()
	{
		robotText.text = ("If you want to view the video feed," + "\n" + "focus your sight on the blue TV screen." + "\n" +  "If you want to return to the VIP room," + "\n" + "press the button on the side of the VR.");
	}

	void TextFive()
	{
		robotText.text = ("On your laptop you can buy items," + "\n" + "however you will need money.");
	}

	void TextSix()
	{
		robotText.text = ("To earn money, you need to start" + "\n" + "the game by pressing the red button" + "\n" + "next to me!");
	}

	void TextSeven()
	{
		robotText.text = ("To collect the items that appear," + "\n" + "look directly at them for a short time." + "\n" + "You gain currency for each object collected.");
	}

	void TextEight()
	{
		robotText.text = ("When playing the game, keep a good " + "\n" + "eye out. Sometimes special items appear," + "\n" + "that are worth more.");
	}

	void TextNine()
	{
		robotText.text = ("To navigate the laptop screens, click on" + "\n" + "the touchpad. To buy an item," + "\n" + "focus your sights on it for 2 seconds.");
	}

	void TextTen()
	{
		robotText.text = ("If you need any further assistance, press me again.");
	}

	void TextEleven()
	{
		robotText.text = ("");
	}
}
