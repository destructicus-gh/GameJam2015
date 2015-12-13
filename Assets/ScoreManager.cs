using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
	public static int score;        // The player's score.
	

	public Text text;               // Reference to the Text component.
	
	
	void Awake ()
	{
		score = 0;
	}
	
	
	void Update ()
	{
		text.text = score.ToString();
	}
}