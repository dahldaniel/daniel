using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public float autoLoadNextLevel;

	public void LoadLevel(string name)
	{
		Application.LoadLevel (name);
	}

	public void LoadNextLevel()
	{
		Application.LoadLevel (Application.loadedLevel + 1);
	}

	// Use this for initialization
	void Start () 
	{
		Invoke ("LoadNextLevel", autoLoadNextLevel);
	}

		
}