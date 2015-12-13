using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeManager : MonoBehaviour
{
	public Text text;                      // Reference to the Text component.
	private float time;
	private float waveTime;
	
	void Awake ()
	{
		time = 0;
	}
	
	void Update ()
	{
		time += Time.deltaTime;
		text.text = time.ToString("#.#");
	}
}