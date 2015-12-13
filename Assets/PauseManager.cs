using UnityEngine;
using System.Collections;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class PauseManager : MonoBehaviour {
	
	public GameObject pauseMenu;
	private bool paused = false;
	
	
	void Start()
	{

	}
	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			togglePause();
		}
	}
	
	public void togglePause(){
		paused = !paused;
		pauseMenu.SetActive (paused);
		Pause();
	}
	
	private void Pause()
	{
		Time.timeScale = Time.timeScale == 0 ? 1 : 0;
	}
	
	public void Quit()
	{
		#if UNITY_EDITOR 
		EditorApplication.isPlaying = false;
		#else 
		Application.Quit();
		#endif
	}
}